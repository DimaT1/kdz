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
            color1 = Color.Blue;
            color2 = Color.Yellow;
            color3 = Color.Red;
        }


        public void Print(Chart chart, MyFunction f, bool highlight = false)
        {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();


            for (double x = 0; x < 4; x += 0.01)
            {
                chart.Series[0].Points.AddXY(x, f.Evaluate(x));
                chart.Series[1].Points.AddXY(x, f.Derivative(x));
            }
        }
    }
}
