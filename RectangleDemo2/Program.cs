using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle smallRect = new Rectangle(4, 10); //constructor-method of object/class may requires args/params.
            Console.WriteLine(smallRect); //uses string returned by "override" method of obj/class. Without override, it just displays namespace.className
            smallRect.CalculateAndDisplayArea();

        }
    }
    
}
