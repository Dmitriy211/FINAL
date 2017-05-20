using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (args.Length == 0)
            //{
            //    string s = Console.ReadLine();
            //}

            for (int i = 0; i < args.Length; i++)
            {
                int n = int.Parse(args[i]);
                if (n % 3 == 0 && n % 5 != 0)
                    Console.Write(n + " ");
            }


        }
    }
}
