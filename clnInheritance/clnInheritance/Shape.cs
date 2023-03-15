using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clnInheritance
{
    internal class Shape
    {
        private string name;
        private int sides;

        public Shape() { 
        
        }
        public Shape(string name, int sides) { 
            this.Name = name;   
            this.Sides = sides; 
        }

        public string Name { get => name; set => name = value; }
        public int Sides { get => sides; set => sides = value; }

        public override string ToString()
        {
            return "\nName: " + this.name + "\nSides: " + this.sides+"\nArea: "+this.ComputeArea()+
                "\nPerimeter: "+this.ComputePerimeter();
        }

        public virtual double ComputeArea() {
            return 0.0;
        }

        public virtual double ComputePerimeter() {
            return 0.0;
        }
    }
}
