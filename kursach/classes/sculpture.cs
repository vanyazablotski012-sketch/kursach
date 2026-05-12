using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.classes
{
    public class Sculpture : VolumeExhibit
    {
        public Sculpture(string name, string author, string country, int year, int width, int length, int height) : base(name, author, country, year, width, length, height)
        {
        }
         public override string ToString()
        {
            return $"Скульптура: назва = {Name}, автор = {Author}, країна = {Country}, рік = {ShowYear(Year)}, ширина = {Width}, довжина = {Length}, висота = {Height}";
        }
    }

}
