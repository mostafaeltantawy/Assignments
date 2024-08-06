using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignADV03
{
    internal delegate string BookProcessFunc(Book book); 
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, BookProcessFunc bookProcess)
        {
            foreach (var book in books)
            {
                Console.WriteLine(bookProcess(book));
            }

        }
        public static void ProcessBooks(List<Book> books, Func<Book, string> bookProcess)
        {
            foreach (var book in books)
            {
                Console.WriteLine(bookProcess(book));
            }

        }
    }
}
