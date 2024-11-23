using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint2.Task2.V24.Lib;

namespace Tyuiu.AkhmetovRR.Sprint2.Task2.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            DataService dataService = new DataService();
            bool result = dataService.Calculate(x, y);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
