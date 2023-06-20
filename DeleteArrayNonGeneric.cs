using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practice
{
    internal class DeleteArrayNonGeneric
    {
        public static void DeleteMethod1(int[] arr, int element)
        {
            int elementindex = -1;
            for(int i=0;i<arr.Length-1;i++)
            {
                if (arr[i].Equals(element)) 
                {
                    elementindex= i;
                    break;
                }
            }

            if(elementindex>=0)
            {
                int[] newArray = new int[arr.Length-1];
                int newArrayindex = 0;

                for(int i=0;i<arr.Length;i++)
                {
                    if(i!=element)
                    {
                        newArray[newArrayindex] = arr[i];
                        newArrayindex++;
                    }
                }

                arr = newArray;
            }
        }

        public static void DeleteMethod2(double[] arr, double element) 
        {
            int elementindex = -1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].Equals(element))
                {
                    elementindex = i;
                    break;
                }
            }

            if (elementindex >= 0)
            {
                double[] newArray = new double[arr.Length - 1];
                int newArrayindex = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i != element)
                    {
                        newArray[newArrayindex] = arr[i];
                        newArrayindex++;
                    }
                }

                arr = newArray;
            }
        }

        public static void DeleteMethod3(char[] arr, char element)
        {
            int elementindex = -1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].Equals(element))
                {
                    elementindex = i;
                    break;
                }
            }

            if (elementindex >= 0)
            {
                char[] newArray = new char[arr.Length - 1];
                int newArrayindex = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i != element)
                    {
                        newArray[newArrayindex] = arr[i];
                        newArrayindex++;
                    }
                }

                arr = newArray;
            }
        }
    }
}
