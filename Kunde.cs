using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adresse_Programm
{
    internal class Kunde
    {
        private string name;
        private string geburtstag;
        private string adresse;
        private string kreditwuerdigkeit;

        public string Name { get => name; set => name = value; }
        public string Geburtstag { get => geburtstag; set => geburtstag = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Kreditwuerdigkeit { get => kreditwuerdigkeit; set => kreditwuerdigkeit = value; }

        public Kunde(string name, string geburtstag, string adresse, string kreditwuerdigkeit)
        {
            this.Name = name;
            this.Geburtstag = geburtstag;
            this.Adresse = adresse;
            this.Kreditwuerdigkeit = kreditwuerdigkeit;
        }

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nKunde:\n");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Geburtstag: {Geburtstag}");
            Console.WriteLine($"Adresse: {Adresse}");
            Console.WriteLine($"Kreditwürdigkeit: {Kreditwuerdigkeit}");
        }
    }
}
