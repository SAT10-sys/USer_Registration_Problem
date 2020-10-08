using System;

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
        }
    }
}
