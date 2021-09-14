using System;

namespace PersonalityTest
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

            if (varv == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if (varv == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if (varv == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }
            else
            {
                Console.WriteLine($"Oled {varv} ükssarvik.");
            }
        
            
        }
    }
}
