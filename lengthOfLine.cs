using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class LengthOfLine
    {
        static void Main()
        {

            Console.Write("Enter the x-coordinate of the first point: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y-coordinate of the first point: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the x-coordinate of the second point: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y-coordinate of the second point: ");
            double y2 = Convert.ToDouble(Console.ReadLine());


            double length = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            Console.WriteLine("The length of line is: " + length);
        }


    }

}
