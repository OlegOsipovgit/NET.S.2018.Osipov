using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RootNewton
{
    public class NewtonMethodClass
    {

       /// <summary>
       /// Newton method where Number is our desired number for its root calculating. 
       /// Degree is our degree of root.Epsilon is our satisfying inaccuracy of solution 
       /// </summary>
       /// <param name="Number"></param>
       /// <param name="degree"></param>
       /// <param name="epsilon"></param>
       /// <returns></returns>
        public static double Newton(double Number, double degree, double epsilon)
            
        {
            double step = 0;
            if (Math.Abs(epsilon)>1)
                throw new ArgumentOutOfRangeException();
            if ((Number < 0) && (degree % 10 == 0))
                throw new ArgumentOutOfRangeException();
            double InitialAproximation = Number / degree;
            double NextStep = (1 / degree) * ((degree - 1) * InitialAproximation + Number / Math.Pow(InitialAproximation, degree - 1));
                while (Math.Abs(NextStep - InitialAproximation) > epsilon)
                {
                    InitialAproximation = NextStep;
                    NextStep = (1 / degree) * ((degree - 1) * InitialAproximation + Number / Math.Pow(InitialAproximation, degree - 1));

                
                step = Math.Abs(NextStep - InitialAproximation);
                }


            if ((Math.Abs(NextStep - InitialAproximation) > epsilon)||(epsilon < 0))
            throw new ArgumentOutOfRangeException();
            return NextStep;
                     
        }
    }
}
