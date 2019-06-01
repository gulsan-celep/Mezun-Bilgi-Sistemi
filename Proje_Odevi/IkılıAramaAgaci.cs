using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevi
{
   public class IkılıAramaAgaci
    {
        private İkiliAramaAgacDugumu kok;
        public string dugumler,temp,i;
        public IkılıAramaAgaci()
        {
        }
        public IkılıAramaAgaci(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            dugumler = "";
            temp = "";
            i = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        private void Ziyaret(İkiliAramaAgacDugumu dugum)
        {
          
            dugumler += dugum.veri.Adi +Environment.NewLine+ dugum.veri.mezun.Bolum_Adı+Environment.NewLine;
            if(dugum.veri.mezun.Not_Ortalama>=90)
            temp += dugum.veri.Adi + " "+ dugum.veri.mezun.Bolum_Adı + Environment.NewLine;
            if (dugum.veri.Yabanci_dil == "Advanced")
                i += dugum.veri.Adi + " " + dugum.veri.mezun.Bolum_Adı + Environment.NewLine;
        }
        public void Ekle(Ogrenci_Bilgi o)
        {
            İkiliAramaAgacDugumu tempParent = new İkiliAramaAgacDugumu();
            İkiliAramaAgacDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                if (o == tempSearch.veri)
                    return ;
                else if (o.Ogrenci_No < tempSearch.veri.Ogrenci_No)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(o);
            //Ağaç boş, köke ekle
            if (kok == null)
                kok = eklenecek;
            else if (o.Ogrenci_No<tempParent.veri.Ogrenci_No)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
            
        }
        public İkiliAramaAgacDugumu Ara(int anahtar)
        {
            return AraInt(kok, anahtar);
        }
        private İkiliAramaAgacDugumu AraInt(İkiliAramaAgacDugumu dugum,
                                           int anahtar)
        {
            if (dugum == null)
                return null;
            else if (dugum.veri.Ogrenci_No == anahtar)
                return dugum;
            else if (dugum.veri.Ogrenci_No > anahtar)
                return (AraInt(dugum.sol, anahtar));
            else
                return (AraInt(dugum.sag, anahtar));
        }
     
        public İkiliAramaAgacDugumu Guncelle(Ogrenci_Bilgi anahtar)
        {
            return GuncelleInt(kok, anahtar);
        }
        private İkiliAramaAgacDugumu GuncelleInt(İkiliAramaAgacDugumu dugum,
                                           Ogrenci_Bilgi anahtar)
        {
            if (dugum == null)
                return null;
            else if (dugum.veri.Ogrenci_No == anahtar.Ogrenci_No)
            {
                dugum.veri = anahtar;
                return dugum;
            }
            else if (dugum.veri.Ogrenci_No > anahtar.Ogrenci_No)
                return (GuncelleInt(dugum.sol, anahtar));
            else
                return (GuncelleInt(dugum.sag, anahtar));
        }
        private İkiliAramaAgacDugumu Successor(İkiliAramaAgacDugumu silDugum)
        {
            İkiliAramaAgacDugumu successorParent = silDugum;
            İkiliAramaAgacDugumu successor = silDugum;
            İkiliAramaAgacDugumu current = silDugum.sag;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.sol;
            }
            if (successor != silDugum.sag)
            {
                successorParent.sol = successor.sag;
                successor.sag = silDugum.sag;
            }
            return successor;
        }

     
        public bool Sil(int deger)
        {
            İkiliAramaAgacDugumu current = kok;
            İkiliAramaAgacDugumu parent = kok;
            bool issol = true;
            while (current.veri.Ogrenci_No != deger)
            {
                parent = current;
                if (deger <current.veri.Ogrenci_No)
                {
                    issol = true;
                    current = current.sol;
                }
                else
                {
                    issol = false;
                    current = current.sag;
                }
                if (current == null)
                    return false;
            }
            if (current.sol == null && current.sag == null)
            {
                if (current == kok)
                    kok = null;
                else if (issol)
                    parent.sol = null;
                else
                    parent.sag = null;
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.sag == null)
            {
                if (current == kok)
                    kok = current.sol;
                else if (issol)
                    parent.sol = current.sol;
                else
                    parent.sag = current.sol;
            }
            else if (current.sol == null)
            {
                if (current == kok)
                    kok = current.sag;
                else if (issol)
                    parent.sol = current.sag;
                else
                    parent.sag = current.sag;
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
          else
            {
                İkiliAramaAgacDugumu successor = Successor(current);
                if (current == kok)
                    kok = successor;
                else if (issol)
                    parent.sol = successor;
                else
                    parent.sag = successor;
                successor.sol = current.sol;
            }
            
            return true;
        }

        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }

    }
}
