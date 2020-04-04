using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LAKES = 10;
            int i;
            double maximum;
            double[] depths = new double[LAKES];
            string[] name = new string[LAKES];

            for (i = 0; i <= LAKES - 1; i++)
            {
                Console.WriteLine("Enter the name of Lake No " + (i + 1));
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter depth for Lake " + name[i]);
                depths[i] = Double.Parse(Console.ReadLine());
            }

            maximum = depths[0];
            string m_name = name[0];
            for (i = 1; i <= LAKES - 1; i++)
            {
                if (depths[i] > maximum)
                {
                    maximum = depths[i];
                    m_name = name[i];
                }
            }
            Console.WriteLine("The deepest lake is " + m_name);
            Console.ReadKey();
        }     
    }
}
