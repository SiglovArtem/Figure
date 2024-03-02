using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    /// <summary>
    /// абстрактный класс описывающий фигуру
    /// </summary>
    abstract class Figure
    {
        /// <summary>
        /// поле для названия фигуры
        /// </summary>
        string name;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Figure() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name">название</param>
        public Figure(string name)
        { this.name = name; }
        /// <summary>
        /// свойство названия фигуры
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        /// <summary>
        /// абстрактный метод нахождения площади
        /// </summary>
        /// <returns>площадь фигуры</returns>
        abstract public double Area();
        /// <summary>
        /// абстрактный метод нахождения периметра
        /// </summary>
        /// <returns>периметр</returns>
        public abstract double Perimeter();
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        /// <returns>поля класса</returns>
        public override string ToString()
        {
            return name;
        }



    }
}
