using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practice
{
    internal class FindMinimum
    {
        public static int Minimum(int num1, int num2,int num3)
        {
           

            int min = num1;

            if(num2<min)
            {
                min = num2;
            }
            else if(num3<min)
            {
                min = num3;
            }

            return min;
        }

        public static string Minimum(string str1, string str2,string str3) 
        {
            string min = str1;

            if(string.Compare(str2,min)<0)
            {
                min = str2;
            }
            else if (string.Compare(str3,min)<0) 
            {
                min = str3;
            }

            return min;
        }
        public static float Minimum(float num1, float num2, float num3)
        {
            float min = num1;

            if (num2 < min)
            {
                min = num2;
            }
            else if (num3 < min)
            {
                min = num3;
            }

            return min;
        }
    }

    class IFindMinimum
    {
        public static T IMinimum<T>(T value1, T value2, T value3) where T : IComparable<T>
        {
            T min = value1;

            if(value2.CompareTo(min)<0)
            {
                min= value2;
            }
            else if (value3.CompareTo(min)<0)
            {
                min= value3;
            }

            return min;
        }
    }

}
