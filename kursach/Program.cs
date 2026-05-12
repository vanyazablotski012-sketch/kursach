using kursach.classes;
using System;
using System.Text;

namespace kursach
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Exhibit MonaLisa = new Picture("Да Вінчі", "Італія", 1503, 53, 77);


            Exhibit Tyrannosaurus = new ArchaeologicalExhibit("Тиранозавр", "США", -65000000, 12, 2, 4);


            Exhibit David = new Sculpture("Мікеланджело", "Італія", 1504, 5, 2, 1);


            Exhibit Microscope = new ScientificInstrument("Ганс Янссен", "Нідерланди", 1608, 0.5, 0.15, 0.2);


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
                        Console.WriteLine(MonaLisa);
                        Console.WriteLine(Tyrannosaurus);
                        Console.WriteLine(David);
                        Console.WriteLine(Microscope);
                        Console.ReadKey();
                        break;

                    }
                case 2:
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



                            switch (goodTypeChoosen)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Введіть висоту картини: ");
                                        double height = double.Parse(Console.ReadLine());

                                        Console.WriteLine("Введіть ширину картини: ");
                                        double width = double.Parse(Console.ReadLine());

                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Введіть висоту скульптури: ");
                                        double height = double.Parse(Console.ReadLine());

                                        Console.WriteLine("Введіть ширину скульптури: ");
                                        double width = double.Parse(Console.ReadLine());

                                        Console.WriteLine("Введіть довжину скульптури: ");
                                        double length = double.Parse(Console.ReadLine());

                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Введіть висоту археологічного експонату: ");
                                        double height = double.Parse(Console.ReadLine());

                                        Console.WriteLine("Введіть ширину археологічного експонату: ");
                                        double width = double.Parse(Console.ReadLine());

                                        Console.WriteLine("Введіть довжину археологічного експонату: ");
                                        double length = double.Parse(Console.ReadLine());

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

            }
        }

    }
}

