using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignADV03
{
    internal class Book
    {
        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }

        private string _isbn;
        private string _title;
        private string[] _authors;
        private decimal _price;

        public string ISBN // need some work
        {
            get => _isbn;

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    // Remove any hyphens or spaces from the input
                    string cleanedISBN = value.Replace("-", "").Replace(" ", "");

                    // Check if the cleaned ISBN has exactly 10 or 13 characters
                    if (cleanedISBN.Length == 10 || cleanedISBN.Length == 13)
                    {
                        // Validate based on ISBN-10 or ISBN-13 checksum rules
                        if (IsValidISBN(cleanedISBN))
                        {
                            _isbn = value; // Assign the validated ISBN
                        }
                        else
                        {
                            throw new ArgumentException("Invalid ISBN format or checksum.");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Invalid ISBN length.");
                    }
                }
                else
                {
                    throw new ArgumentNullException(nameof(value), "ISBN cannot be null or empty.");
                }

            }
        }

        public string Title
        {
            get => _title;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _title = value;
                }
                else
                {
                    throw new ArgumentNullException("Authors mustn't be null");
                }
            }
        }
        public string[] Authors
        {
            get => _authors;
            set
            {
                if (value is not null && value.Length!=0)
                {
                    _authors = value;
                }
                else
                {
                    throw new ArgumentNullException("Authors mustn't be null"); 
                }
            }
        }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get => _price;  set 
            {
                if(value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Enter the right price"); 
                }
            } }

        public override string ToString()
        {
            return $"ISBN : {_isbn}\nTitle : {_title}\nAuthors : {_authors}\nPublication date : {PublicationDate.ToShortDateString()}\nPrice : {_price}";
        }


        #region ISBN STUFF
        private bool IsValidISBN(string isbn)
        {
            if (isbn.Length == 10)
            {
                return IsValidISBN10(isbn);
            }
            else if (isbn.Length == 13)
            {
                return IsValidISBN13(isbn);
            }
            return false;
        }

        // Validate ISBN-10 checksum
        private bool IsValidISBN10(string isbn10)
        {
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                if (!char.IsDigit(isbn10[i]))
                {
                    return false;
                }
                sum += (10 - i) * int.Parse(isbn10[i].ToString());
            }

            char lastChar = isbn10[9];
            if (lastChar == 'X')
            {
                sum += 10;
            }
            else if (char.IsDigit(lastChar))
            {
                sum += int.Parse(lastChar.ToString());
            }
            else
            {
                return false;
            }

            return (sum % 11) == 0;
        }

        // Validate ISBN-13 checksum
        private bool IsValidISBN13(string isbn13)
        {
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                if (!char.IsDigit(isbn13[i]))
                {
                    return false;
                }
                int digit = int.Parse(isbn13[i].ToString());
                sum += i % 2 == 0 ? digit : digit * 3;
            }

            int checkDigit = int.Parse(isbn13[12].ToString());
            int remainder = sum % 10;
            int checksum = (remainder == 0) ? 0 : 10 - remainder;

            return checkDigit == checksum;
        }
        #endregion
    }
}
