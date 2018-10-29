using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class BookRepository
    {
        List<Book> books;

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBook(string itemID)
        {
            foreach (Book book in books)
            {
                if (book.ItemID == itemID)
                {
                    return book;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double value = 0;

            foreach (Book book in books)
            {
                value += book.Price;
            }
            return value;
        }
    }
}
