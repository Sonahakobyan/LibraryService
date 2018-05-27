using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace LibraryService
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int ID { get; internal set; }
        public string Author { get; internal set; }
        public string Title { get; internal set; }
        public double Price { get; internal set; }
        public int Year { get; internal set; }

        public Book(string author, string title, double price, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
            this.Year = year;
        }

        public bool IsValid()
        {
            return (!string.IsNullOrWhiteSpace(this.Author) && !string.IsNullOrWhiteSpace(this.Title) && Price > 0 && Year > 0);
        }

        public override string ToString() => $"Author: {this.Author}\nTitle: {this.Title}\nYear: {Year}\nPrice:{this.Price}\n"; 
    }
}
