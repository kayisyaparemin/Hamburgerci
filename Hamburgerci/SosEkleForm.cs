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
    public partial class SosEkleForm : Form
    {
        public SosEkleForm()
        {
            InitializeComponent();
        }

        private void btnYeniMenuKaydet_Click(object sender, EventArgs e)
        {
            if (txtEkleSosAdi.Text.Length > 0)
            {
                Sos yeniSos = new Sos() { Ad = txtEkleSosAdi.Text, Fiyat = nudEkleSosFiyati.Value };
                SiparisOlusturForm.Soslar.Add(yeniSos);
                MessageBox.Show("Extra Malzeme Kaydedildi!");
            }
            else
            {
                MessageBox.Show("Extra malzeme adı boş bırakılamaz!");
            }
        }
    }
}
