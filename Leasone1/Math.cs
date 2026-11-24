using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leason1
{
    internal class Math
    {
        public double Sum(int[] numbers)
        {
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public double Max(int[] numbers)
        {
            double max = 0;
            foreach(int number in numbers)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }
        public double Min(int[] numbers)
        {
            double min = numbers[0];
            foreach(int number in numbers)
            {
                if (number< min)
                    min = number;
            }
            return min;
        }
        public  double factorial(int number)
        {
            double result = 1;
            for (int i = number; i >= 1; i--)
                result *= i;
            return result;
        }

        public string CheckEven0r0dd(int numbers)
        {
            if (numbers % 2 == 0)
            {
                return "Четное";
            }
            else
            {
                return "Нечетное";
            }
        }

        public double GetAverage(int[] numbers)
        {
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }

        public bool IsPalindrome(string text)
        {
            string lower = text.ToLower();
            string reversed = "";

            for (int i = lower.Length - 1; i >= 0; i--)
            {
                reversed += lower[i];
            }
            return lower == reversed;
        }

        internal int count(int[] numbers) { return numbers.Length; }
        internal protected int Add(int num1, int num2) { return num1 + num2; }
        int Sub(int num1, int num2) { return num1 - num2; }
        int Multpl(int num1, int num2) { return num1 * num2; }
        int Div(int num1, int num2) { return num1 / num2; }
        int power(int Base, int Exnumber) { return Base ^ Exnumber; }
        int Modles(int Base, int Exnumber) { return Base % Exnumber; }
    }
}
