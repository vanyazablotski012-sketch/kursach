using kursach.classes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace kursach
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<Room> RoomList = new List<Room>();

            RoomList.Add(new Room(10, 10, 10, 100));



           


            RoomList[0].ExhibitList.Add(new Picture("Мона Ліза", "Леонардо да Вінчі", "Італія", 1503, 53, 77));
            

            RoomList[0].ExhibitList.Add(new ArchaeologicalExhibit("Тиранозавр Рекс", "Тиранозавр", "США", -65000000, 12, 2, 4));
            RoomList[0].CanAccommodate(12, 2, 4);

            RoomList[0].ExhibitList.Add(new Sculpture("Давид", "Мікеланджело", "Італія", 1504, 5, 2, 1));
            RoomList[0].CanAccommodate(5, 2, 1);


            RoomList[0].ExhibitList.Add(new ScientificInstrument("Телескоп Ганса Янссена", "Ганс Янссен", "Нідерланди", 1608, 0.5, 0.15, 0.2));
            RoomList[0].CanAccommodate(0.5, 0.15, 0.2);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("ви прийшли до музею, щоб подивитися на експонати: ");
                Console.WriteLine("1 передивитись експонати");
                Console.WriteLine("2 додати експонат");
                Console.WriteLine("3 додати кімнату");
                Console.WriteLine("4 вийти");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            foreach (Room room in RoomList)
                            {
                                foreach (Exhibit exhibit in room.ExhibitList)
                                {
                                    Console.WriteLine(exhibit.ToString());
                                }
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
                                    Console.WriteLine("Введіть тип експонату (1-картина, 2-скульптура, 3-археологічний експонат, 4-науковий інструмент): ");

                                    int goodTypeChoosen = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Введіть автора експонату: ");
                                    string author = Console.ReadLine();

                                    Console.WriteLine("Введіть країну експонату: ");
                                    string country = Console.ReadLine();

                                    Console.WriteLine("Введіть рік створення експонату: ");
                                    int year = int.Parse(Console.ReadLine());

                                    // valid choices are 1..5
                                    if (goodTypeChoosen < 1 || goodTypeChoosen > 5)
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


                                                if (RoomList[0].CanAccommodate(width, length, height))
                                                {
                                                    RoomList[0].ExhibitList.Add(new Sculpture(name, author, country, year, width, length, height));
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Скульптура не поміщається в кімнату. Спробуйте ще раз.");
                                                    Console.ReadKey();
                                                }

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



                                                if (RoomList[0].CanAccommodate(width, length, height))
                                                {
                                                    RoomList[0].ExhibitList.Add(new ArchaeologicalExhibit(name, author, country, year, width, length, height));
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Археологічний експонат не поміщається в кімнату. Спробуйте ще раз.");
                                                    Console.ReadKey();
                                                }
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


                                                if (RoomList[0].CanAccommodate(width, length, height))
                                                {
                                                    RoomList[0].ExhibitList.Add(new ScientificInstrument(name, author, country, year, width, length, height));
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Науковий інструмент не поміщається в кімнату. Спробуйте ще раз.");
                                                    Console.ReadKey();
                                                }
                                                break;


                                            }                                        default:
                                            Console.WriteLine("Експонат успішно додано!");
                                                Console.ReadLine();
                                            

                                            break;
                                    }
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
                    case 3:
                        {



                            {
                                Console.WriteLine("Введіть ширину кімнати (ціле число): ");
                                int width = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введіть довжину кімнати (ціле число): ");
                                int length = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введіть висоту кімнати (ціле число): ");
                                int height = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введіть корисну площу стін (ціле число): ");
                                int usefulWallArea = int.Parse(Console.ReadLine());

                                Room newRoom = new Room(width, length, height, usefulWallArea);
                                Console.WriteLine("кімната успішно додана!");

                            }

                            break;


                        }
                    case 4:
                        {
                            Console.WriteLine("Дякуємо за відвідування музею! До побачення!");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                            Console.ReadKey();
                            break;
                        }

                }


            }
        }
    }
}


