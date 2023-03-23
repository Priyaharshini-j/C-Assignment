namespace DuplicateElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# Sharp to count a total number of duplicate elements in an array.
            Console.WriteLine("Enter the length of an Array");
            int len=Convert.ToInt32(Console.ReadLine());
            int[] arr= new int[len];
            Console.WriteLine("Enter the Element of an Array");
            for (int i = 0;i< len; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine()); 
            }
            int c = 0;
            Array.Sort(arr);
            for(int i = 0;i< len-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    c++;
                }
            }
            Console.WriteLine("The Number of Duplicate Elements are "+c);
        }
    }
}
