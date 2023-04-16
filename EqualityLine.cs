namespace LineCommand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Line Co-ordinate: ");
            Console.Write("Enter the x-coordinate of the first point: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y-coordinate of the first point: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the x-coordinate of the second point: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y-coordinate of the second point: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Second Line Co-ordinate");

            Console.Write("Enter the x-coordinate of the first point: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y-coordinate of the first point: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the x-coordinate of the second point: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y-coordinate of the second point: ");
            double b2 = Convert.ToDouble(Console.ReadLine());




            double length1 = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            double length2 = Math.Sqrt((Math.Pow((a2 - a1), 2)) + (Math.Pow((b2 - b1), 2)));
            Console.WriteLine(length1 == length2);

            double length = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            Console.WriteLine("The length of line is: " + length);
        }
    }
}