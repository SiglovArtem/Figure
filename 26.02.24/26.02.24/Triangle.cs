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
    internal class Triangle:Figure
    {
        /// <summary>
        /// стороны треугольника
        /// </summary>
        int side1, side2, side3;
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Triangle() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name">название</param>
        /// <param name="side1">сторона a</param>
        /// <param name="side2">сторона b</param>
        /// <param name="side3">сторона c</param>
        public Triangle(string name,int side1, int side2, int side3):base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        /// <summary>
        /// свойство стороны a
        /// </summary>
        public int Side1 { get => side1; set => side1 = value; }
        /// <summary>
        /// свойство стороны b
        /// </summary>
        public int Side2 { get => side2; set => side2 = value; }
        /// <summary>
        /// свойство стороны c
        /// </summary>
        public int Side3 { get => side3; set => side3 = value; }
        /// <summary>
        /// метод для нахождения площади
        /// </summary>
        /// <returns>площадь треугольника</returns>
        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
        }
        /// <summary>
        /// метод для нахождения периметра 
        /// </summary>
        /// <returns>периметр треугольника</returns>
        public override double Perimeter()
        {
            return side1+side2+side3;
        }
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        /// <returns>поля класса</returns>
        public override string ToString()
        {
            return $"Название фигуры-{base.ToString()} a={side1} b={side2} c={side3}";
        }
        /// <summary>
        /// метод для ввода информации об объекте
        /// </summary>
        /// <returns>конструктор с параметрами </returns>
        public static Triangle Input()
        {
            string name = "Треугольник";
            Console.WriteLine("a=");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            int side3=int.Parse(Console.ReadLine());
            return new Triangle(name, side1, side2,side3);
        }
    }
}
