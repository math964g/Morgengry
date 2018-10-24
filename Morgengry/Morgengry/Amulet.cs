using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public enum Level { low, medium, high }
    public class Amulet
    {
        public string ItemID;
        public string Design;
        public Level Quality;

        public Amulet(string itemID)
        {
            ItemID = itemID;
        }

        public Amulet(string itemID, Level quality)
        {
            ItemID = itemID;
            Quality = quality;
        }

        public Amulet(string itemID, Level quality, string design)
        {
            ItemID = itemID;
            Design = design;
            Quality = quality;
        }

        new
        public string ToString()
        {
            return ItemID;
        }
    }
}
