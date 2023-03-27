namespace Assignment2
{
    internal class SpiralMatrix
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1,2,3},
            {4,5,6 },
            {7,8,9 }};
            //int[,] a= { { 1, 2, 3, 4 },  { 5, 6, 7, 8 }, { 9, 10, 11, 12 },{ 13, 14, 15, 16 } };
            //m=4;
            //n=4;
            int i = 0, row = 0, column = 0;
            int m = 3;
            int n = 3;
            while(row < m && column < n) 
            {
                for (i = row; i < n; ++i)
                {
                    Console.Write(a[row, i] + " ");// This is Helpful in retriving the first row elements of the mxn Matrix
                }
                //After first row retrival we go for next rows... In here we will be
                row++;

                // As for printing the last element of next cycle 
                for (i = row; i < m; ++i)
                {
                    Console.Write(a[i, n - 1] + " ");
                }

                // we are reducing the total column of matrix in order to retive the next cycle columnsin in the matrix
                n--;


                if (row < m) // now the reteiving row is indicated as 2<3
                {
                    for (i = n - 1; i >= column; --i)// now for accessing the last row elements we go for this 
                    {
                        Console.Write(a[m - 1, i] + " ");// for printing the last row elements
                    }
                    //reducing the total row for next cycle
                    m--;
                    
                }
                if (column < n){
                    for (i = m - 1; i >= row; --i)
                    {
                        Console.Write(a[i, column] + " ");
                    }
                    column++;
                }
            }
        }
    }
}
