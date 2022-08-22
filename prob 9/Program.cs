using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0.0;

            int max = 10;

            List<double> lst = new List<double>();

            for (int i = 0; i < max; i++)

            {
                lst.Add(Math.Round(result, 2));

                Console.WriteLine(result);

            }

            Console.WriteLine();

            foreach (double j in lst)

            {

                Console.WriteLine(j);
                Console.ReadLine();
            }
        }
    }
}
