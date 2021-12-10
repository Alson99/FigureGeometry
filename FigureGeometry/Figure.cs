using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public abstract class Figure
    {
        double pri_width;
        double pri_height;
        double pri_length;
        public double Width
        {
            get { return pri_width; }
            set { pri_width = value < 0 ? -value : value; }
        }
        public double Height
        {
            get { return pri_height; }
            set { pri_height = value < 0 ? -value : value; }
        }

        public double Length
        {
            get { return pri_length; }
            set { pri_length = value < 0 ? -value : value; }
        }
        public string name { get; set; }

        public Figure() //Конструктор по умолчанию
        {
            Width = Height = Length = 0.0;
            name = "null";
        }

        public Figure(double x, string n) //Конструктор для круга, квадрата и равностороннего треугольника
        {
            Width = Height = Length = x;
            name = n;
        }

        public Figure(double x, double y, string n) // Равнобедренный треугольник и прямоугольник
        {
            Width = x;
            Height = y;
            Length = Width;
            name = n;
        }

        public Figure(double x, double y, double z, string n) // треугольник
        {
            Width = x;
            Height = y;
            Length = z;
            name = n;
        }


        public abstract double Area();
        public abstract double Perimeter();
        public abstract void ShowStyle();

    }
}
