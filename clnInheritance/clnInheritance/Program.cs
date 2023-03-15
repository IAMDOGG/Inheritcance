using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clnInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sh1 = new Shape();
            sh1.Name = "Shape1";
            sh1.Sides = 0;
            Console.WriteLine(sh1);

            Shape sh2 = new Shape("Shape2", 0);
            Console.WriteLine(sh2);

            Square sq = new Square("Square", 4, 2);
            Console.WriteLine(sq);

            Rectangle rec = new Rectangle("Rectangle",5,2);
            Console.WriteLine(rec);    
        }
    }
}
