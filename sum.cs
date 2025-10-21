using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class sum
    {
        public static void Main(string[] args)
        {
            int sum = 0;

            foreach(int arg in args)
            {
                sum += arg;
            }
        }
    }
}
