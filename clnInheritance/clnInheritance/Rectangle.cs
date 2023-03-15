using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clnInheritance
{
    internal class Rectangle:Shape
    {
        private double length;
        private double width;

        public Rectangle() { }

        public Rectangle(string name, double length, double width)
        {
            base.Name = name;         
            this.Length = length;
            this.Width = width;
        }

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }

        public override string ToString()
        {
            return   "\nName: " + base.Name +
                "\nLength: " + this.length +
                "\nWidth: " + this.width +
                "\nArea: " + this.ComputeArea() +
               "\nPerimeter: " + this.ComputePerimeter();
        }
        public override double ComputeArea()
        {
            return this.length * this.Width;
        }
        public override double ComputePerimeter()
        {
            return this.length * 2 + this.width * 2;
        }
    }
}
