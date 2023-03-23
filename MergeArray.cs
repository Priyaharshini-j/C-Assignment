namespace MergeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.
            int[] a1= {1,2,3,4,5};
            int[] a2 = { 3, 7, 1, 3, 8 };
            int[] a3 = new int[a2.Length * 2];
            int j = 0;
            for(int i=0;i<a1.Length;i++)
            {
               
                    a3[j]=a1[i];
                    a3[j + 1] = a2[i];
                    j = j + 2;
            }
            Array.Sort(a3);
            foreach(int i in a3) { 
                Console.WriteLine(i);
            }
        }
    }
}
