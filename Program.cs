﻿using System;
using System.Data.SqlTypes;

namespace User_Registration_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to User Registration Problem ");
            User_Registration_Details userRegistrationDetails = new User_Registration_Details();
        RegStart1:
            Console.WriteLine(" Enter the first name(starting with capital and minimum 3 letters) ");
            string firstName = Console.ReadLine();
            bool checkFirstName = userRegistrationDetails.validateFirstName(firstName);
            if (checkFirstName == true)
                Console.WriteLine(" FIRST NAME: " + firstName);
            else
            {
                Console.WriteLine(" Please enter valid first name ");
                goto RegStart1;
            }
        RegStart2:
            Console.WriteLine(" Enter the last name(starting with capital and minimum 3 letters) ");
            string lastName = Console.ReadLine();
            bool checkLastName = userRegistrationDetails.validateLastName(lastName);
            if (checkLastName == true)
                Console.WriteLine(" LAST NAME: " + lastName);
            else
            {
                Console.WriteLine(" Please enter valid last name ");
                goto RegStart2;
            }
        RegStart3:
            Console.WriteLine(" Enter email id ");
            string emailId = Console.ReadLine();
            bool checkemailID = userRegistrationDetails.validateEmailID(emailId);
            if (checkemailID == true)
                Console.WriteLine(" EMAIL ID: " + emailId);
            else
            {
                Console.WriteLine(" Please enter valid Email ID ");
                goto RegStart3;
            }
        RegStart4:
            Console.WriteLine(" Enter mobile number ");
            string phoneNo = Console.ReadLine();
            bool checkPhoneNo = userRegistrationDetails.validatePhoneNo(phoneNo);
            if (checkPhoneNo == true)
                Console.WriteLine(" PHONE NUMBER: " + phoneNo);
            else
            {
                Console.WriteLine(" Please enter valid Phone Number ");
                goto RegStart4;
            }
        RegStart5:
            Console.WriteLine(" Enter Password ");
            Console.WriteLine(" Password Rules: ");
            Console.WriteLine("*Minimum 8 characters ");
            Console.WriteLine("*Should Have at least 1 UpperCase Letter ");
            Console.WriteLine("*Should Have at least 1 digit ");
            Console.WriteLine("*Should Have exactly 1 special character ");
            string password = Console.ReadLine();
            bool checkPassword4 = userRegistrationDetails.validatePasswordRule4(password);
            if (checkPassword4==true)
            {
                Console.WriteLine(" PASSWORD: " + password);
            }
            else
            {
                Console.WriteLine(" Enter valid password ");
                goto RegStart5;
            }
        }
    }
}
