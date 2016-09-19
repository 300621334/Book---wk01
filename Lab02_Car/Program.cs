using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car(2017, "BMW", "500", true, 54000);
            Console.WriteLine(car1);
            Console.WriteLine();
            //create an "annonymous" object, cannot be called again coz no name.
            Console.WriteLine(new car(1997,"HONDA", "civic", false, 1200));
        }
    }
    class car
    {
        private int year;
        private string manufacturer;
        private string model;
        private bool isDrivable;
        private double price;

        public car(int year, string manufacturer, string model, bool isDrivable, double price)
        {
            this.year = year;
            this.manufacturer = manufacturer;
            this.model = model;
            this.isDrivable = isDrivable;
            this.price = price;
        }

        public override string ToString()
        {
            return string.Format("Year: {0} \nMake: {1} \nModel: {2} \nPrice: {4:c} \nDrivable: {3} ", year, manufacturer, model, isDrivable ? "Drivable" : "Not Drivable", price);
        }
    }
}
