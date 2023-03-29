// Program 4
// CIS 199-01
// Due: 12/01/2020
// By: R2158

// This is a service order form that calculates the cost;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
 
    class Program
    {

        static void Main(string[] args)
        {
            int ZipCode;
            double Length;
            string Model;
            string Serial;
            string Name;
            bool Warranty;
            double Hours;
            double ConvHour = 60;
            double Cost;
            const int cost1 = 25;
            const double cost2 = 1.50;
            const int warTrue = 20;

            

            Console.Write("Service Location Zip Code: ");
            ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Model Number: ");
            Model = Console.ReadLine();
            Console.Write("Serial Number: ");
            Serial = Console.ReadLine();
            Console.Write("Appointment Length: ");
            Length = Convert.ToInt32(Console.ReadLine());

            Hours = Math.Round(Length / ConvHour, 2);
            Console.WriteLine("Appointment Hours: {0}", Hours);
            Console.Write("Technician Name: ");
            Name = Console.ReadLine();
            Console.Write("Warranty Coverage?: ");
            Warranty = Convert.ToBoolean(Console.ReadLine());

            if (Warranty == true)
            {
                Cost = warTrue;
            }
            else
            {
                Cost = cost1 + cost2 * Length;
            }
            Console.WriteLine("Calculate Cost Coverage?: {0}", Cost.ToString("C", CultureInfo.CurrentCulture));


            Console.ReadKey();
        }
    }
}
