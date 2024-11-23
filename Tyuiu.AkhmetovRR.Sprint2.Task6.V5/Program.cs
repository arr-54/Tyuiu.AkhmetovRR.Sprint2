using Tyuiu.AkhmetovRR.Sprint2.Task6.V5.Lib__;

namespace Tyuiu.AkhmetovRR.Sprint2.Task6.V5
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
            Console.WriteLine("Введите номер карты: ");
            int NumMonth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((NumMonth < 6) || (NumMonth > 14))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Достоинство соответствующей карты:" + ds.FindMonthName(NumMonth);
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
