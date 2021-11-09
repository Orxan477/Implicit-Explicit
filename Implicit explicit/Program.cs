using Implicit_explicit.Models;
using System;

namespace Implicit_explicit
{
    class Program
    {
        static void Main(string[] args)
        {
            TryAgain:
            Console.WriteLine("1.Celci or 2.Faranheyt");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("Celcius=");
                    int c= Convert.ToInt32(Console.ReadLine());
                    Celcius celci = new Celcius(c);
                    Faranheyt far = celci;
                    Console.WriteLine("----------------");
                    Console.WriteLine("Faranheyt="+far.FaranheytF);
                    break;
                case 2:
                    Console.Write("Faranheyt=");
                    int f = Convert.ToInt32(Console.ReadLine());
                    Faranheyt faranheyt = new Faranheyt(f);
                    Celcius celcius = faranheyt;
                    Console.WriteLine("----------------");
                    Console.WriteLine("Celcius="+celcius.CelciusC);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("InCorrect Input");                    
                    goto TryAgain;
            }
        }
    }
}
