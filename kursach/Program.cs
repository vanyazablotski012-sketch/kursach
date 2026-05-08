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
            Exhibit picture = new Picture("Автор", "Країна", 2024, 100, 200);
            Console.WriteLine(picture);
        }
    }
}