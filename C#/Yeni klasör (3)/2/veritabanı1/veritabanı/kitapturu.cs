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
    public partial class kitapturu : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public kitapturu()
        {
            InitializeComponent();
        }
        void gri()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kutuphane.accdb");
            da = new OleDbDataAdapter("SElect *from kitap_tur", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kitap_tur");
            dataGridView1.DataSource = ds.Tables["kitap_tur"];
            con.Close();
        }
        private void kitaptürücs_Load(object sender, EventArgs e)
        {
            gri();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into kitap_tür (t_isim) values (@t_isim)";
            cmd.Parameters.AddWithValue("@t_isim", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            gri();
        }
    }
}
