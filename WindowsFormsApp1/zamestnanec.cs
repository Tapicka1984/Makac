using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class zamestnanec
    {
        string Jmeno;
        string Prijmeni;
        readonly double Hodinova_Mzda;

        DateTime Datum_Nastupu;
        TimeSpan Odprac_dny;
        int Odpracovane_hodiny;

        public zamestnanec(string Jmeno, string Prijmeni, double Hodinova_Mzda, DateTime Datum_Nastupu, int Odpracovane_hodiny)
        {
            this.Jmeno = Jmeno;
            this.Prijmeni = Prijmeni;
            this.Hodinova_Mzda = Hodinova_Mzda;
            this.Datum_Nastupu = Datum_Nastupu;
            this.Odpracovane_hodiny = Odpracovane_hodiny;
        }

        TimeSpan PocetDni()
        {
            DateTime now = DateTime.Now;
            Odprac_dny = now - Datum_Nastupu;
            return Odprac_dny;
        }

        public virtual double Mzda()
        {
            return Odpracovane_hodiny * Hodinova_Mzda;
        }

        public virtual string info()
        {
            return String.Format("\nMoje jmeno je: {0} \n" +
                                 "Prijmeni je: {1} \n" +
                                 "V praci travim už :{2} dni\n" +
                                 "vydelal jsem si : {3}\n" +
                                 "moje hodinova mzda je: {4}\n" +
                                 "odmakal jsem už: {5} hodin" +
                                 "", Jmeno, Prijmeni, PocetDni().Days, Mzda(), Hodinova_Mzda, Odpracovane_hodiny);
        }
    }
}
