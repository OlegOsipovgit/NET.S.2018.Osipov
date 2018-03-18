using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RootNewton
{
    public class NewtonMethodClass
    {
       
        public static double Newton(double A, double n, double eps)
            
            
        {

            ///<summary>
            ///set the initial approximation x0 and initialize the x1. 
            ///That value will be the next step in our
            ///iteration method.
            /// </summary>
           
            double x0 = A / n;
            double x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, n - 1));
           ///Iteration process of calculating x1 by Newton Method while will not reaching of epsilon(eps) accuracy:
                while (Math.Abs(x1 - x0) > eps)
                {
                    x0 = x1;
                    x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, n - 1));
                }

            if ((Math.Abs(x1-x0)>eps)||(eps<0))
            throw new ArgumentOutOfRangeException();
            return Math.Round(x1, 3);
            
            
        }
    }
}
