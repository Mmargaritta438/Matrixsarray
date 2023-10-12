using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /*
     * Зубчатые массивы
     */

    class Matrix
    {
        static void Main(string[] args)
        {
            /*int[] arr = new int[10];*/



            int[][] myArray = new int[6][];
            myArray[0] = new int[5];
            myArray[1] = new int[7];
            myArray[2] = new int[6];
            myArray[3] = new int[9];
            myArray[4] = new int[7];
            myArray[5] = new int[10];


            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
            }
            Console.WriteLine();



            /*myArray[0][3] = 77;

            int[] arr = myArray[0];
            
            
            Console.WriteLine(myArray[0][3]);*/

            /*int[,] myArray2 = new int [3,5];

            int myArrayRank = myArray.Rank;
            int myArray2Rank = myArray2.Rank;

            int myArrayLength = myArray.Length;
            int myArray2Length = myArray2.Length;*/
        }
    }
}
