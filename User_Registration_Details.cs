using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Problem
{
    class User_Registration_Details
    {
        public static string REGEX_NAME = "^[A-Z]{1,}[A-Za-z]{2,}$";
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_NAME);
        }
    }
}
