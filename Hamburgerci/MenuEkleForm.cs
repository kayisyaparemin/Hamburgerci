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
    public partial class MenuEkleForm : Form
    {
        public MenuEkleForm()
        {
            InitializeComponent();

        }

        private void btnYeniMenuKaydet_Click(object sender, EventArgs e)
        {
            if (txtEkleMenuAdi.Text.Length > 0)
            {
                Menu yeniMenu = new Menu();
                yeniMenu.Ad = txtEkleMenuAdi.Text;
                yeniMenu.Fiyat = nudEklEMenuFiyati.Value;
                SiparisOlusturForm.Menuler.Add(yeniMenu);
                MessageBox.Show("Menü Kaydedildi!");
            }
            else
            {
                MessageBox.Show("Menü adı boş bırakılamaz!");
            }
            
        }
    }
}
