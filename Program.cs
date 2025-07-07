using System.ComponentModel;
using System.Drawing;

namespace Session5_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1- . Write a program that prints an identity matrix using for loop, in other
            //  words takes a value n from the user and shows the identity table of size n *n.

            //Console.Write("Enter identity matrix size :  ");
            // int.TryParse(Console.ReadLine(),out int x);
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < x; j++)
            //    {
            //        if (j == i) { Console.Write(1+" "); }
            //        else { Console.Write(0 + " "); }
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q2
            //Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum=0;
            //for (int i = 0; i < nums.Length; i++) 
            //{
            //    sum+= nums[i];
            //}
            //Console.WriteLine($"Summation = {sum}");
            #endregion

            #region Q3
            //Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] array1 = { 5,7,6};
            //int[] array2 = { 11,2,4 };

            //int[] mergedarray =new int[array1.GetLength(0)];
            //for (int i = 0; i < array1.GetLength(0); i++) 
            //{
            //    mergedarray[i] = array1[i] + array2[i];

            //}
            //Array.Sort(mergedarray);
            //for (int i = 0; i < array1.GetLength(0); i++)
            //{

            //        Console.Write( mergedarray[i]+" ") ;


            //}

            #endregion

            #region Q4
            //Write a program in C# Sharp to find maximum and minimum element in an array = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };
            int[] array = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };
            int max = array[0]; int min = array[0];
            for (int i = 1; i < array.Length; i++)
            { 
                if(array[i] > max) {  max=array[i];}
            else if (array[i] < min) { min=array[i];}

            }
            Console.WriteLine($"Maximum = {max} , Minimum = {min}");
            #endregion
        }
    }
}
