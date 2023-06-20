using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practice
{
    internal class FindMinimumwithConstructor<T> where T : IComparable<T>
    {
        private T value1;
        private T value2;
        private T value3;
        public FindMinimumwithConstructor(T value1, T value2, T value3) 
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }

        public T Minimumvalue()
        {
            return GetMinimum(value1,value2, value3);
        }

        private static T GetMinimum( T val1, T val2, T val3 ) 
        {
            T min = val1;

            if(val2.CompareTo( val2 ) < 0) 
            {
                min = val2;
            }
            else if (val3.CompareTo(val3)<0)
            {
                min = val3;
            }

            return min;
        }
    }
}
