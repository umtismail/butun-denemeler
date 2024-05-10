using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace veritabanı
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        
        public Form1()
        {
            InitializeComponent();
        }
        void gri()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kutuphane.accdb");
            da = new OleDbDataAdapter("SElect *from kitap", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kitap");
            dataGridView1.DataSource = ds.Tables["kitap"];
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gri();
            
            
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            { 
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into kitap (kad,kyazar,isbn,ktur,kira,kirasay,eklemetarihi) values (@kad,@kyazar,@isbn,@tur,@kira,@kirasay,@eklemetarihi)";
            cmd.Parameters.AddWithValue("@kad", tbkad.Text);
            cmd.Parameters.AddWithValue("@kyazar", tbkyazar.Text);
            cmd.Parameters.AddWithValue("@isbn", tbisbn.Text);
            cmd.Parameters.AddWithValue("@tur", textBox1.Text);
            cmd.Parameters.AddWithValue("@kira", "0");
            cmd.Parameters.AddWithValue("@kirasay", "0");
            cmd.Parameters.AddWithValue("@eklemetarihi", dateTimePicker1.Value.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            gri();
            }
            catch(Exception h)
            {
                MessageBox.Show(h.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Start();
            int a = dataGridView1.SelectedCells[0].RowIndex;
            tbkad.Text = dataGridView1.Rows[a].Cells[1].Value.ToString();
            tbkyazar.Text = dataGridView1.Rows[a].Cells[2].Value.ToString();
            tbisbn.Text = dataGridView1.Rows[a].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.Rows[a].Cells[4].Value.ToString();
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            kitapturu frm = new kitapturu();
            frm.Show();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "delete from kitap where kid=" + label8.Text + "";
                cmd.ExecuteNonQuery();
                con.Close();
                gri();
            }
            catch(Exception h)
            {
                MessageBox.Show(h.Message);
            }
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update kitap set = " + "'" + textBox2.Text + "where kid=" + label8.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            gri();
        
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = dataGridView1.SelectedCells[0].RowIndex;
            label8.Text = dataGridView1.Rows[a].Cells[0].Value.ToString();
        }

        

    }
}
