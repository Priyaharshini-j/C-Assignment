using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFunc
{
    internal class MirrorImage
    {
        public static void rotateMatrix(int[,] image, int row, int col)
        {
            int[,] resultantImage = new int[row, col];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    resultantImage[i, j] = image[(row - 1) - j, i];
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($" {resultantImage[i, j]} ");
                }
                Console.WriteLine("\n");
            }
        }
        public static void Main(string[] args)
        {
            int[,] Matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            rotateMatrix(Matrix, 3, 3);
            ImagingMatrix(Matrix, 3, 3);
        }

        public static void ImagingMatrix(int[,] matrix, int row, int column) {
            for(int j= 0; j < column; j++)
            {
                for(int i= row-1; i>=0; i--)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
        }


    }
}
