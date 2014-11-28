using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortLOL1
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            int i, j, temp, min;
            const int n = 12;
            int[] x = new int[] { 10, 9, 19, 3, 1, 15, 20, 100, 200, 0, 8, -1 };

            for (j = 0; j < n; j++)
            {
                min = x[j];
                for (i = j; i < n; i++)
                {
                    if (x[i] < min)
                    {
                        min = x[i];
                        index = i;
                    }
                }
                temp = x[j];
                x[j] = min;
                x[index] = temp;
            }
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
        }
    }
}
