using System;

namespace EnumExemplo
{
    enum Diasdasemana
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    //Muito semelhante a estruturas/structs em c
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.Monday;

            if (today == DaysOfWeek.Saturday || today == DaysOfWeek.Sunday)
            {
                Console.WriteLine("It's the weekend!");
            }
            else
            {
                Console.WriteLine("It's a weekday.");
            }

            Console.ReadKey();
        }
    }
}
