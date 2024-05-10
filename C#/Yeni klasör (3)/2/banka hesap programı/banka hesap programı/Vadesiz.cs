    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace banka_hesap_programı
    {
        class Vadesiz:BankaHesap
        {
            public static double yatırılanbakiye;
            public static double cekilenBakiye;
            public double arttır { get { return yatırılanbakiye; } set {yatırılanbakiye=value;
            bakiyeArttır();
            }
            }
            public double azalt { get { return cekilenBakiye; } set { cekilenBakiye = value;
            bakiyeAzalt();
            }
            }
            public void bakiyeArttır()
            {
                bakiye = bakiye + yatırılanbakiye;
                
            }
            public void bakiyeAzalt()
            {
                bakiye = bakiye - cekilenBakiye;
            }
        }
    }
