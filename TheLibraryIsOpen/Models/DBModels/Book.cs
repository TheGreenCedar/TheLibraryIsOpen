﻿namespace TheLibraryIsOpen.Models.DBModels
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
        public string Isbn { get; set; }

        // Default constructor
        public Book() { }

        /* Here the constructor assign values to attributes besides BookId.
         * The BookId is generated by database, when insert an entry to the "book" table (assumed it's already & primary key autoincrement).
         * The last id just entered from table would be assigned to BookId for the book object. So that to avoid same id appears when server gets restarted.
        */
        public Book(string title, string category, string author, string publisher, string country, string language, int year, int pages, string isbn)
        {
            Title = title;
            Category = category;
            Author = author;
            Publisher = publisher;
            Country = country;
            Language = language;
            Year = year;
            Pages = pages;
            Isbn = isbn;
        }

        // another construcor who  assigns client id is added as requested.
        public Book(int bId, string title, string category, string author, string publisher, string country, string language, int year, int pages, string isbn)
        {
            BookId = bId;
        }

        // Return information about the music
        public override string ToString()
        {
            return "Book:\nTitle:" + Title + "\nCategory:" + Category + "\nAuthor: " + Author + "\nPublisher:" + Publisher + "\nCountry:" + Country +
                "\nLanguage:" + Language + "\nYear:" + Year + "\nPages:" + Pages + "\nISBN:" + Isbn + "\nBook ID:" + BookId;
        }
    }
}