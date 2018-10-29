using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        private double value;

        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            if (amulet.Quality == low)
            {
                value = 12.5;
            }

            if (amulet.Quality == medium)
            {
                value = 20.0;
            }

            if (amulet.Quality == high)
            {
                value = 27.5;
            }

            return value;   
        }

        public double GetValueOfCourse(Course course)
        {
            if (course.DurationInMinutes > 0)
                value += 875.00;
                course.DurationInMinutes -= 60;

            return value;
        }
    }
}
