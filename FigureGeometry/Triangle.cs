using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Triangle: Figure
    {
        private readonly string name = "Trangle";

        private int x1, y1;
        private int x2, y2;
        private int x3, y3;

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.y1 = y1;

            this.x2 = x2;
            this.y2 = y2;

            this.x3 = x3;
            this.y3 = y3;
        }

        public int lengthSegment(int x1, int y1, int x2, int y2)
        {
            return ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        public override double Area()
        {
            int segment1 = lengthSegment(this.x2, this.x1, this.y1, this.y2);
            int segment2 = lengthSegment(this.x3, this.x2, this.y3, this.y2);
            int segment3 = lengthSegment(this.x1, this.x3, this.y1, this.y3);

            double pPerimetr = segment3 + segment1 + segment2;

            return pPerimetr * Math.Sqrt((pPerimetr - segment1) * (pPerimetr - segment2) * (pPerimetr - segment3));
        }

        public override double Perimeter()
        {
            int segment1 = lengthSegment(this.x2, this.x1, this.y1, this.y2);
            int segment2 = lengthSegment(this.x3, this.x2, this.y3, this.y2);
            int segment3 = lengthSegment(this.x1, this.x3, this.y1, this.y3);

            return segment2 + segment1 + segment3;
        }

        public override void ShowStyle()
        {
            Console.WriteLine("Name figure:{0}", this.name);

            Console.WriteLine("Point coordinates:");
            Console.WriteLine("Point 1: ({0};{1})", this.x1, this.y1);
            Console.WriteLine("Point 2: ({0};{1})", this.x2, this.y2);
            Console.WriteLine("Point 3: ({0};{1})", this.x3, this.y3);

            Console.WriteLine("Length of a segment: {0}, {1}, {2}, area: {3}, perimetr: {4}",
                this.lengthSegment(this.x2, this.x1, this.y1, this.y2),
                this.lengthSegment(this.x3, this.x2, this.y3, this.y2),
                this.lengthSegment(this.x1, this.x3, this.y1, this.y3),
                this.Area(), this.Perimeter());
        }
    }
}
