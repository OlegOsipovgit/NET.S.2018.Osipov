using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Books:IComparable<Books>, IComparable, IEquatable<Books>, IFormattable
    {
        #region Properties

        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int Pagesquantity {
            get { return Pagesquantity; }
            set
            { if (value < 1) throw new Exception("The quantity of pages can't be lower than 1");
                else Pagesquantity = value; }
        }
        public decimal Price { get { return Price; }
            set { if (Price < 0) throw new Exception("The price can't be lower than 0");
                else Price = value;
            }
        }
        #endregion
        #region Constructors
        public Books(string ISBN, string author, string name,string publisher,int year, int pagesquantity, decimal price)
        {
            this.ISBN = ISBN;
            Author = author;
            Name = name;
            Publisher = publisher;
            Year = year;
            Pagesquantity = pagesquantity;
            Price = price;
        }

        #endregion
        #region Override
        public override bool Equals(object otherbook)
        {
            if (ReferenceEquals(this, otherbook)) return true;
            if (ReferenceEquals(otherbook, null)) return false;
            if (otherbook.GetType() != this.GetType()) return false;
            Books newotherbook = otherbook as Books;
            if (this.ISBN == newotherbook.ISBN && this.Author == newotherbook.Author && this.Name == newotherbook.Name && this.Publisher == newotherbook.Publisher && this.Pagesquantity == newotherbook.Pagesquantity && this.Price == newotherbook.Price) return true;
            else return false;
        }
        public bool Equals(Books otherbook)
        {
            if (ReferenceEquals(this, otherbook)) return true;
            if (ReferenceEquals(otherbook, null)) return false;
            if (this.ISBN == otherbook.ISBN && this.Author == otherbook.Author && this.Name == otherbook.Name && this.Publisher == otherbook.Publisher && this.Pagesquantity == otherbook.Pagesquantity && this.Price == otherbook.Price) return true;
            else return false;
        }
        public override int GetHashCode()
        {
            return this.ISBN.GetHashCode();
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(ISBN)||String.IsNullOrEmpty(Author)||String.IsNullOrEmpty(Name)||String.IsNullOrEmpty(Publisher)) return base.ToString();
            return (ISBN+Author+Name+Publisher+Year+Pagesquantity.ToString()+Price.ToString());
        }

        public int CompareTo(Books otherbook)
        {
            if (ReferenceEquals(this, otherbook))
            {
                return 0;
            }
            return this.ISBN.CompareTo(otherbook.ISBN);

        }
        public int CompareTo(object otherbook)
        {
            if (otherbook == null) return 1;
            Books book = otherbook as Books;
            if (book != null)
                return this.ISBN.CompareTo(book.ISBN);
            else return this.Name.CompareTo(book.Name);
        }

        #endregion
        #region Iformattable
        public string ToString(string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format)) format = "G";
            if (provider == null) provider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
            
                case "AN":
                    return $"AuthorName: {Author}, Title: {Name}";
                case "ANPY":
                    return $"AuthorName: {Author}, Title: {Name}, Publisher: {Publisher}, Year: {Year.ToString(provider)}";
                case "IANPYP":
                    return $"ISBN 13: {ISBN}, AuthorName: {Author}, Title: {Name}, Publisher: {Publisher}, Year: {Year.ToString(provider)}, Price: {Price.ToString(provider)}";
                case "ANPP":
                    return $"AuthorName: {Author}, Title: {Name}, Publisher: {Publisher}, Price: {Price.ToString(provider)}";
                case "G":
                    return $"ISBN 13: {ISBN}, AuthorName: {Author}, Title: {Name}, Publisher: {Publisher}, Year: {Year.ToString(provider)}, Number of pages: {Pagesquantity.ToString(provider)}, Price: {Price.ToString(provider)}";
                        
            default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }
        }
        #endregion

    }




}

