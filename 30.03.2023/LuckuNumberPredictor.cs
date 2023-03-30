using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPAssignment
{

   //Abstraction
   /*A company XYZ wants to develop an app which can predict the
    lucky number for a person.
    The name of the app is LuckyNumberPredictor.
    This app consists of a method - upon calling the person gets to know his/her lucky number.
    This method calls another class —> NumberPredictor - which have the formula for
    predicting the lucky number of that person.This approach is done so that no-one else gets
    to know the secret formula for this prediction.

    LuckyNumberPredictor accepts only one argument i.e: date of birth of the person. The formula
    for predicting the lucky number is quite simple -> a person’s lucky number is calculated by rounding
    off the date of birth to the nearest Fibonacci number.
    Another thought that XYZ company is  having - is to predict unlucky number as well - but for this — for now, 
    they don’t have any formula ready.But they want to have this idea to be stored in - in their NumberPredictor class. 
    The company is asking you to develop this system.
   */
    class LuckyNumberPredictor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To know your Lucky Number please Enter your Date of Birth as in (Date) ");
            int dateOfbirth=Convert.ToInt32(Console.ReadLine());
            LuckNumberCalculation luck=new LuckNumberCalculation();
            luck.LuckyNumberFormula(dateOfbirth);

        }
    }
    abstract class NumberPredictor
    {
        public abstract void LuckyNumberFormula(int dateOfbirth);
    }

    class LuckNumberCalculation:NumberPredictor
    {
        public override void LuckyNumberFormula(int dateOfbirth)
        {

            if (dateOfbirth == 0)
            {
                Console.WriteLine("You have entered your birthday as 0");
                return;
            }
            int firstNo = 0;
            int secondNo = 1;
            int thirdNo = firstNo + secondNo;
            while (dateOfbirth >= thirdNo)
            {
                firstNo = secondNo;
                secondNo = thirdNo;
                thirdNo = firstNo + secondNo;
            }

            int luckNumber= (Math.Abs(thirdNo - dateOfbirth) >= (Math.Abs(secondNo - dateOfbirth))) ? secondNo : thirdNo;
            Console.WriteLine($"Your Luck number is {luckNumber}");
        }
    }

}
