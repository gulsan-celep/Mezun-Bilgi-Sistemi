using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevi
{
   public class Ogrenci_Bilgi
    {
        public string Adi { get; set; }
        public string Adres { get; set; }
        public uint Telefon { get; set; }
        public string e_posta { get; set; }
        public string Uyruk { get; set; }
        public string Dogum_tarihi { get; set; }
        public uint Ogrenci_No  { get; set; }
        public string Yabanci_dil { get; set; }
        public string Ilgi_Alani { get; set; }
        public int no { get; set; }
        public Staj_Bilgileri staj = new Staj_Bilgileri();
        public Mezun_Bilgi_Sistemi mezun = new Mezun_Bilgi_Sistemi();
    }
}
