using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Nadrizeny : zamestnanec
    {
        string Titul;
        int priplatek;

        int Odpracovane_hodiny;
        double Hodinova_Mzda;
        public Nadrizeny(string jmeno, string Prijmeni, double Hodinova_Mzda, DateTime Datum_Nastupu, int Odpracovane_hodiny) : base(jmeno, Prijmeni, Hodinova_Mzda, Datum_Nastupu, Odpracovane_hodiny)
        {
            priplatek = 90;
            Titul = "boss";

            this.Odpracovane_hodiny = Odpracovane_hodiny;
            this.Hodinova_Mzda = Hodinova_Mzda;
        }

        public override double Mzda() 
        {
            return Odpracovane_hodiny * (Hodinova_Mzda + priplatek);
        }

        public override string info()
        {
            return String.Format("Titul je : {0} \n" + "A Priplatek mam :{1} dni\n" + "", Titul, priplatek + base.info());
                   
        }
    }
}
