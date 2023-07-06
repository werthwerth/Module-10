using System;
using System.Collections.Generic;
using System.Text;

namespace Module_10_5_2
{
    class Module_10_5_2
    {
        private static ILogger Logger { get; set; }

        static void Main(string[] args)
        {
            Logger = new Logger();
            try
            {
                double Answer = 0;
                ICalc calc = new Calc(Logger);
                Console.WriteLine("Enrter number one: ");
                double Num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enrter number two: ");
                double Num1 = Convert.ToDouble(Console.ReadLine());
                Answer = calc.Sum(Num, Num1);
                calc.Calculate(Answer);
            }
            catch
            {
                Logger.Error("Wrong numbers!");
            }
        }
    }

    public interface ICalc
    {
        double Sum(double Num, double Num1);
        void Calculate(double Answer);
    }



    public class Calc : ICalc
    {
        private ILogger Logger { get; }
        public Calc(ILogger logger)
        {
            Logger = logger;
        }
        double ICalc.Sum(double Num, double Num1)
        {
            Logger.Event("Calculating...");
            return Num + Num1;
        }
        void ICalc.Calculate(double Answer)
        {
            Console.WriteLine($"Result is: {Answer}");
            Console.ReadLine();
        }
    }
    public interface ILogger
    {
        void Event(string Message);

        void Error(string Message);
    }

    public class Logger : ILogger
    {
        public void Event(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(Message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Error(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}