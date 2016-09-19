using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Date newDate = new Date(2016, 5, 11);
            Console.WriteLine(newDate);
            newDate.AddDays(1000);
            Console.WriteLine(newDate);

            Date date2 = new Date(2016, 12, 31);
            Console.WriteLine(date2);
            date2.AddDays(-4);
            Console.WriteLine(date2);

        }
    }
    class Date
    {
        //Fields
        private int year;
        private int month;
        private int day;

        //Constructor
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public override string ToString()
        {
            return string.Format("{0:d2}//{1:d2}//{2:d2} ", year, month, day);
        }
        public void AddDays(int howMany)
        {
            day += howMany;
            normalize();
        }

        private void normalize()
        {
            if(day>30)
            {
                month += day / 30;
                year += month / 12;
                if(month>12)
                {
                    month = month % 12;
                }
                day = day % 30;
            }

        }
    }
}
