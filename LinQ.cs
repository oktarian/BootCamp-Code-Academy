using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class linQ
    {
        public static void IntroLinQ()
        {
            int[] number = new int[] {12, 342, 33, 54, 23, 75, 11};
            var sum = number.Sum(Y => Y++);
            var min = number.Min(M => M++);
            var max = number.Max(M => M++);
            var dupl = number.Distinct();






            Console.WriteLine($"MAX : {max}");
            Console.WriteLine($"MIN : {min}");
            Console.WriteLine($"SUM : {sum}");

            foreach (var item in dupl)
            {
                Console.WriteLine(dupl);

            }

        }
    }
}
