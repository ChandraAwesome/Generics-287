namespace Generics_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delete Arrray");

            int[] intArray = {1,2,3,4,5};
            double[] doubleArray = { 1.25, 2.25, 3.35, 4.45, 5.55 };
            char[] charArray = { 'a', 'd', 'r', 'y', 'i' };

            Console.WriteLine("Before deletion:");
            Console.WriteLine("Integer array: " + string.Join(", ", intArray));
            Console.WriteLine("Double array: " + string.Join(", ", doubleArray));
            Console.WriteLine("Character array: " + string.Join(", ", charArray));
            /*************** generic *****************************/
            DeleteArray.DeleteMethod(ref intArray, 3);
            DeleteArray.DeleteMethod(ref doubleArray, 2.25);
            DeleteArray.DeleteMethod(ref charArray, 'd');
            /******************** Non Generic ********************/
            DeleteArrayNonGeneric.DeleteMethod1(intArray, 2);
            DeleteArrayNonGeneric.DeleteMethod2(doubleArray, 1.25);
            DeleteArrayNonGeneric.DeleteMethod3(charArray, 'i');
            /*************** Generic Class ****************************/

            DeleteArray<int>.DeleteMethod(ref intArray, 3);
            DeleteArray<double>.DeleteMethod(ref doubleArray, 2.5);
            DeleteArray<char>.DeleteMethod(ref charArray, 'd');


            Console.WriteLine("\nAfter deletion:");
            Console.WriteLine("Integer array: " + string.Join(", ", intArray));
            Console.WriteLine("Double array: " + string.Join(", ", doubleArray));
            Console.WriteLine("Character array: " + string.Join(", ", charArray));

            /****************************************************/
            Console.Write("Minumum Element is ");
            FindMinimum.Minimum(1, 2, 3);
            FindMinimum.Minimum("Ajay", "Chandra", "Awesome");
            FindMinimum.Minimum(2.5f, 5.5f, 6.5f);
            /********* Using IComparable ****************/
            IFindMinimum.IMinimum(4, 5, 6);
            /******** Generic with Constructor ***********/
            FindMinimumwithConstructor<int> MiniInt = new FindMinimumwithConstructor<int>(5, 8, 9);
            int MiniInteger = MiniInt.Minimumvalue();
            Console.WriteLine("The Minimum value is "+MiniInteger);

            FindMinimumwithConstructor<double> MiniDouble = new FindMinimumwithConstructor<double>(5.54, 8.258, 9.654);
            double MiniDoubles = MiniDouble.Minimumvalue();
            Console.WriteLine("The Minimum value is " + MiniDoubles);

            FindMinimumwithConstructor<string> MiniString = new FindMinimumwithConstructor<string>("Ajay","Chandra","Awesome");
            string MiniStr = MiniString.Minimumvalue();
            Console.WriteLine("The Minimum value is " + MiniStr);

        }
    }
}