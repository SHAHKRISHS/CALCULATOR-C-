using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplicaion");
            Console.WriteLine("4. Division");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                Console.Write("C =");
                Console.WriteLine(a + b);
                Console.ReadLine();
                Console.WriteLine("Do You Want to Continue: ");
                string y = Console.ReadLine();
            }
            else if(x == 2)
            {
                    Console.Write("C =");
                    Console.WriteLine(a - b);
                    Console.ReadLine();
            }
            else if(x == 3)
            {
                Console.Write("C =");
                Console.WriteLine(a * b);
                Console.ReadLine();
            }
            else if(x == 4)
            {
                Console.Write("C =");
                while (b == 0)
                {
                    Console.WriteLine("Enter the value of b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(a / b);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please Enter Valid Number");
            }
        }
    }
}
