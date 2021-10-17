using System;

namespace Backend_Task_1_Ludo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool closeFlag = false;

            while (!closeFlag)
            {
                Console.WriteLine("Kies een van de onderstande opties. Type een getal om een keus te makken.");
                Console.WriteLine("1 - Circle oppervlakte");
                Console.WriteLine("2 - Fibonacci rij");
                Console.WriteLine("3 - Uitgang");

                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    circleRadius();
                }
                else if (choose == "2")
                {
                    fibonacci();
                }
                else if (choose == "3")
                {
                    closeFlag = true;
                }
                else
                {
                    Console.WriteLine("Ongeldige invoer. Type een getal tussen 1 en 3.");
                }

            }

            static void circleRadius()
            {
                int radius;
                const double PI = 3.1415926535897931;

                Console.Write("Type een circle radius om de oppervlakte te berekenen: ");
                try
                {
                    radius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("De oppervlakte is " + (radius * PI));
                }
                catch
                {
                    Console.WriteLine("Ongeldige invoer. De circle radius moet een getal zijn.");
                }
            }

            static void fibonacci()
            {

            }
        }
    }
}
