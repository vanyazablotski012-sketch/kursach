using System;

namespace kursach.classes
{
    public class Exhibit
    {
        private string author;
        private string country;
        private int year;



        public Exhibit(string author, string country, int year)
        {
            Author = author;
            Country = country;
            Year = year;
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
            get => year;
            set
            {
                if (value != 0)
                    year = value;
                else
                    Console.WriteLine("0 року не існує  ");
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