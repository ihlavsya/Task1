using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        protected bool CheckIfNegative(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("The input values cannot be non-positive");
            }
            return true;
        }
    }
}
