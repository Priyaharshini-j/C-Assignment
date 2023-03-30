namespace OOPAssignment
{
    //Polymorphism
    /*
            A friend of yours wants to create a special calculator.
            He only wants two operations to be handled by that calculator
            i.e. : addition and subtraction.
            The calculator can only accept either 2 numbers or 3 numbers.

            There are two functionalities for this calculator -
            1. Normal -> in this role - the calculator works normally
             - where upon adding the numbers are added,
                while upon subtracting the numbers are subtracted.

            2. Opposite -> in this role - the calculator works opposite
                to the normal role - where upon adding the numbers are subtracted,
                 while upon subtracting the numbers are added.
            That friend have approached you for the help, in creating
                 such a calculator.
    */

    internal class PolymorphismAssignment
    {
        static void Main1(string[] args)
        {
           SpecialCalculator speCal = new SpecialCalculator();
           NormalCalculator norCal = new NormalCalculator();
            Console.WriteLine("Which one of the calculator do you want to use? \n 1. Special Calculator \n 2. Normal Calculator ");
            int choice = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter the number of Numbers you want to perform the operation");
            int noArg=int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter the numbers");
            int num1, num2, num3 = 0;
            if (noArg == 2)
            {
                num1= int.Parse(Console.ReadLine()!) ;
                num2= int.Parse(Console.ReadLine() !);
            }
            else
            {
                num1 = int.Parse(Console.ReadLine()!);
                num2 = int.Parse(Console.ReadLine() !) ;
                num3 = int.Parse(Console.ReadLine()!);
            }
            if(choice == 1) { 
                if(noArg == 2)
                {
                    Console.WriteLine($"The result of Addition Operation in Special Calculator is: {speCal.AdditionOfNum(num1, num2)}");
                    Console.WriteLine($"The result of Subtraction Operation in Special Calculator is: {speCal.SubtractionOfNum(num1, num2)}"); 
                }
                if (noArg == 3)
                {
                    Console.WriteLine($"The result of Addition Operation in Special Calculator is: {speCal.AdditionOfNum(num1, num2,num3)}");
                    Console.WriteLine($"The result of Subtraction Operation in Special Calculator is: {speCal.SubtractionOfNum(num1, num2,num3)}");
                }
            }
            if (choice == 2)
            {
                if (noArg == 2)
                {
                    Console.WriteLine($"The result of Addition Operation in Special Calculator is: {norCal.AdditionOfNum(num1, num2)}");
                    Console.WriteLine($"The result of Subtraction Operation in Special Calculator is: {norCal.SubtractionOfNum(num1, num2)}");
                }
                if (noArg == 3)
                {
                    Console.WriteLine($"The result of Addition Operation in Special Calculator is: {norCal.AdditionOfNum(num1, num2, num3)}");
                    Console.WriteLine($"The result of Subtraction Operation in Special Calculator is: {norCal.SubtractionOfNum(num1, num2, num3)}");
                }
            }
        }
    }

    internal class NormalCalculator
    {
        public virtual int AdditionOfNum(int num1, int num2)
        {
            return num1 + num2;
        }

        public virtual int AdditionOfNum(int num1, int num2, int num3)
        {
            return num1 + num2+ num3;
        }

        public virtual int SubtractionOfNum(int num1, int num2)
        {
             return num1 - num2;
        }

        public virtual int SubtractionOfNum(int num1, int num2, int num3)
        {
            return num1 - num2 - num3;
        }

    }

    internal class SpecialCalculator : NormalCalculator
    {
        public override int SubtractionOfNum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public override int SubtractionOfNum(int num1, int num2)
        {
            return num1 + num2;
        }
        public override int AdditionOfNum(int num1, int num2, int num3)
        {
            return num1 - num2 - num3;
        }
        public override int AdditionOfNum(int num1, int num2)
        {
            return num1 - num2 ;
        }
    }
}
