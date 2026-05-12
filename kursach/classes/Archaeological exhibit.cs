using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.classes
{
    public class ArchaeologicalExhibit : VolumeExhibit
    {
        public ArchaeologicalExhibit(string author, string country, int year, int width, int length, int height) : base(author, country, year, width, length, height)
        {
        }
         public override string ToString()
        {
            return $"Археологічний експонат: автор = {Author}, країна = {Country}, рік = {ShowYear(Year)}, ширина = {Width}, довжина = {Length}, висота = {Height}";
        }
    }
}
