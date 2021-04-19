using System;
using System.Diagnostics;

namespace TestSpeed
{
    class Program
    {
        // udelat variantu se Switch, pridat mereni casu
        static void TestIf( int n)
        {
            if (n == 1)
            {
                Console.WriteLine(n);
            }
            else if (n == 2)
            {
                Console.WriteLine(n);
            }
            else if (n == 3)
            {
                Console.WriteLine(n);
            }
            else if (n == 4)
            {
                Console.WriteLine(n);
            }
            else if (n == 5)
            {
                Console.WriteLine(n);
            }
            else if (n == 6)
            {
                Console.WriteLine(n);
            }
            else if (n == 7)
            {
                Console.WriteLine(n);
            }
            else if (n == 8)
            {
                Console.WriteLine(n);
            }
            else if (n == 9)
            {
                Console.WriteLine(n);
            }
            else if (n == 10)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(n);
            }
        }

        static void TestSwitch(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine(n);
                    break;
                case 2:
                    Console.WriteLine(n);
                    break;
                case 3:
                    Console.WriteLine(n);
                    break;
                case 4:
                    Console.WriteLine(n);
                    break;
                case 5:
                    Console.WriteLine(n);
                    break;
                case 6:
                    Console.WriteLine(n);
                    break;
                case 7:
                    Console.WriteLine(n);
                    break;
                case 8:
                    Console.WriteLine(n);
                    break;
                case 9:
                    Console.WriteLine(n);
                    break;
                case 10:
                    Console.WriteLine(n);
                    break;
                default:
                    Console.WriteLine(n);
                    break;
            }
        }
        static void Main(string[] args)
        {
            int n = 10;
            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int i = 0; i < 10; i++)
            {
                TestIf(n);
            }
            
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            Console.WriteLine("RunTime IF: " + ts);

            Stopwatch stopWatch2 = Stopwatch.StartNew();
            for (int i = 0; i < 10; i++)
            {
                TestSwitch(n);
            }
            
            stopWatch2.Stop();
            TimeSpan ts2 = stopWatch.Elapsed;

            Console.WriteLine("Jsem tady! in: " + ts2);
            
        }
    }
}
