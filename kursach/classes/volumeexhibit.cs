using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.classes
{
    public class VolumeExhibit : Exhibit
    {
        private double width;
        private double length;
        private double height;
        public VolumeExhibit(string name, string author, string country, int year, double width, double length, double height) : base(name, author, country, year)
        {
            Width = width;
            Length = length;
            Height = height;
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0) throw new ArgumentException("Ширина не може бути від'ємною.");
                width = value;
            }
        }
        public double Length
        {
            get { return length; }
            set
            {
                if (value < 0) throw new ArgumentException("Довжина не може бути від'ємною.");
                length = value;
            }
        }
        public double Height
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
            return $"Об'ємний експонат: назва = {Name}, автор = {Author}, країна = {Country}, рік = {ShowYear(Year)}, ширина = {Width}, довжина = {Length}, висота = {Height}";
        }
        public bool FitsInRoom(Room room)
        {
            return Width <= room.Width &&
                   Length <= room.Length &&
                   Height <= room.Height;
        }
    }
}
