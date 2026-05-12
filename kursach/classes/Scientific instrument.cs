using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.classes
{
    public class ScientificInstrument : VolumeExhibit
    {
        public ScientificInstrument(string author, string country, int year, double width, double length, double height) : base(author, country, year, width, length, height)
        {
        }
        public override string ToString()
        {
            return $"Науковий інструмент: автор = {Author}, країна = {Country}, рік = {ShowYear(Year)}, ширина = {Width}, довжина = {Length}, висота = {Height}";
        }
    }
}