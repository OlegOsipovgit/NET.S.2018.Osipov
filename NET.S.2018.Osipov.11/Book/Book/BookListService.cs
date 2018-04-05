using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class BookListService
    {
        private List<Books> books = new List<Books>;
        
        public void AddBook(Books newbook)
        {
            books.Add(newbook);
        }
        public void RemoveBook(Books book)
        {
            books.Remove(book);
        }
        public void FindBookByTeg(Books book)
        {

        }
        public void SortBooksByTag(IComparer<Books> comparator)
        {
            var booksarray = books.ToArray();
            if (ReferenceEquals(comparator, null))
            {
                Array.Sort(booksarray);
            }
            else
            {
                Array.Sort(booksarray, comparator);
            }
            books.Clear();
            books.AddRange(booksarray);
        }
    }
}
