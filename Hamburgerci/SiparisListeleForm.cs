using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    public partial class SiparisListeleForm : Form
    {
        
        public SiparisListeleForm(List<Siparis> siparisler)
        {
            InitializeComponent();
            foreach (Siparis item in siparisler)
            {
                lbxTumSiparisler.Items.Add(item);
            }
            lblToplamSiparisSayisi.Text = siparisler.Count.ToString();
            decimal ciro = 0,sosKazanci=0,satilanUrunAdedi=0;
            foreach (Siparis siparis in siparisler)
            {
                if (siparis.SosSecimi.Count > 0)
                {
                    satilanUrunAdedi += siparis.SosSecimi.Count;
                    foreach (Sos sos in siparis.SosSecimi)
                    {
                        sosKazanci += sos.Fiyat;
                    }
                }
                ciro += siparis.Hesapla();
                satilanUrunAdedi += siparis.Adet;
            }
            
            lblCiro.Text = ciro.ToString()+ "₺";
            lblExtraMalzemeGeliri.Text = sosKazanci.ToString()+ "₺";
            lblSatilanUrunAdedi.Text = satilanUrunAdedi.ToString();
        }

        

        
    }
}
