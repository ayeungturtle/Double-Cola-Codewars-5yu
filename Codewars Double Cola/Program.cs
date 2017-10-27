using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Double_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            //tests
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            long n = 8;
            Console.WriteLine(WhoIsNext(names, n));
            Console.ReadLine();
        }

        public static string WhoIsNext(string[] names, long n)
        {
            string[] longOrder = new string[n];
            for (int i = 0; i < names.Length; i++)
            {
                if (i < n)
                {
                    longOrder[i] = names[i];
                }
            }
                       
            int cloneDistance = 5;

            for (int i = 0; (i + cloneDistance) < n; i++)
            {
                longOrder[i+cloneDistance] = longOrder[i];
                if (i + cloneDistance + 1 < n)
                {
                    longOrder[i + cloneDistance + 1] = longOrder[i];
                }
                cloneDistance += 1;
            }
            return longOrder[n-1];
        }
    }
}
