using System;
using System.Collections.Generic;
using System.Text;

namespace Pr11
{
    class Zamestnanec
    {
        protected string jmeno;
        protected DateTime datum_narozeni = new DateTime();
        protected int mzda_h;
        protected int odpracovano_h;


        public Zamestnanec(string jmeno, int odpracovano_h, DateTime datum_narozeni, int mzda_h)
        {
            this.jmeno = jmeno;
            this.odpracovano_h = 0;
            this.datum_narozeni = datum_narozeni;
            this.mzda_h = mzda_h;
        }
        string vek (DateTime datum_narozeni)
        {
            TimeSpan age = (DateTime.Now - datum_narozeni);
            return age.ToString();
        }

        int mzda(int mzda_h, int odpracovano_h)
        {
            return mzda_h * odpracovano_h;
        }

        string vypis(string jmeno, DateTime datum_narozeni, int mzda_h, int odpravocano_h)
        {

            return "Jmeno" + jmeno + "  " + "vek" + datum_narozeni.ToString() + "  " + "Mzda" + mzda_h.ToString() + "  " + "Odpracovano hodin" + odpracovano_h.ToString();

        }

        void opracuj_hodiny(int plus_h, int odpracovano_h)
        {
            odpracovano_h = odpracovano_h + plus_h;
        }

   }

}
