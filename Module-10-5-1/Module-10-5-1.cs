using System;
namespace Module_10_5_1
{
    class Module_10_5_1
{
        static void Main(string[] args)
        {
            try
            {
                double Answer = 0;
                ICalc calc = new Calc();
                Console.WriteLine("Enrter number one: ");
                double Num = calc.ReadNum();
                Console.WriteLine("Enrter number two: ");
                double Num1 = calc.ReadNum();
                Answer = calc.Sum(Num, Num1);
                calc.Calculate(Answer);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong numbers!");
                Console.ReadLine();
            }
        }
    }

    public interface ICalc
    {
        double Sum(double Num, double Num1);
        double ReadNum();
        void Calculate(double Answer);
    }

    public class Calc : ICalc
    {
        double ICalc.Sum(double Num, double Num1)
        {
            return Num + Num1;
        }
        double ICalc.ReadNum()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        void ICalc.Calculate(double Answer)
        {
            Console.WriteLine($"Result is: {Answer}");
            Console.ReadLine();
        }
    }
}