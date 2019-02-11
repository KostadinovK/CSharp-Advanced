using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public int CompareTo(Book other)
        {
            int compare = this.Year.CompareTo(other.Year);

            if (compare == 0)
            {
                compare = this.Title.CompareTo(other.Title);
            }

            return compare;
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
