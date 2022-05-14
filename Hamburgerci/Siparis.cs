using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci
{
    public class Siparis
    {
        public Siparis()
        {
            SosSecimi = new List<Sos>();
        }
        public Menu MenuSecimi { get; set; }

        public List<Sos> SosSecimi { get; set; }

        public Boyut BoyutSecimi { get; set; }

        public int Adet { get; set; }

        public decimal Tutar { get; set; }

        public override string ToString()
        {
            if (SosSecimi.Count < 1)
            {
                return $"{Adet} adet {MenuSecimi.Ad} {BoyutSecimi} Boy,{string.Join(",", SosSecimi)} {Hesapla().ToString("00.##")}₺";
            }
            else
            {
                return $"{Adet} adet {MenuSecimi.Ad} {BoyutSecimi} Boy, Soslar:{string.Join(",", SosSecimi)} {Hesapla().ToString("00.##")}₺";
            }
            
        }
        public Decimal Hesapla()
        {
            Tutar = 0;
            foreach (Sos item in SosSecimi)
            {
                Tutar += item.Fiyat;
            }
            if (BoyutSecimi == Boyut.Küçük)
            {
                Tutar += MenuSecimi.Fiyat * Adet;
            }
            if (BoyutSecimi == Boyut.Orta)
            {
                Tutar += (MenuSecimi.Fiyat * 1.1m) * Adet;
            }
            if (BoyutSecimi == Boyut.Büyük)
            {
                Tutar += (MenuSecimi.Fiyat * 1.25m) * Adet;
            }

            return Tutar;
        }



    }
}
