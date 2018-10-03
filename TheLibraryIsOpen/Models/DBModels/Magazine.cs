﻿using System;
namespace TheLibraryIsOpen.Models.DBModels
{
    public class Magazine
    {
        public int MagazineId { get; set; }
        public string Title { get; set; }
        public int IssueNumber { get; set; }
        public DateTime Date { get; set; }
        public string Editor { get; set; }
        public string Category { get; set; }
        public string Publisher { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public int Year { get; set; }
        public string Isbn { get; set; }

        // Default constructor
        public Magazine() { }

        /* Here the constructor assign values to attributes besides MagazineId.
         * The MagazineId is generated by database, when insert an entry to the "magazine" table (assumed it's already & primary key autoincrement).
         * The last id just entered from table would be assigned to MagazineId for the magazine object. So that to avoid same id appears when server gets restarted.
        */
        public Magazine(string title, int issueNumber, DateTime date, string editor, string category, string publisher, string country, string language, int year, string isbn)
        {
            Title = title;
            IssueNumber = issueNumber;
            Date = date;
            Editor = editor;
            Category = category;
            Publisher = publisher;
            Country = country;
            Language = language;
            Year = year;
            Isbn = isbn;
        }

        // another construcor who  assigns client id is added as requested.
        public Magazine(int mgId, string title, int issueNumber, DateTime date, string editor, string category, string publisher, string country, string language, int year, string isbn)
        {
            MagazineId = mgId;
        }

        // Return information about the music
        public override string ToString()
        {
            return "Magazine:\nTitle:" + Title + "\nIssue Number:" + IssueNumber + "\nIssue Date: " + Date + "\nEditor:" + Editor +
                "\nCategory:" + Category + "\nPublisher:" + Publisher + "\nCountry:" + Country + "\nLanguage:" + Language +
                "\nYear:" + Year + "\nISBN:" + Isbn + "\nMagazine ID:" + MagazineId;
        }
    }
}
