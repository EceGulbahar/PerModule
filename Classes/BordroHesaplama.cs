using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerModule.Forms.BordrosForm
{
    public class BordroHesaplama
    {
        public static double sgkiscipayi = 0.14; // %14 vergi kesintisi
        public static double sgkissizlikpayi = 0.01; // %1 sigorta kesintisi
        public double gelirvergisimatrahı;
        public double gelirvergisi;
        public double iscipayindancikan;
        public double issizlikpayindancikan;
        public double damgadancikan;
        public double kesintilertoplami;
        public decimal netmaas;
        
        public decimal netucrethesapla(decimal brutx)
        {
            iscipayindancikan = Convert.ToDouble(brutx) * sgkiscipayi;
            issizlikpayindancikan = Convert.ToDouble(brutx) * sgkissizlikpayi;
            gelirvergisimatrahı = (double)(brutx - Convert.ToDecimal(iscipayindancikan + issizlikpayindancikan));
            damgadancikan = (double)(brutx * 756 / 100000 - Convert.ToDecimal(75.96));
            gelirvergisi = (gelirvergisimatrahı * 15 / 100) - 1276.02;
            kesintilertoplami = iscipayindancikan + issizlikpayindancikan + gelirvergisi + damgadancikan;
            netmaas = brutx - Convert.ToDecimal(kesintilertoplami);
            return netmaas;
        }
    }

}
