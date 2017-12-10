using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace KDZ1
{
    class Plot
    {
        private Color color1, color2, color3;
        public Color Color1
        {
            set { color1 = value; }
        }
        public Color Color2
        {
            set { color2 = value; }
        }
        public Color Color3
        {
            set { color3 = value; }
        }


        public Plot()
        {
            color1 = Color.IndianRed;
            color2 = Color.LightBlue;
            color3 = Color.Green;
        }

        public void Clear(Chart chart)
        {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
        }


        public void Print(Chart chart, MyFunction f, bool highlight = false)
        {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();

            chart.Series[0].Color = color1;
            chart.Series[1].Color = color2;


            for (double x = 0; x < 4; x += 0.01)
            {
                chart.Series[0].Points.AddXY(x, f.Evaluate(x));
                chart.Series[1].Points.AddXY(x, f.Derivative(x));
            }

            if (highlight)
            {
                for (int i = 0; i < chart.Series[0].Points.Count; i++)
                {
                    if ((chart.Series[0].Points.ElementAt(i).YValues[0] < double.Epsilon) && (!chart.Series[0].Points.ElementAt(i).IsEmpty))
                    {
                        chart.Series[0].Points.ElementAt(i).Color = color3;
                    }

                    if ((chart.Series[1].Points.ElementAt(i).YValues[0] < -double.Epsilon) && (!chart.Series[1].Points.ElementAt(i).IsEmpty))
                    {
                        chart.Series[1].Points.ElementAt(i).Color = color3;
                    }
                }
            }              
        }
    }
}
