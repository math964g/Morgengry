using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book : Merchandise
    {
        // public string ItemID;
        public string Title;
        public double Price;

        public Book(string itemID) : this(itemID, "", 0)
        {
        }

        public Book(string itemID, string title) : this(itemID, title, 0) 
        {
        }

        public Book(string itemID, string title, double price) : base(itemID)
        {
            ItemID = itemID;
            Title = title;
            Price = price;
        }

        /*
        public Book(string itemID)
        {
            ItemID = itemID;
        }

        public Book(string itemID, string title)
        {
            ItemID = itemID;
            Title = title;
        }

        public Book(string itemID, string title, double price)
        {
            ItemID = itemID;
            Title = title;
            Price = price;
        }
        */

        new
        public string ToString()
        {
            return ("ItemId: " + ItemID + ", Title: " + Title + ", Price: " + Price);
        }
        
    }
}
