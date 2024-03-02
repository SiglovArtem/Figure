using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    /// <summary>
    /// класс описывающий круг
    /// </summary>
    internal class Circle:Figure
    {
        /// <summary>
        /// сторона радиус
        /// </summary>
        int side1;
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Circle() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">название</param>
        /// <param name="side1">радиус</param>
        public Circle(string name,int side1):base(name) 
        {
         this.side1= side1;
        }
        /// <summary>
        /// свойство радиуса
        /// </summary>
        public int Side1 { get => side1; set => side1 = value; }
        /// <summary>
        /// метод для нахождения площади
        /// </summary>
        /// <returns>площадь круга</returns>
        public override double Area()
        {
            return Math.PI*Math.Pow(side1,2);
        }
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        /// <returns>поля класса</returns>
        public override string ToString() 
        {
            return $"Название фигуры-{base.ToString()} радиус={side1}";
        }
        /// <summary>
        /// метод для нахождения периметра 
        /// </summary>
        /// <returns>периметр круга</returns>
        public override double Perimeter()
        {
            return 2 * Math.PI * side1; ;
        }
        /// <summary>
        /// метод для ввода информации об объекте
        /// </summary>
        /// <returns>конструктор с параметрами </returns>
        public static Circle Input()
        {
            
            string name = "Круг";
            Console.WriteLine("радиус=");
            int side1 = int.Parse(Console.ReadLine());
            return new Circle(name, side1);
        }
    }
}
