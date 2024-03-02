using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    /// <summary>
    /// класс описывающий треугольник
    /// </summary>
    internal class Rectangle:Figure
    {
        /// <summary>
        /// поля описывающие стороны
        /// </summary>
        int side1, side2;
        /// <summary>
        /// свойство для стороны a
        /// </summary>
        public int Side1 { get => side1; set => side1 = value; }
        /// <summary>
        /// свойство для стороны b
        /// </summary>
        public int Side2 { get => side2; set => side2 = value; }

        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Rectangle() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name">название</param>
        /// <param name="side1">сторона a</param>
        /// <param name="side2">сторона b</param>
        public Rectangle(string name,int side1,int side2):base(name) 
        {
         this.side1 = side1;
            this.side2 = side2;
        }
        /// <summary>
        /// метод для нахождения площади 
        /// </summary>
        /// <returns>площадь прямоугольника </returns>
        public override double Area()
        {
            return side1*side2;
        }
        /// <summary>
        /// метод для нахождения периметра
        /// </summary>
        /// <returns>периметр прямоугольника</returns>
        public override double Perimeter()
        {
            return (side1+side2)*2;
        }
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        /// <returns>поля класса</returns>
        public override string ToString() 
        {
            return $"Название фигуры-{base.ToString()} a={side1} b={side2}";
        }
        /// <summary>
        /// метод для ввода данных об объекте
        /// </summary>
        /// <returns>конструктор с параметрами </returns>
        public static Rectangle Input()
        {
            string name = "Прямоугольник";
            Console.WriteLine("a=");
            int side1=int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int side2=int.Parse(Console.ReadLine());
            return new Rectangle(name, side1, side2);
        }

    }
}
