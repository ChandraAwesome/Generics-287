using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practice
{
    internal class DeleteArray
    {
        public static void DeleteMethod<T>(ref T[] arr, T element)
        {
           int  elementIndex = -1;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i].Equals(element))
                {
                    elementIndex = i;
                    break;
                }
            }

            if (elementIndex>=0)
            {
                T[] newArray = new T[arr.Length - 1];
                int newArrayIndex = 0;

                for(int i=0;i<arr.Length;i++)
                {
                    if(i!=newArrayIndex)
                    {
                        newArray[newArrayIndex] = arr[i];
                        newArrayIndex++;
                    }
                }

                arr = newArray;
            }
        }
    }
    class DeleteArray<T>
    {
        public static void DeleteMethod(ref T[] arr, T element)
        {
            int elementIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(element))
                {
                    elementIndex = i;
                    break;
                }
            }

            if (elementIndex >= 0)
            {
                T[] newArray = new T[arr.Length - 1];
                int newArrayIndex = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i != elementIndex)
                    {
                        newArray[newArrayIndex] = arr[i];
                        newArrayIndex++;
                    }
                }

                arr = newArray;
            }
        }
    } 
}
    
