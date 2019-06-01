using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevi
{
   public class HashEntry
    {
        private int anahtar;

        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }
        private Heap deger;

        public Heap Deger
        {
            get { return deger; }
            set { deger = value; }
        }

        public HashEntry(int anahtar, Heap deger)
        {
            this.anahtar = anahtar;
            this.deger = deger;
        }

    }
}
