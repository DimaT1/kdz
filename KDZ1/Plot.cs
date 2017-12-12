using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace KDZ1
{
    /// <summary>
    /// Класс рисования графиков
    /// </summary>
    class Plot
    {
        /// <summary>
        /// Левая граница расчёта точек
        /// </summary>
        private const double leftBound = 0;
        /// <summary>
        /// Правая граница расчёта точек
        /// </summary>
        private const double rightBound = 4;

        /// <summary>
        /// Цвет на графике
        /// </summary>
        private Color color1, color2, color3;

        /// <summary>
        /// Цвет функции
        /// </summary>
        public Color Color1
        {
            set { color1 = value; }
        }

        /// <summary>
        /// Цвет производной
        /// </summary>
        public Color Color2
        {
            set { color2 = value; }
        }

        /// <summary>
        /// Цвет выделения
        /// </summary>
        public Color Color3
        {
            set { color3 = value; }
        }

        /// <summary>
        /// Выставление цветов по умолчанию
        /// </summary>
        public Plot()
        {
            color1 = Color.IndianRed;
            color2 = Color.LightBlue;
            color3 = Color.Green;
        }

        /// <summary>
        /// Очистка графика
        /// </summary>
        /// <param name="chart">Чертёж</param>
        public void Clear(Chart chart)
        {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
        }

        /// <summary>
        /// Метод построения графика функции
        /// </summary>
        /// <param name="chart">Чертёж</param>
        /// <param name="f">Функция</param>
        /// <param name="highlight">Выделение цветом</param>
        public void Print(Chart chart, MyFunction f, bool highlight = false)
        {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();

            chart.Series[0].Color = color1;
            chart.Series[1].Color = color2;


            for (double x = leftBound; x < rightBound; x += 0.01)
            {
                chart.Series[0].Points.AddXY(x, f.Evaluate(x));
                chart.Series[1].Points.AddXY(x, f.Derivative(x));
            }

            if (highlight)
            {
                for (int i = 0; i < chart.Series[0].Points.Count; i++)
                {
                    if ((chart.Series[0].Points.ElementAt(i).YValues[0] < double.Epsilon) &&
                        (!chart.Series[0].Points.ElementAt(i).IsEmpty))
                    {
                        chart.Series[0].Points.ElementAt(i).Color = color3;
                    }

                    if ((chart.Series[1].Points.ElementAt(i).YValues[0] < -double.Epsilon) &&
                        (!chart.Series[1].Points.ElementAt(i).IsEmpty))
                    {
                        chart.Series[1].Points.ElementAt(i).Color = color3;
                    }
                }
            }              
        }
    }
}
