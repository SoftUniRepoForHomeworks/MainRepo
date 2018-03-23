using System;


namespace modul2
{
    class Program
    {
        static void Main(string[] args)
        {
            double one = double.Parse(Console.ReadLine());
            double two = double.Parse(Console.ReadLine());

            Console.WriteLine($"{one * two:f2}");
        }
    }
}
