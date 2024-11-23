using Tyuiu.AkhmetovRR.Sprint2.Task3.V16.Lib;

namespace Tyuiu.AkhmetovRR.Sprint2.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите значение переменной x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);
            Console.WriteLine("Значение функции равно: " + res);
            Console.ReadKey();
        }
    }
}
