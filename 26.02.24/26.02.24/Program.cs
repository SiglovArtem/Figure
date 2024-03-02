using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                //создание листа
                List<Figure> figures = new List<Figure>();
                Rectangle rectangle1 = new Rectangle("Прямоугольник",3,5);
                Square square1 = new Square("Квадрат", 4);
                figures.Add(rectangle1);
                figures.Add(square1);
                foreach(var elem in figures)
                {
                    Console.WriteLine(elem.ToString());
                }
                bool flag = true;
                bool flag2 = true;
                while (flag2)
                {
                    Console.WriteLine($"1-ДОБАВИТЬ ОБЪЕКТ\n2-ИЗМЕНИТЬ ОБЪЕКТ\n3-УДАЛИТЬ ОБЪЕКТ\n4-МЕТОД ОБЪЕКТА\n");
                    int deistvie = int.Parse(Console.ReadLine());
                    switch (deistvie)
                    {
                        //заполнение листа 
                        case 1:
                            while (flag)
                            {
                                Console.WriteLine("Первую букву фигуры-");
                                string fig = Console.ReadLine();
                                switch (fig.ToLower())
                                {
                                     case "r": Rectangle rectangle = new Rectangle(); figures.Add(Rectangle.Input()); break;
                                    case "s": Square square = new Square(); figures.Add(Square.Input()); break;
                                    case "t": Triangle triangle = new Triangle(); figures.Add(Triangle.Input()); break;
                                    case "c": Circle circle = new Circle(); figures.Add(Circle.Input()); break;
                                    default: Console.Clear(); flag = false; break;
                                }
                            }
                            //вывод листа
                            foreach (var item in figures)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            flag = true;
                            break;
                        //изменение объектов 
                        case 2:
                            while (flag)
                            {
                                
                                    Console.WriteLine("Элемент списка-");
                                    int n = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Первая буква фигуры-");
                                    string fig = Console.ReadLine();
                                    switch (fig.ToLower())
                                    {
                                         case "r": Rectangle rectangle = new Rectangle(); figures[n] = Rectangle.Input(); break;
                                        case "s": Square square = new Square(); figures[n] = Square.Input(); break;
                                        case "t": Triangle triangle = new Triangle(); figures[n] = Triangle.Input(); break;
                                        case "c": Circle circle = new Circle(); figures[n] = Circle.Input(); break;
                                        default: Console.Clear();flag=false ; break;
                                    }
                                    foreach (var item in figures)
                                    {
                                        Console.WriteLine(item.ToString());

                                    }
                                
                                
                            }
                            
                            flag = true;
                            break;
                        //удаление объекта
                        case 3:
                            while (flag)
                            {
                                
                                    Console.WriteLine("Введите индекс удаляемого объекта");
                                    int index = int.Parse(Console.ReadLine());
                                    figures.RemoveAt(index);
                                    foreach (var item in figures)
                                    {
                                        Console.WriteLine(item.ToString());
                                    }
                                flag = false;
                            }
                            flag = true;
                            break;

                        //Метод объекта
                        case 4:
                            while (flag)
                            {
                                Console.WriteLine("Индекс объекта над которым будем выполнять действия?");
                                int elem = int.Parse(Console.ReadLine());
                                Console.WriteLine("Действие которое будет выполняться над объектом?");
                                string deist = Console.ReadLine();
                                switch (deist.ToLower())
                                {
                                    case "вывод": Console.WriteLine(figures[elem].ToString()); break;
                                    case "площадь":
                                        Console.WriteLine(figures[elem].Area()); break;
                                    case "периметр":
                                        Console.WriteLine(figures[elem].Perimeter()); break;
                                    default: Console.Clear(); flag = false; break;
                                }
                            }
                            flag = true;
                            break;
                        default:flag2 = false; break;
                    }
                }

            }
            catch { Console.WriteLine("Not correct data"); }
                Console.ReadLine();
            
        }
    }
}
