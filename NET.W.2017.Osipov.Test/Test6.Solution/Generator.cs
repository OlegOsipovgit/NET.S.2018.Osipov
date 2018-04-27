using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public class Generator<T>
    {
        public static IEnumerable<T> Generate<T>(int count, T a, T b, T Func(T a1, T b1))
        {
            yield return a;
            yield return b;

            for (int i = 0; i < count; i++)
            {
                T item = b;
                b = Func(a, b);
                yield return b;
                a = item;
            }
        }
    }
}
