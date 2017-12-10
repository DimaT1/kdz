using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZ1
{
    class MyFunction
    {
        private int a;
        public int A
        {
            set { a = value; }
        }

        private double dx = 0.01;
        public double DeltaX
        {
            set { dx = value; }
        }

        public MyFunction(int _a, double _dx)
        {
            a = _a;
            dx = _dx;
        }

        public double Evaluate(double x)
        {
            return 1.0 * a * Math.Pow(x, 3) - 0.5 * Math.Pow(x, 2) + Math.Pow(x, 0.5);
        }

        public double Derivative(double x)
        {
            return (this.Evaluate(x + dx) - this.Evaluate(x)) / dx;
        }
    }
}
