using System;

namespace ConsoleApp3_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {            
            Console.Write("Введите значение k ");            
            string strk = Console.ReadLine();

            Console.Write("Введите значение b ");
            string strb = Console.ReadLine();

            double b = 0, k = 0;            

            try
            {
                k = Convert.ToInt32(strk);
                b = Convert.ToInt32(strb);
            }
            catch
            {
                Console.WriteLine("Некорректные данные");
                Console.ReadLine();
                Run();
                Environment.Exit(0);
            }

            Test Test = new Test { k = k, b = b };
            Test.Root();
            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }

        struct Test
        {
            public double k, b;            

            public void Root()
            {
                Console.Write("X = " + -b / k);
            }
        }
    }       
}