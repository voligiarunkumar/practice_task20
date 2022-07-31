/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
namespace Practice_task20
{
    public class NaiveFibonacciSequenceGenerator : IEnumerable
    {
        private int sequenceSize;
        public NaiveFibonacciSequenceGenerator(int sequenceSize)
        {
            this.sequenceSize = sequenceSize;
        }
        public IEnumerator GetEnumerator()
        {
            int n1 = 0;
            int n2 = 1;
            int count = 0;
            while (count <= sequenceSize)
            {
                var n1Temp = n1;
                n1 = n2;
                n2 = n1Temp + n2;
                ++count;
                yield return n2 - n1;
            }
        }
    }
    public class Program
    {
        static void Main()
        {


            var generator = new NaiveFibonacciSequenceGenerator(10);
            foreach (var num in generator)
            {
                Console.WriteLine(num);
            }
        }
    }
}*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practice_task20
{
    public class Calc
    {
        public delegate double Delegate(double first, double second);
        public static double Add(double first, double second)
        {
            return first + second;
        }
        public static double Substract(double first, double second)
        {
            return first - second;
        }
        public static double Multiply(double first, double second)
        {
            return first * second;
        }
        public static double Divide(double first, double second)
        {
            return first / second;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc.Delegate add = Calc.Add;
            Calc.Delegate substract = Calc.Substract;
            Calc.Delegate multiply = Calc.Multiply;
            Calc.Delegate divide = Calc.Divide;

            double result;

            Console.WriteLine("Enter the  number1");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the  number2");
            double second = double.Parse(Console.ReadLine());

            Console.WriteLine("* Please choose which operation do you want *");
            Console.WriteLine();
            Console.WriteLine("   Click : 1 For -- Addition--   ");
            Console.WriteLine("  Click : 2 For -- Subtraction--  ");
            Console.WriteLine("  Click : 3  For -- Multiplication-");
            Console.WriteLine("  Click : 4  For -- Division--    ");

            Console.WriteLine();
            Console.Write("Choose option from above: ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    result = add(first, second);
                    Console.WriteLine("Sum of " + first + " and " + second + " is : " + result);
                    break;
                case 2:
                    result = substract(first, second);
                    Console.WriteLine("Subtraction of " + first + " and " + second + " is : " + result);
                    break;
                case 3:
                    result = multiply(first, second);
                    Console.WriteLine("Multiplication of " + first + " and " + second + " is :" + result);
                    break;
                case 4:
                    result = divide(first, second);
                    Console.WriteLine("Division of " + first + " and " + second + " is : " + result);
                    break;
                case 0:
                    Console.WriteLine("Option was Null..! ");
                    break;
                default:
                    Console.WriteLine("Option was Invalid ");
                    break;
            }
        }
    }
}*/



