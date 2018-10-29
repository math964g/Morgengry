using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public static double GetValueOfAmulet(Amulet amulet)
        {
            double value = 0;
            if (amulet.Quality == Level.low)
            {
                value = 12.5;
            }

            if (amulet.Quality == Level.medium)
            {
                value = 20.0;
            }

            if (amulet.Quality == Level.high)
            {
                value = 27.5;
            }

            return value;   
        }

        public static double GetValueOfCourse(Course course)
        {
            double value = 0;

            for (int i = 0; i < course.DurationInMinutes; i+=60)
            {
                value += 875.00;
            }
                

            return value;
        }
    }
}
