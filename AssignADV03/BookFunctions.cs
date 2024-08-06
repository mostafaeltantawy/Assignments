using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignADV03
{
    internal class BookFunctions
    {
        public static string GetTitle(Book b)
        {
            return b.Title;
        }

        public  static  string    GetAuthors(Book b)
        {
            string authors = "";
            foreach (var item in b.Authors)
            {
                authors += $" {item} , ";

            }
            return authors;
        }

        public static string GetPrice(Book b)
        {
            return b.Price.ToString();
        }
    }
}
