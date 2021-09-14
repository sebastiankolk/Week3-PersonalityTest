using System;

namespace PersonalityTestSwtich
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programm küsib kasutajat sisestada tema lemmikvärvi
              * Kui kasutaja sisestab punane, konsool kuvab "oled romantiline"
              * Kui kasutaja sisestab "sinine", konsool kuvab "oled töökas"
              * Kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber"
              * Kui kasustaja sisestab midagi muud, konsool kuvab "oled ükssarvik"
              */
            Console.WriteLine("Sisesta oma lemmikvärv.");

            string varv = Console.ReadLine();

            switch (varv)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"Oled {varv} ükssarvik");
                    break;

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
