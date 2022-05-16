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
                //aynı menü eklenmesin ve menü fiyatı 0 olamasın
                Menu yeniMenu = new Menu();
                yeniMenu.Ad = txtEkleMenuAdi.Text;
                yeniMenu.Fiyat = nudEklEMenuFiyati.Value;
                foreach (Menu item in SiparisOlusturForm.Menuler)
                {
                    if (item.Ad == txtEkleMenuAdi.Text || item.Ad.ToLower() == txtEkleMenuAdi.Text || item.Ad.Trim() == txtEkleMenuAdi.Text)
                    {
                        MessageBox.Show("Bu menü zaten mevcuttur!");
                        return;
                    }
                }
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
