namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# Sharp to separate odd and even integers in separate arrays


            Console.WriteLine("Enter the number of elements");
            int l=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[l];
            int even = 0;
            int odd = 0;
            for (int i = 0; i < l; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
                if (arr[i]%2 == 0) { even++; }
                else { odd++; }
            }
            int[] even_arr = new int[even];
            int[] odd_arr= new int[odd];
            int c=0, c1 = 0;
            foreach(int j in arr) { 
                
                if (j%2 == 0){
                    even_arr[c] = j;
                    c++;
                }
                else
                {

                    odd_arr[c1] = j;
                    c1++;
                }
            }
            Console.WriteLine("Even Array");
            PrintArray(even_arr,even);
            Console.WriteLine("Odd Array");
            PrintArray(odd_arr,odd);

        }
        public static void PrintArray(int[] array,int l)
        {
            for(int i = 0; i < l; i++) { Console.WriteLine(array[i]); }
        }
    }
}
