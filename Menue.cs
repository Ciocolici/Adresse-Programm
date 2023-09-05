using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Adresse_Programm
{
    internal class Menue
    {
        static Kunde[] kArray = new Kunde[3];
        static Adresse[] aArray = new Adresse[3];
        public static void Start()
        {
            // The Method that declares the fields/variables inside the array
            MakeTheLists();
            // The method used to welcome the user
            Hello();

            // Loop for the program
            bool repeat;

            do
            {
                int auswahlKunde;
                repeat = false;

                // The variable "auswahlKunde" becomes the value given by the method "KundeAuswahl()",
                // which is a method used to ask the user to choose a client/kunde
                // (-1, to be used as Index, because Indexes start at 0)
                auswahlKunde = KundeAuswahl();
                // Then the method "Ausgabe" is used with the value given by "auswahlKunde" as its index
                // The method will start another 3 methods, which display the fields representing the index given by auswahlKunde
                Ausgabe(auswahlKunde);
                // The method "Repeat()" asks the user if he wants to restart the program, resulting in a bool true/false, which will then be the value of variable "repeat" 
                // as bool True/False to check if the program should restart or not
                repeat = Repeat();
            } while (repeat == true);
        }

        public static void MakeTheLists()
        {
            kArray[0] = new Kunde("Drew", "Gestern", "Da", "Keine Ahnung");
            kArray[1] = new Kunde("Adi", "Heute", "Hier", "Vielleicht");
            kArray[2] = new Kunde("George", "Morgen", "Hauptbahnhof", "Doch nicht");

            aArray[0] = new Adresse("Gestern", "10", "Chicago", "DE90453");
            aArray[1] = new Adresse("Heute", "20", "Alte York", "0004340");
            aArray[2] = new Adresse("Morgen", "30", "Bucharest", "666SATAN");
        }

        public static void Hello()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\r\n /\\ |~\\|~)(~(~(~(~  |~)|~)/~\\/~_|~) /\\ |\\/||\\/|\r\n/~~\\|_/|~\\(__)_)(_  |~ |~\\\\_/\\_/|~\\/~~\\|  ||  |\r\n                                               \r\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\nWelcome to BlaBlaBla Company\n");
        }
        public static int KundeAuswahl()
        {
            int input;
            bool check;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Über welche Kunde willst was hören? Schreib ein Nr.");
                Console.WriteLine("\n\n(1)Drew\n(2)Adi\n(3)George\n\n");
                check = int.TryParse(Console.ReadLine(), out input);

                if (!check || input < 1 || input > 3)
                {
                    check = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"\n1 zu 3 bitte.");
                }

            } while (!check);

            return input - 1;
        }

        public static void Ausgabe(int Choice)
        {
            Console.Clear();
            kArray[Choice].Output();
            aArray[Choice].Output();
        }

        public static bool Repeat()
        {
            bool check;
            bool repeatMethod = false;
            do
            {
                int repeatAnswer;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAndere Kunde? 1/2");
                Console.WriteLine("\n1.Ja\n2.Nein");
                check = int.TryParse(Console.ReadLine(), out repeatAnswer);
                if (check == false)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Nummer bitte................");
                }
                else if (repeatAnswer == 1)
                {
                    repeatMethod = true;
                    Console.Clear();
                }
                else if (repeatAnswer == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Schade!");
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("1 odeR 2, Iz It DaT H@@@@RD?!?!!");
                    check = false;
                }
            } while (check == false);

            return repeatMethod;
        }
    }
}
