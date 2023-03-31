using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProg
{
    public class OverTimeWage
    {
        /*
         * Working 9 to 5
                Write a function that calculates overtime and pay associated with overtime.

                Working 9 to 5: regular hours
                After 5pm is overtime
                Your function gets an array with 4 values:

                Start of working day, in decimal format, (24-hour day notation)
                End of working day. (Same format)
                Hourly rate
                Overtime multiplier
                Your function should spit out:

                $ + earned that day (rounded to the nearest hundreth)
                Examples
                OverTime([9, 17, 30, 1.5]) ➞ "$240.00"

                OverTime([16, 18, 30, 1.8]) ➞ "$84.00"

                OverTime([13.25, 15, 30, 1.5]) ➞ "$52.50"
                2nd example explained:

                From 16 to 17 is regular, so 1 * 30 = 30
                From 17 to 18 is overtime, so 1 * 30 * 1.8 = 54
                30 + 54 = $84.00
         */
        public static double OverTime(double[] arr)
        {
            double startTime = arr[0];
            double endTime = arr[1];
            double hourlyRate = arr[2];
            double overtimeRate = arr[3];
            //In order to calculate the hours they have worked
            double regular_hours = Math.Min(endTime, 17) - Math.Max(startTime, 9);
            //In order to calculate the over time they worked we have to subtract the default regular hours with the hours they worked
            //As we know the hours past 5 pm is overtime we are subtracting it with 17
            double overtime_hours = Math.Max(endTime - 17, 0);
            //The regular pay will be calculated by multiplying with hourlyRate
            double regularPay = regular_hours * hourlyRate;
            //To calculate overtime we need to make use of overtime Rate
            double overtimePay = overtime_hours * hourlyRate * overtimeRate;

            double total_pay = Math.Round(regularPay + overtimePay, 2);

            return total_pay;
        }

        static void Main(string[] args)
        {
            double[] arr = new double[4];
            Console.WriteLine("Enter the Start Time in 24 hr Format:");
            arr[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the End Time in 24 hr Format:");
            arr[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Hourly Wage Rate");
            arr[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Overtime wage Rate");
            arr[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"$ {OverTime(arr)}");
        }
    }

}
