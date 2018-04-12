using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearcher
{
    public static class Searcher
    {
        public static int Search<T>(T element, T[] array,IComparer<T> comparer)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException(nameof(array));
            }
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            int bottom = 0;
            int top = array.Length - 1;
            while (bottom <= top)
            {

                int mid = bottom + (top - bottom) / 2;
                if (comparer.Compare(element,array[mid])>0) top = mid - 1;
                else if (comparer.Compare(element, array[mid])<0) bottom = mid + 1;
                else return mid;
            }
            return -1;
        }
}
