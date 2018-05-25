using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, IAverage averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return averagingMethod.Average(values);
              
        }
    }
}
