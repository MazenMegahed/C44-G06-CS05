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

            Console.Write("Enter identity matrix size :  ");
             int.TryParse(Console.ReadLine(),out int x);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (j == i) { Console.Write(1+" "); }
                    else { Console.Write(0 + " "); }
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}
