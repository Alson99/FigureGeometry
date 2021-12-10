using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Rectangle: Figure
    {
        private readonly string name = "Rectangle";

        private int x1, y1;
        private int x2, y2;
        private int x3, y3;
        private int x4, y4;


        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.x1 = x1;
            this.y1 = y1;

            this.x2 = x2;
            this.y2 = y2;

            this.x3 = x3;
            this.y3 = y3;

            this.x4 = x4;
            this.y4 = y4;
        }


        public int lengthSegment(int x1, int y1, int x2, int y2)
        {
            return ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        public override double Area()
        {
            int segment1 = lengthSegment(this.x2, this.x1, this.y1, this.y2);
            int segment2 = lengthSegment(this.x3, this.x2, this.y3, this.y2);
            return (segment2 * segment1);
        }

        public override double Perimeter()
        {
            int segment1 = lengthSegment(this.x2, this.x1, this.y1, this.y2);
            int segment2 = lengthSegment(this.x3, this.x2, this.y3, this.y2);
            return ((segment2 + segment1) * 2);
        }

        public override void ShowStyle()
        {
            Console.WriteLine("Name figure:{0}", this.name);

            Console.WriteLine("Point coordinates:");
            Console.WriteLine("Point 1: ({0};{1})", this.x1, this.y1);
            Console.WriteLine("Point 2: ({0};{1})", this.x2, this.y2);
            Console.WriteLine("Point 3: ({0};{1})", this.x3, this.y3);
            Console.WriteLine("Point 4: ({0};{1})", this.x4, this.y4);

            Console.WriteLine("Length of a segment: length {0}, width: {1}, area: {2}, perimetr: {3}",
                this.lengthSegment(this.x2, this.x1, this.y1, this.y2),
                this.lengthSegment(this.x3, this.x2, this.y3, this.y2),
                this.Area(), this.Perimeter());
        }

    }
}
