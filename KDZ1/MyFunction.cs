using System;

namespace KDZ1
{
    /// <summary>
    /// Класс функции
    /// </summary>
    class MyFunction
    {
        /// <summary>
        /// Параметр
        /// </summary>
        private int a;

        /// <summary>
        /// Параметр
        /// </summary>
        public int A
        {
            set { a = value; }
        }

        /// <summary>
        /// Шаг дифференцирования
        /// </summary>
        private double dx = 0.01;

        /// <summary>
        /// Шаг дифференцирования
        /// </summary>
        public double DeltaX
        {
            set { dx = value; }
        }
        
        /// <summary>
        /// Настройка вычисляемой функции
        /// </summary>
        /// <param name="_a">Параметр</param>
        /// <param name="_dx">Шаг дифференцирования</param>
        public MyFunction(int _a, double _dx)
        {
            a = _a;
            dx = _dx;
        }

        /// <summary>
        /// Вычисление значения функции в точке
        /// </summary>
        /// <param name="x">Точка</param>
        /// <returns>Значение функции</returns>
        public double Evaluate(double x)
        {
            return 1.0 * a * Math.Pow(x, 3) - 0.5 * Math.Pow(x, 2) + Math.Pow(x, 0.5);
        }

        /// <summary>
        /// Вычисление значения производной в точке
        /// </summary>
        /// <param name="x">Точка</param>
        /// <returns>Значение производной</returns>
        public double Derivative(double x)
        {
            return (this.Evaluate(x + dx) - this.Evaluate(x)) / dx;
        }
    }
}
