using kursach.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Exhibit MonaLisa = new Picture("Да Вінчі", "Італія", 1503, 53, 77);
            Console.WriteLine(MonaLisa);

            Exhibit Tyrannosaurus = new ArchaeologicalExhibit("Тиранозавр", "США", -65000000, 12, 2, 4);
            Console.WriteLine(Tyrannosaurus);

            Exhibit David = new Sculpture("Мікеланджело", "Італія", 1504, 5, 2, 1);
            Console.WriteLine(David);

            Exhibit Microscope = new ScientificInstrument("Ганс Янссен", "Нідерланди", 1608, 0.5, 0.15, 0.2);
            Console.WriteLine(Microscope);
        }
    }
}