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
            
            
            //operator_math_2_m
            Console.WriteLine("insert a number and press Enter");
            string lineM1 = Console.ReadLine();
            int numM1 = int.Parse(lineM1);
            Console.WriteLine("insert another number and press Enter");
            string lineM2 = Console.ReadLine();
            int numM2 = int.Parse(lineM2);
            Console.WriteLine("your numbers are {0} and {1}",numM1,numM2);
            int numM3 = numM1;
            numM1 = numM2;
            numM2 = numM3;
            Console.WriteLine("now numM1 is {0} and numM2 is {1}", numM1, numM2);
            Console.ReadLine();
            

            //operator_math_3_m
            Console.WriteLine("insert a number and press Enter");
            string lineMa1 = Console.ReadLine();
            double numMa1 = double.Parse(lineMa1);
            Console.WriteLine("insert another number and press Enter");
            string lineMa2 = Console.ReadLine();
            double numMa2 = double.Parse(lineMa2);
            Console.WriteLine("your numbers are {0} and {1}", numMa1, numMa2);
            double numMa3 = numMa1;
            numMa1 = numMa2;
            numMa2 = numMa3;
            Console.WriteLine("now numMa1 is {0} and numMa2 is {1}", numMa1, numMa2);
            Console.ReadLine();
            

            //operator_math_4_m
            Console.WriteLine("insert a number and press Enter");
            string lineMb1 = Console.ReadLine();
            double numMb1 = double.Parse(lineMb1);
            Console.WriteLine("insert another number and press Enter");
            string lineMb2 = Console.ReadLine();
            double numMb2 = double.Parse(lineMb2);
            Console.WriteLine("insert another number and press Enter");
            string lineMb3 = Console.ReadLine();
            double numMb3 = double.Parse(lineMb3);

            double mul = numMb1 * numMb2 * numMb3;
            Console.WriteLine(mul);
            Console.ReadLine();
            

            //operator_math_5_m
            Console.WriteLine("insert a number and press Enter");
            string lineMc1 = Console.ReadLine();
            double first = double.Parse(lineMc1);
            Console.WriteLine("insert another number and press Enter");
            string lineMc2 = Console.ReadLine();
            double second = double.Parse(lineMc2);

            double result = first % second;
            Console.WriteLine(result);
            Console.ReadLine();
            

            //operator_math_6_m
            Console.WriteLine("insert a number and press Enter");
            string lineMd1 = Console.ReadLine();
            int numMd1 = int.Parse(lineMd1);
            numMd1 = ++numMd1;
            Console.WriteLine(numMd1);
            Console.ReadLine();
            

            //operator_math_7_m
            Console.WriteLine("insert a number and press Enter");
            string lineMe1 = Console.ReadLine();
            int numMe1 = int.Parse(lineMe1);
            numMe1 *= 3;
            Console.WriteLine(numMe1);
            Console.ReadLine();
            

            //operator_math_8_m
            Console.WriteLine("please insert the radius of the circle");
            string input = Console.ReadLine();
            double radius = double.Parse(input);
            double perimeter = (2 * 3.14159 * radius);
            double paiR = (3.14159 * radius);
            double area = (paiR * paiR);
            Console.WriteLine("the perimeter of the circle is {0} and the area is {1}", perimeter, area);
            Console.ReadLine();
            */

            //operator_relative_casting_precedence_1_m


            Console.WriteLine("insert a number and press Enter");
            string lineRC1 = Console.ReadLine();
            int numRC1;
            bool resuletRC1 = int.TryParse(lineRC1, out numRC1);
            if (resulet == false)
            {
                Console.WriteLine("please insert a number only in digits and press Enter");
                lineRC1 = Console.ReadLine();
            }

            Console.WriteLine("insert a number and press Enter");
            string lineRC2 = Console.ReadLine();
            int numRC2;
            bool resuletRC2 = int.TryParse(lineRC2, out numRC2);
            if (resulet == false)
            {
                Console.WriteLine("please insert a number only in digits and press Enter");
                lineRC2 = Console.ReadLine();
            }
            int sum = numRC1 + numRC2;
            int avrg = (numRC1 + numRC2) / 2;

            Console.WriteLine("the avrge of your number is {0} and the sum is {1}", avrg, sum);
            


        }
    }
}