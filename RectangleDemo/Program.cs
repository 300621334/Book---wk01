using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DescribeRectangle(CreateRectangle(10, 5));
            CalculateAndDisplayArea(CreateRectangle(10, 5));
            
            //or

            /*Rectangle smallRectangle = CreateRectangle(10, 5);
           DescribeRectangle(smallRectangle);
             * CalculateAndDisplayArea(smallRectangle);
             */
        }
/*Name: CreateRectangle
Returns: A Rectangle object
Argument: int representing the width, int representing the length
Action: Create a Rectangle object, set the width and length as specified by the arguments and then return the object created
*/
        static Rectangle CreateRectangle(int l, int w)
        {
            Rectangle rect = new Rectangle();
            rect.length = l;
            rect.width = w;
            return rect;
        }

/*Name: CalculateAndDisplayArea
Returns: void
Argument: Rectangle object
Action: Calculate and display the area of the rectangle object represented by the parameter
*/
        static void CalculateAndDisplayArea(Rectangle mani)
        {
            Console.WriteLine("Area of rectangle is: {0}", mani.length * mani.width);
        }

/*Name: DescribeRectangle
Returns: void
Argument: Rectangle object
Action: Displays the with and length of the Rectangle object
*/
        static void DescribeRectangle(Rectangle rect)
    {
        Console.WriteLine("Length: {0} Width: {1}", rect.length, rect.width);
    }

    }
}
