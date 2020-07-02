using System;

namespace Aplikacja_Pogodowa
{
    class Program
    {
        #region menu
        static void MenuItems()
        {
            Spacer();
            Console.WriteLine("Wybierz pozycję z menu [1-3]: ");
            Console.WriteLine(" ");
            Console.WriteLine("1: Sprawdź pogodę (https://danepubliczne.imgw.pl/)");
            Console.WriteLine("2: Lista dostępnych miast");
            Console.WriteLine("3: O autorze");
            Console.WriteLine("4: Zakończ Aplikacje");
            Spacer();
        }
        static void Spacer()
        {
            Console.WriteLine(" ");
            Console.WriteLine("---------------------");
            Console.WriteLine(" ");
        }

        static void CreatedBy()
        {
            Spacer();
            Console.WriteLine("Bartosz Kapusta");
            Console.WriteLine("Grupa lab8/1/IEN");
            Console.WriteLine("Index 12494");
            Spacer();
        }
        static void Anykey()
        {
            Console.Write("Naciśni dowolny klawisz.");
            Console.ReadKey();
            Spacer();
        }
        #endregion
        static void Main(string[] args)
        {
            #region user input
            int userInput;
            string userChoice;
            string city_name;
            #endregion

            do
            {
                MenuItems();

                Console.Write("Wybierz pozycję z menu: ");
                userChoice = Console.ReadLine();

                // check if is number
                if (!Int32.TryParse(userChoice, out userInput)) continue;

                if (userChoice == "4")
                {
                    Environment.Exit(0);
                }

                if (userChoice == "3")
                {
                    CreatedBy();
                }

                if (userChoice == "2")
                {
                    Console.WriteLine("To be added");
                }

                if (userChoice == "1")
                {
                    Console.Write("Enter city name: ");
                    city_name = Console.ReadLine();

                    Console.WriteLine("To be added");

                    Spacer();


                }
                Anykey();
            }
            while (true);
        }
    }
}
