using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_Fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int i;
            int n3;


            for (i = 1; i < 10; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(" "+n3);
                n1 = n2;
                n2 = n3;


            }
            Console.ReadLine();

        }
    }
}
