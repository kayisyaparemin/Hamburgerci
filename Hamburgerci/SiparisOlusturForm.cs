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
    public partial class SiparisOlusturForm : Form
    {

        public static List<Siparis> Siparisler = new List<Siparis>();
        public static List<Siparis> TumSiparisler = new List<Siparis>();
        decimal toplamFiyat = 0;
        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu() { Ad = "Whopper", Fiyat = 62.99m },
            new Menu() { Ad = "Double Whopper", Fiyat = 58.99m },
            new Menu() { Ad = "King Beef Burger", Fiyat = 84.99m },
            new Menu() { Ad = "Plant Whopper", Fiyat = 62.99m },
            new Menu() { Ad = "BK Crispy Chicken", Fiyat = 44.99m },
            new Menu() { Ad = "BK Kral Burger", Fiyat = 74.99m },
            new Menu() { Ad = "Barbeko Burger", Fiyat = 49.99m },
            new Menu() { Ad = "Etli Barbekü Brioche", Fiyat = 69.99m }
        };
        public static List<Sos> Soslar = new List<Sos>()
        {
            new Sos() { Ad = "Ketçap", Fiyat = 0 },
            new Sos() { Ad = "Mayonez", Fiyat = 0 },
            new Sos() { Ad = "Ranch", Fiyat = 2.5m },
            new Sos() { Ad = "BBQ", Fiyat = 2.5m },
            new Sos() { Ad = "Buffalo", Fiyat = 2.5m }
        };
        public SiparisOlusturForm()
        {
            InitializeComponent();
            rbKucuk.Checked = true;

        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            btnSiparişTamamla.Enabled = true;
            toplamFiyat = 0;

            Siparis siparis = new Siparis();

            //Seçilen Menü alındı ve siparişe eklendi.
            siparis.MenuSecimi = (Menu)cmbMenuler.SelectedItem;

            //Boy seçimi alındı ve siparişe eklendi.
            if (rbBuyuk.Checked)
            {
                siparis.BoyutSecimi = Boyut.Büyük;
            }
            if (rbOrta.Checked)
            {
                siparis.BoyutSecimi = Boyut.Orta;
            }
            if (rbKucuk.Checked)
            {
                siparis.BoyutSecimi = Boyut.Küçük;
            }

            //Seçilen Ekstralar alınıyor ve Sipariş içindeki listeye ekleniyor.
            foreach (CheckBox item in flpEkstralar.Controls)
            {
                if (item.Checked)
                {
                    Sos sos = Soslar.Find(x => x.Ad == item.Text);
                    siparis.SosSecimi.Add(sos);
                }
            }

            //Sipariş adeti alınıyor.
            siparis.Adet = (int)nudSiparisAdet.Value;

            lbxSiparisler.Items.Add(siparis);

            //Sipariş yazdırmak ve fiyatları toplamak için siparişler listesine ekleniyor.
            Siparisler.Add(siparis);

            //Sipariş Ciro hesaplamak için tüm siparişlere gönderiliyor.
            TumSiparisler.Add(siparis);

            TutarHesapla();

            KontrolTemizle();


        }

        private void TutarHesapla()
        {
            foreach (Siparis item in Siparisler)
            {
                toplamFiyat += item.Tutar;
            }

            lblTutar.Text = toplamFiyat.ToString("00.##");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Menüler ComboBox'a ekleniyor
            foreach (Menu item in Menuler)
            {
                cmbMenuler.Items.Add(item);
            }
            cmbMenuler.SelectedIndex = 0;
            //Soslar panele ekleniyor.
            foreach (var item in Soslar)
            {
                flpEkstralar.Controls.Add(new CheckBox() { Text = item.Ad });
            }
            if (lbxSiparisler.Items.Count == 0)
            {
                btnSiparişTamamla.Enabled = false;
            }
        }

        private void btnSiparişTamamla_Click(object sender, EventArgs e)
        {

            var dr = MessageBox.Show(
                $"Siparişlerinizin toplam tutarı {Siparisler.Sum(x => x.Tutar)}₺.Onaylıyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo
                );
            if (dr == DialogResult.Yes)
            {
                KontrolTemizle();
                lbxSiparisler.Items.Clear();
                lblTutar.Text = "0";
                btnSiparişTamamla.Enabled = false;
                toplamFiyat = 0;
                Siparisler.Clear();
                MessageBox.Show("Siparişiniz alındı!");
            }
            else
            {
                var dr2 = MessageBox.Show("Siparişler sıfırlansın mı?","Onay",MessageBoxButtons.YesNo);
                if (dr2 == DialogResult.Yes)
                {
                    KontrolTemizle();
                    lbxSiparisler.Items.Clear();
                    lblTutar.Text = "0";
                    btnSiparişTamamla.Enabled = false;
                    toplamFiyat = 0;
                    Siparisler.Clear();
                }
                else
                {
                    return;
                }

            }

        }
        private void KontrolTemizle()
        {
            foreach (CheckBox item in flpEkstralar.Controls)
            {
                item.Checked = false;
            }
            rbBuyuk.Checked = false;
            rbKucuk.Checked = true;
            rbOrta.Checked = false;
            cmbMenuler.SelectedIndex = 0;

        }
    }
}
