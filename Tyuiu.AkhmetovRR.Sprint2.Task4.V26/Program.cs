using Tyuiu.AkhmetovRR.Sprint2.Task4.V26.Lib;

namespace Tyuiu.AkhmetovRR.Sprint2.Task4.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            DataService ds = new DataService();
            Console.WriteLine("Введите значение переменной x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной y:");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);
            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
