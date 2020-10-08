using System;
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
            Console.WriteLine(" Enter email id ");
            string emailId = Console.ReadLine();
            bool checkemailID = userRegistrationDetails.validateEmailID(emailId);
            if (checkemailID == true)
                Console.WriteLine(" EMAIL ID: " + emailId);
            else
            {
                Console.WriteLine(" Please enter valid Email ID ");
                goto RegStart1;
            }
        
        
        }
    }
}
