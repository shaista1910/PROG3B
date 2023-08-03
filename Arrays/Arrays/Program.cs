using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region firstArray
            //create array using initial values

            int[,] ar = new int[2, 3] { { 2, 4, 6 }, { 8, 10, 12 } };
            DisplayElements(ar);
            //Display all elements in the array


            //Print 4
            //0=row, 1=index
            Console.WriteLine("------------------------");
            Console.WriteLine(ar[0,1]);
            //Print 8
            Console.WriteLine(ar[1,0]);
            #endregion

            #region secondArray
            //Create 2D Array and add own values manually
            int[,] ar2 = new int[2, 4];

            // Manually add values to the array
            ar2[0, 0] = 6;
            ar2[0, 1] = 7;
            ar2[0, 2] = 8;
            ar2[0, 3] = 10;

            ar2[1, 0] = 18;
            ar2[1, 1] = 47;
            ar2[1, 2] = 15;
            ar2[1, 3] = 12;

            // Display all elements in the array
            Console.WriteLine("======Second Array======");
            DisplayElements(ar2);

            #endregion

            #region thirdArray
            //Assign values 1,2,3,4 - first row, 5,6,7,8 - second row, 9,10,11,12 - third row, 13,14,15,16 - fourth row. 
            //using for loop

            //Another way to do it.
            //int[,] ar3 = new int[4, 4];

            //int counter = 1;

            // Assign values to the array using nested for loops 
            //for (int i = 0; i < ar3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ar3.GetLength(1); j++)
            //    {
            //        ar3[i, j] = counter++;
            //    }
            //}


            int[,] ar3 = new int[4, 4];

            int number = 0; ;

            for (int row = 0; row < ar3.GetLength(0); row++)
            {
                for (int column = 0; column < ar3.GetLength(1); column++)
                {
                    number++;
                    ar3[row, column] = number;
                }
            }

            // Display all elements in the array
            Console.WriteLine("======Third Array======");
            DisplayElements(ar3);


            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        Console.Write(myArray[i, j] + " ");
            //    }
            //    Console.WriteLine(); // Move to the next line after each row
            //}

            #endregion

            Console.Read();

        }


        //Document Methods
        /// <summary>
        /// A method to display elements of a multidimensional array.
        /// </summary>
        /// <param name="ar">Multidemsional Array</param>
        static void DisplayElements(int[,]ar)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.Write(ar[i, j] + " ");
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}
        





