using System;

namespace pirmauzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Pasirinkite:");
            Console.WriteLine("1) Užšifruoti");
            Console.WriteLine("2) Dešifruoti");
            Console.WriteLine("3) Išeiti");
            Console.Write("\nPasirinkite: ");

            switch (Console.ReadLine())
            {
                case "1":
                    EncryptString();
                    return true;
                case "2":
                    DecryptString();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }


        private static void EncryptString()
        {
            Console.Clear();
            Console.WriteLine("Įveskite žodi:");
            string zodis = Console.ReadLine();
            Console.WriteLine("Įveskite poslinki:");
            string poslinkis = Console.ReadLine();
            int poslinkisInt = Int32.Parse(poslinkis);

            Console.WriteLine("\nGaunamos žodžio simbolių vertės pagal ASCII: ");

            foreach (char c in zodis)
            {
                Console.WriteLine(c + " = " + (int)c);
            }
            Console.WriteLine();
            Console.Write("\nCezario šifras: ");
            foreach (char c in zodis)
            {
                int cPlusPoslinkis = c + poslinkisInt; 
                char myChar = Convert.ToChar(cPlusPoslinkis);
                Console.Write(myChar);
                //Console.WriteLine(myChar + " = " + cPlus3);
            }
            Console.WriteLine();
            DisplayResult(zodis);
        }

        private static void DecryptString()
        {
            Console.Clear();
            Console.WriteLine("Iveskite užšifruotą žodį:");
            string zodis = Console.ReadLine();
            Console.WriteLine("Iveskite poslinki:");
            string poslinkis = Console.ReadLine();
            int poslinkisInt = Int32.Parse(poslinkis);
            Console.WriteLine("\nGaunamos užšifruoto žodžio simbolių vertės pagal ASCII: ");

            foreach (char c in zodis)
            {
                Console.WriteLine(c + " = " + (int)c);
            }

            Console.Write("\nCezario šifras: ");
            foreach (char c in zodis)
            {
                int cMinusPoslinkis = c - poslinkisInt; // poslinkis
                char myChar = Convert.ToChar(cMinusPoslinkis);
                Console.Write(myChar);
            }
            Console.WriteLine();
            DisplayResult(zodis);
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\nPradinis žodis buvo: {message}");
            Console.Write("\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}