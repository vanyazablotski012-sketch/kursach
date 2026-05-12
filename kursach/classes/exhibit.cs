using System;
using System.Security.AccessControl;

namespace kursach.classes
{
    public class Exhibit
    {
        private string name;
        private string author;
        private string country;
        private int year;



        public Exhibit(string name, string author, string country, int year)
        {
            Name = name;
            Author = author;
            Country = country;
            Year = year;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Назва не може бути пустою.");
                name = value;
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) author = "Невідомий";
                author = value;

            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Країна не може бути пустою.");
                country = value;
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value != 0)
                    year = value;
                else
                   throw new ArgumentException("Рік не може бути нулем.");
            }
        }

        public string ShowYear(int currentYear)
        {
            if (currentYear > 0)
                return $"{currentYear} р. н.е.";
            else
                return $"{-currentYear} р. до н.е.";
        }
    } 
}