using Tyuiu.AkhmetovRR.Sprint2.Task5.V2.Lib;
namespace Tyuiu.AkhmetovRR.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            DataService ds = new DataService();
            Console.WriteLine("Введите номер месяца: ");
            int NumMouth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((NumMouth < 1) || (NumMouth > 12))
            {
                res = "Введено неверное значение!";
            }
            else
                res = "Это время года:" + ds.FindMonthSeason(NumMouth);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
