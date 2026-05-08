using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.classes
{
    public class VolumeExhibit : Exhibit
    {
        private int width;
        private int length;
        private int height;
        public VolumeExhibit(string author, string country, int year, int width, int length, int height) : base(author, country, year)
        {
            Width = width;
            Length = length;
            Height = height;
        }
        public int Width
        {
            get { return width; }
            set
            {
                if (value < 0) throw new ArgumentException("Ширина не може бути від'ємною.");
                width = value;
            }
        }
        public int Length
        {
            get { return length; }
            set
            {
                if (value < 0) throw new ArgumentException("Довжина не може бути від'ємною.");
                length = value;
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0) throw new ArgumentException("Висота не може бути від'ємною.");
                height = value;
            }
        }
         public override string ToString()
        {
            return $"Об'ємний експонат: автор = {Author}, країна = {Country}, рік = {Year}, ширина = {Width}, довжина = {Length}, висота = {Height}";
        }
    }
}
