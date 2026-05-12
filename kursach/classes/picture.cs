using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.classes
{
    public class Picture : Exhibit
    {
        private int height;
        private int width;

        public Picture(string author, string country, int year, int height, int width) : base(author, country, year)
        {
            Height = height;
            Width = width;
        }

        public int Height
        {
            get { return height; }
            set { 
                if (value < 0) {    
                    throw new ArgumentException("Висота не може бути від'ємною.");
                }
                height = value;
            }
        }
        public int Width
        {
            get { return width; }
            set { 
                if (value < 0) {    
                    throw new ArgumentException("Ширина не може бути від'ємною.");
                }
                width = value;
            }
        }
         public override string ToString()
        {
            return $"Картина: автор = {Author}, країна = {Country}, рік = {ShowYear(Year)}, висота = {Height}, ширина = {Width}";
        }
        public bool FitsInRoom(Room room)
        {
            return Width <= room.Width &&
                   Height <= room.Height;
        }
    }
}
