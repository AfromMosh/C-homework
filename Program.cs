using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //variable_1_m
            Console.WriteLine("instert a number and press Enter");
            string lineA1 = Console.ReadLine();
            double numA1 = double.Parse(line1);
            Console.WriteLine("insert another number and press Enter");
            string lineA2 = Console.ReadLine();
            double numA2 = double.Parse(lineA2);
            Console.WriteLine("the numbers are {0} and {1}", numA1, numA2);
            Console.ReadLine();

            //variable_2_m
            Console.WriteLine("instert an integer number and press Enter");
            string lineB1 = Console.ReadLine();
            int numB1 = int.Parse(lineB1);
            Console.WriteLine("insert another integer number and press Enter");
            string lineB2 = Console.ReadLine();
            int numB2 = int.Parse(lineB2);
            Console.WriteLine("the integer numbers are {0} and {1}", numB1, numB2);
            Console.ReadLine();

            //variable_3_m
            Console.WriteLine("instert a number and press Enter");
            string lineC1 = Console.ReadLine();
            double numC1 = double.Parse(lineC1);
            Console.WriteLine("insert an integer number and press Enter");
            string lineC2 = Console.ReadLine();
            int numC2 = int.Parse(lineC2);
            Console.WriteLine("the 1st numbers is {0} and the integer number is {1}", numC1, numC2);
            Console.ReadLine();
            
            //variable_4_m
            char a1 = 'a';
            char a2 = '1';
            Console.WriteLine("{0} {1}", a1, a2);
            Console.ReadLine();
            
            //variable_5_m
            bool a = true;
            Console.WriteLine(a);
            Console.ReadLine();
            
            
            //operator_math_1_m

            Console.WriteLine("insert a number and press Enter");
            string lineA = Console.ReadLine();
            int A = int.Parse(lineA);
            Console.WriteLine("insert a number and press Enter");
            string lineC = Console.ReadLine();
            int C = int.Parse(lineC);
            int sum = (A + C);
            double avg = sum / 2;

            Console.WriteLine("the sum of {0} and {1} is {2}, and the avrege of {0} and {1} is {3}", A, C, sum, avg);
            Console.ReadLine();
            */
            
            //operator_math_2_m
            Console.WriteLine("insert a number and press Enter");
            string lineM1 = Console.ReadLine();
            int numM1 = int.Parse(lineM1);
            Console.WriteLine("insert another number");
            string lineM2 = Console.ReadLine();
            int numM2 = int.Parse(lineM2);
            Console.WriteLine("your numbers are {0} and {1}",numM1,numM2);
            int numM3 = numM1;
            numM1 = numM2;
            numM2 = numM3;
            Console.WriteLine("now numM1 is {0} and numM2 is {1}", numM1, numM2);
            Console.ReadLine();

        }


    }
}