using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Solution
{
    public class Mean:IAverage
    {
        public double Average(List<double> list)
        {
            return list.Sum() / list.Count;
        }
    }
}
