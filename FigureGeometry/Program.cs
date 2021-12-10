using System;

namespace Figure
{
    class Pragram
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());

            Rectangle R1 = new Rectangle(x1, y1, x2, y2, x3, y3, x4, y4);
            R1.ShowStyle();

            Triangle R2 = new Triangle(x1, y1, x2, y2, x3, y3);
            R2.ShowStyle();

            Console.ReadKey();
        }
    }
}
