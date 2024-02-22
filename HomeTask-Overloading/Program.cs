using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace HomeTask_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            // Console.WriteLine(Sum(23, 49, 120));
            //Task2
            // SeasonMonth(5);
            //Task3
            //Console.WriteLine(Results(231));
            //Task4
            //Console.WriteLine(Price(40, 20, 50));


        }


        static int Sum(params int[] array)
        {

            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 10 && array[i] <= 100)
                {
                    result += array[i];
                }
            }
            return result;
        }




        static void SeasonMonth(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("qis");
                    break;
                case 2:
                    Console.WriteLine("qis");
                    break;
                case 3:
                    Console.WriteLine("yaz");
                    break;
                case 4:
                    Console.WriteLine("yaz");
                    break;
                case 5:
                    Console.WriteLine("yaz");
                    break;
                    Console.WriteLine("yaz");
                case 6:
                    Console.WriteLine("yay");
                    break;
                case 7:
                    Console.WriteLine("yay");
                    break;
                case 8:
                    Console.WriteLine("payiz");
                    break;
                case 9:
                    Console.WriteLine("payiz");
                    break;
                case 10:
                    Console.WriteLine("payiz");
                    break;
                case 11:
                    Console.WriteLine("qis");
                    break;
                case 12:
                    Console.WriteLine("qis");
                    break;
                default:
                    Console.WriteLine("duzgun eded daxil edlymb");
                    break;

            }

        }
        static int Results(int n)
        {
            int result = 1;
            while (n > 1)
            {
                int digit = n % 10;

                result *= digit;
                digit = n /= 10;
            }
            return result;
        }
        static int Price(int a, int b, int c)
        {
            int result = 0;
            if (a > b && b > c || b > c && a > c)
            {
                result = a + b;
            }
            else if (a < b && b < c)
            {
                result = a + b;
            }
            else
            {
                result = a + c;
            }
            return result;
        }

    }


}