using kursach.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace kursach
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<Exhibit> ExhibitList = new List<Exhibit>();

            ExhibitList.Add (new Picture("Мона Ліза", "Леонардо да Вінчі", "Італія", 1503, 53, 77));

            ExhibitList.Add (new ArchaeologicalExhibit("Тиранозавр Рекс", "Тиранозавр", "США", -65000000, 12, 2, 4));

            ExhibitList.Add (new Sculpture("Давид", "Мікеланджело", "Італія", 1504, 5, 2, 1));

            ExhibitList.Add (new ScientificInstrument("Телескоп Ганса Янссена", "Ганс Янссен", "Нідерланди", 1608, 0.5, 0.15, 0.2));


            Console.WriteLine("ви прийшли до музею, щоб подивитися на експонати: ");
            Console.WriteLine("1 передивитись експонати");
            Console.WriteLine("2 додати експонат");
            Console.WriteLine("3 вийти");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.Clear();
                       foreach (Exhibit exhibit in ExhibitList)
                        {
                            Console.WriteLine(exhibit.ToString());
                        }

                        Console.ReadKey();
                        break;

                    }

                case 2:

                    {
                        while (true)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Введіть тип експонату (картина, скульптура, археологічний експонат, науковий інструмент): ");



                                int goodTypeChoosen = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введіть автора експонату: ");
                                string author = Console.ReadLine();

                                Console.WriteLine("Введіть країну експонату: ");
                                string country = Console.ReadLine();

                                Console.WriteLine("Введіть рік створення експонату: ");
                                int year = int.Parse(Console.ReadLine());

                                if (goodTypeChoosen < 0 || goodTypeChoosen > 4)
                                {
                                    Console.WriteLine("Невірний тип експонату. Спробуйте ще раз.");
                                    Console.ReadKey();
                                    break;
                                }



                                switch (goodTypeChoosen)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Введіть висоту картини: ");
                                            int height = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Введіть ширину картини: ");
                                            int width = int.Parse(Console.ReadLine());

                                           Console.WriteLine("Введіть назву картини: ");
                                           string name = Console.ReadLine();

                                           Picture newPicture = new Picture(name, author, country, year, height, width);

                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Введіть висоту скульптури: ");
                                            int height = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Введіть ширину скульптури: ");
                                            int width = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Введіть довжину скульптури: ");
                                            int length = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Введіть назву скульптури: ");
                                            string name = Console.ReadLine();

                                            Sculpture newSculpture = new Sculpture(name, author, country, year, width, length, height);

                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("Введіть висоту археологічного експонату: ");
                                            int height = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Введіть ширину археологічного експонату: ");
                                            int width = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Введіть довжину археологічного експонату: ");
                                            int length = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Введіть назву археологічного експонату: ");
                                            string name = Console.ReadLine();

                                            ArchaeologicalExhibit newArchaeologicalExhibit = new ArchaeologicalExhibit(name, author, country, year, width, length, height);

                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.WriteLine("Введіть висоту наукового інструменту: ");
                                            double height = double.Parse(Console.ReadLine());

                                            Console.WriteLine("Введіть ширину наукового інструменту: ");
                                            double width = double.Parse(Console.ReadLine());

                                            Console.WriteLine("Введіть довжину наукового інструменту: ");
                                            double length = double.Parse(Console.ReadLine());

                                            Console.WriteLine("Введіть назву наукового інструменту: ");
                                            string name = Console.ReadLine();

                                            ScientificInstrument newScientificInstrument = new ScientificInstrument(name, author, country, year, width, length, height);
                                        }

                                        break;

                                }

                                Console.WriteLine("Експонат успішно додано!");
                                Console.ReadLine();

                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Помилка: " + ex.Message);
                                Console.ReadKey();
                                break;
                            }
                        }
                        break;


                    }

            }
        }

    }
}

