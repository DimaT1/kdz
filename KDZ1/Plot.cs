using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace KDZ1
{
    class Plot
    {
         

        public static void Print(Chart chart, MyFunction f)
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
