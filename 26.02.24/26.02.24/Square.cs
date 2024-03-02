using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    /// <summary>
    /// класс описывающий квадрат 
    /// </summary>
    internal class Square:Figure
    {
        /// <summary>
        /// сторона а
        /// </summary>
        int side1;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Square() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">название</param>
        /// <param name="side1">сторона a</param>
        public Square(string name,int side1):base(name)
        {
            this.side1 = side1;
        }
        /// <summary>
        /// свойство стороны a
        /// </summary>
        public int Side1 { get { return side1; } set { side1 = value; } }
        /// <summary>
        /// метод для нахождения площади 
        /// </summary>
        /// <returns>площадь квадрата</returns>
        public override double Area()
        {
            return Math.Pow(side1,2);
        }
        /// <summary>
        /// метод для нахождения периметра
        /// </summary>
        /// <returns>периметр квадрата</returns>
        public override double Perimeter()
        {
            return side1*4;
        }
        /// <summary>
        /// метод для вывода информации 
        /// </summary>
        /// <returns>поля класса</returns>
        public override string ToString()
        {
            return $"Название фигуры-{base.ToString()} а={side1}";
        }
        /// <summary>
        /// метод для ввода информации об объекте
        /// </summary>
        /// <returns>конструктор с параметрами</returns>
        public static Square Input()
        {
            string name = "Квадрат";
            Console.WriteLine("a=");
            int side1 = int.Parse(Console.ReadLine());
            return new Square(name, side1);
        }
    }
}
