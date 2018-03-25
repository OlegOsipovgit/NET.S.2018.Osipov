using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynom
{

    public class Polynomial
    {

        double[] coefficients; //массив коэф-ов
        int degree=0; //значение степени полинома
        double eps = double.Epsilon;
        public Polynomial(double[] coef, int degr)
        {
            this.coefficients = coef;
            this.degree = degr;
        }
        /// <summary>
        /// indexator
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public double this[int index]
        {
            get
            {
              return coefficients[index];
            }
        }
        /// <summary>
        /// Addition of polynoms
        /// </summary>
        /// <param name="First"></param>
        /// <param name="Second"></param>
        /// <returns></returns>
        public static Polynomial operator +(Polynomial First, Polynomial Second)
        {
            int degree1 = First.degree;
            double[] sum_coef_array = new double[degree1 + 1];
            Polynomial sum_polynom = new Polynomial(sum_coef_array, degree1);
            for (int i = 0; i < First.degree + 1; i++)
            {
                sum_polynom.coefficients[i] = First.coefficients[i] + Second.coefficients[i];
            }
            return sum_polynom;
        }
        /// <summary>
        /// Substraction of polynoms
        /// </summary>
        /// <param name="First"></param>
        /// <param name="Second"></param>
        /// <returns></returns>
        public static Polynomial operator -(Polynomial First, Polynomial Second)
        {
            int degree1 = First.degree;
            double[] minus_coef_array = new double[degree1 + 1];
            Polynomial minus_polynom = new Polynomial(minus_coef_array, degree1);
            for (int i = 0; i < First.degree + 1; i++)
            {
                minus_polynom.coefficients[i] = First.coefficients[i] - Second.coefficients[i];
            }
            return minus_polynom;
        }
        /// <summary>
        /// Multiplication of polynoms
        /// </summary>
        /// <param name="First"></param>
        /// <param name="Second"></param>
        /// <returns></returns>
        public static Polynomial operator *(Polynomial First, Polynomial Second)
        {
            int degree1 = First.degree;
            double[] multiply_coef_array = new double[degree1 + 1];
            Polynomial multiply_polynom = new Polynomial(multiply_coef_array, degree1);
            for (int i = 0; i < First.degree + 1; i++)
            {
                multiply_polynom.coefficients[i] = First.coefficients[i] * Second.coefficients[i];
            }
            return multiply_polynom;
        }
        /// <summary>
        /// bool comparison of equality of the polynoms
        /// </summary>
        /// <param name="First"></param>
        /// <param name="Second"></param>
        /// <returns></returns>
        public static bool operator ==(Polynomial First, Polynomial Second)
        {
            
            for (int i = 0; i < First.degree + 1; i++)
            {
                if (First.coefficients[i] == Second.coefficients[i]) { continue; }
                else Console.WriteLine("Are not equal");break;
            }
            return true;
        }
        /// <summary>
        /// bool comparison of inequality of the polynoms
        /// </summary>
        /// <param name="First"></param>
        /// <param name="Second"></param>
        /// <returns></returns>
        public static bool operator !=(Polynomial First, Polynomial Second)
        {
               
            for (int i = 0; i < First.degree + 1; i++)
            {
                int sum = 0;
                if (First.coefficients[i] != Second.coefficients[i]) { break; }
                else sum = sum + 1;
                if (sum == First.degree) return false;
                
            }
            return true;
        }
        /// <summary>
        /// ToString overriding
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < coefficients.Length; i++)
            {
                if (i == 0 && Math.Abs(coefficients[i]) > eps)
                {
                    str.AppendFormat($"{coefficients[i]}");
                    continue;
                }

                if (Math.Abs(coefficients[i]) > eps)
                    if (coefficients[i] > 0 && str.Length > 0)
                        str.AppendFormat($" + {coefficients[i]}*x^{i}");
                    else
                        str.AppendFormat($" {coefficients[i]}*x^{i}");
            }

            return str.ToString();
        }
        /// <summary>
        /// Equals overriding
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Polynomial p = obj as Polynomial;

            if ((p!=null) || (p.degree != this.degree))
                return false;

            for (int i = 0; i <= this.degree; i++)
            {
                if (Math.Abs(this[i]-p[i])>eps)
                    return false;
            }

            return true;
        }
       /// <summary>
       /// GetHashCode overriding
       /// </summary>
       /// <returns></returns>
        public override int GetHashCode()
        {
            int hash = 1;
            foreach (var elem in coefficients)
            {
                hash *= (int)elem;
                hash += degree;
            }

            return hash;
        }
    }



   
}