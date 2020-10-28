using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1
{
    class Program
    {
       static void Main(string[] args)
        {
            //Asking for ssn
            Console.Write("Enter your social security number: ");
            string ssn = Console.ReadLine();

           //Calling function to perfrom all checks on entered ssn
            Validatessn(ssn);
            Console.ReadKey();
        }
        //Function which perform all the checks on entered ssn
        static void Validatessn(string ssn)
        {
            
            if(ssn.Length == 12)//Checking the length of ssn
            {
                //Extracting different values from ssn
                int year = Convert.ToInt32(ssn.Substring(0, 4));
                int month = Convert.ToInt32(ssn.Substring(4, 2));
                int day = Convert.ToInt32(ssn.Substring(6, 2));
                int birthnumber = Convert.ToInt32(ssn.Substring(8, 3));
                int gendernumber = Convert.ToInt32(ssn.Substring(10, 1));

                if (year >= 1753 && year <= 2020)//Checking if the year is valid
                {
                    if (month >= 1 && month <= 12)//Checking if the month is valid
                    {
                        if(day <= DateTime.DaysInMonth(year, month) && day > 0)//Checking if the day is valid
                        {
                            if (birthnumber >= 000 && birthnumber <= 900)
                            {
                                //Find the gender from ssn
                                string gender = (gendernumber % 2) == 0 ? "Female" : "Male";
                                //Printing the output of gender
                                Console.WriteLine("The ssn " + ssn + " is correct");
                                Console.WriteLine("Gender: " + gender);
                                
                            }
                            else
                            {
                                //Printing error if the birth number is incorrect
                                Console.WriteLine("Birth number must be between 000 to 999.");
                            }
                        }
                        else
                        {
                            //Printing error if the day is incorrect
                            Console.WriteLine("Day must be valid according to the year and month entered.");
                        }
                    }
                    else
                    {
                        //Printing error if the month is incorrect
                        Console.WriteLine("Months must be between 1 to 12");
                    }
                }
                else
                {
                    //Printing error if the year is incorrect
                    Console.WriteLine("Year must be between 1753 to 2020");
                }

            }
            else
            {
                //Printing error if the length is incorrect
                Console.WriteLine("The length of SSN must be 12");
            }
            Console.ReadKey();
        }
    }
}
