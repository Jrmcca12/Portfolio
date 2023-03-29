// Exam 2
// CIS 199-01
// Due: 11/9/2020
// By: R2158

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_F20
{
    class Program
    {
        static void Main(string[] args)
        {

            

            string[] counties = { "Jefferson" , "Clark", "Floyd", "Harrison", "Bullitt", "Shelby", "Nelson", "Oldham", "Galatin", "Meade" };

            string[] threats = { "Red", "Orange", "Red", "Orange", "Red", "Orange", "Red", "Orange", "Yellow", "Orange" };




            string county;


            Console.WriteLine("Enter the name of county: ");
            county = Console.ReadLine();

            if (county == "Jefferson")
            {
                Console.WriteLine("The state assessed threat level in {0} county is {1}", counties[0], threats[0]);
            }
            else
            {
                if (county == "Clark")
                {
                    Console.WriteLine("The state assessed threat level in {0} county is {1}", counties[1], threats[1]);
                }
                else
                {
                    if (county == "Floyd")
                    {
                        Console.WriteLine("The state assessed threat level in {0} county is {1}", counties[2], threats[2]);
                    }
                    else
                    {
                        if (county == "Harrison")
                        {
                            Console.WriteLine("The state assessed threat level in {0} county is {1}", counties[3], threats[3]);
                        }
                        else
                        {
                            if (county == "Bullitt")
                            {
                                Console.WriteLine("The state assessed threat level in {0} county is {1}", counties[4], threats[4]);
                            }
                            else
                            {
                                if (county == "Shelby")
                                {
                                    Console.WriteLine("The state assessed threat level in {0} county is {1}", counties[5], threats[5]);
                                }
                                else
                                {
                                    if (county == "Nelson")
                                    {
                                        Console.WriteLine("The state assessed threat level in {0} county is {1}", counties[6], threats[6]);
                                    }
                                    else
                                    {
                                        if (county == "Oldham")
                                        {
                                            Console.WriteLine("The state assessed threat level in {0} county is {1}", counties[7], threats[7]);
                                        }
                                        else
                                        {
                                            if (county == "Galatin")
                                            {
                                                Console.WriteLine("The state assessed threat level in {0} county is {1}", counties[8], threats[8]);
                                            }
                                            else
                                            {
                                                if (county == "Meade")
                                                {
                                                    Console.WriteLine("The state assessed threat level in {0} county is {1}", counties[9], threats[9]);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Sorry, no data for {0} county", county);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.ReadKey(true);

        }
    }
}
