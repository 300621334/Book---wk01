using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational a = new Rational(1, 1);
            Console.WriteLine(a);
            Rational b = new Rational(1, 2);
            Console.WriteLine(b);

            a.increaseBy(b); Console.WriteLine(a);
            Console.WriteLine();

            Rational c = new Rational(1, 1);
            Console.WriteLine(c);
            Rational d = new Rational(1, 3);
            Console.WriteLine(d);

            c.decreaseBy(d); Console.WriteLine(c);
            
           
        }

        public class Rational
        {
            //fields
            private int denominator;
            private int numerator;
            private double number;

            //constructor
            public Rational(int nume=0, int denomi=1)
            {
                numerator = nume;
                denominator = denomi;
                number = (double)numerator / denominator;
            }

            //to display
            public override string ToString()
            {
                return string.Format("Rational Number is: {0}", number);
            }

            //increase
            public void increaseBy(Rational obj)
            {
                number += obj.number;
            }
            //decrease
            public void decreaseBy(Rational obj)
            {
                number -= obj.number;
            }
        }
    }
}

			
			