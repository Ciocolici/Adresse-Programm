using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adresse_Programm
{
    internal class Adresse
    {
        private string strasse;
        private string hausnummer;
        private string ort;
        private string plz;

        public string Strasse { get => strasse; set => strasse = value; }
        public string Hausnummer { get => hausnummer; set => hausnummer = value; }
        public string Ort { get => ort; set => ort = value; }
        public string Plz { get => plz; set => plz = value; }

        public Adresse(string strasse, string hausnummer, string ort, string plz)
        {
            this.Strasse = strasse;
            this.Hausnummer = hausnummer;
            this.Ort = ort;
            this.Plz = plz;
        } 

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nAdresse:\n");
            Console.WriteLine($"Strasse: {Strasse}");
            Console.WriteLine($"Hausnummer: {Hausnummer}");
            Console.WriteLine($"Ort: {Ort}");
            Console.WriteLine($"Postleizahl: {Plz}");
        }
    }
}
