﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course
    {
        public string Name;
        public int DurationInMinutes;

        public Course(string name) : this(name, 0)
        {
        }

        public Course(string name, int duration)
        {
            Name = name;
            DurationInMinutes = duration;
        }

        new
        public string ToString()
        {
            return ("Name: " + Name + ", Duration in Minutes: " + DurationInMinutes);
        }
    }
}
