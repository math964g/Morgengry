﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public abstract class Merchandise
    {
        public string ItemID;
   
        new
        public string ToString()
        {
            return "ItemId: " + ItemID;
        }
    }
}
