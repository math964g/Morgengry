using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public enum Level { low, medium, high }
    public class Amulet : Merchandise
    {
        // public string ItemID;
        public string Design;
        public Level Quality;

        public Amulet(string itemID) : this(itemID, Level.medium, "")
        {
        }

        public Amulet(string itemID, Level quality) : this(itemID, quality, "")
        {
        }

        public Amulet(string itemID, Level quality, string design)
        {
            ItemID = itemID;
            Quality = quality;
            Design = design;
        }
            /*
            public Amulet(string itemID): this(itemID, Level.medium)
            {
            }

            public Amulet(string itemID, Level quality): this(itemID, quality, "")
            {
            }

            public Amulet(string itemID, Level quality, string design)
            {
                ItemID = itemID;
                Quality = quality;
                Design = design;
            }
            */

        new
        public string ToString()
        {
            return ("ItemId: " + ItemID + ", Quality: " + Quality + ", Design: " + Design);
        }
    }
}
