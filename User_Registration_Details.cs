using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Problem
{
    class User_Registration_Details
    {
        public static string REGEX_NAME = "^[A-Z]{1,}[A-Za-z]{2,}$";
        public static string REGEX_EMAIL_ID = "[a-zA-Z0-9]{3,}[.]?[a-zA-Z0-9]{0,}@[a-z]{2,}[.][a-z]{2,}[a-z]{0,}";
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_NAME);
        }
        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_NAME);
        }
        public bool validateEmailID(string emailId)
        {
            return Regex.IsMatch(emailId, REGEX_EMAIL_ID);
        }
    }
}
