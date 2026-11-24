using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leasone2
{
    internal class HMath : Leasone.MMath
    {
        public void test()
        {
            double sum = base.Sum(new[] { 1, 2, 3, 4, 5, });
            Console.WriteLine("СУММА: " + sum);

            double max = base.Max(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, });
            Console.WriteLine("Максимум: " + max);

            double min = base.Min(new[] { 1, 2, 3, 4, });
            Console.WriteLine("Минимум" + min);

            string checkevenorodd = base.Checkevenorodd(25);
            Console.WriteLine("Четное, нечетное?: " + checkevenorodd);

            double getAverage = base.GetAverage(new[] { 1, 2, });
            Console.WriteLine("Среднее: " + getAverage);
        }
    }
}
