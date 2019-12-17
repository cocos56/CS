using System;
using System.Text.RegularExpressions;

namespace mostone
{
    public class StringRegular
    {
        public const int ALLNUM = 0;
        public const int ISBOOL = 1;
        public const int ISFLOAT = 2;
        public const int PASSWORD = 3;

        public static bool RegularChecker(string trainee, int RULE)
        {
            switch (RULE)
            {
                case ALLNUM: return AllNumsRegular(trainee); 
                case ISBOOL: return IsBoolRegular(trainee);
                case ISFLOAT: return IsFloatRegular(trainee);
                case PASSWORD: return PasswordRegular(trainee);
            }
            return false;
        }

        public static bool AllNumsRegular(string trainee)
        {
            return Regex.IsMatch(trainee, "^[0-9]+$");
        }

        public static bool IsBoolRegular(string trainee)
        {
            return Regex.IsMatch(trainee, "^[Y|N|y|n]$");
        }

        public static bool IsFloatRegular(string trainee)
        {
            return Regex.IsMatch(trainee, "^[0-9]+.[0-9]+$");
        }

        public static bool PasswordRegular(string trainee)
        {
            bool result = true;

            if (!Regex.IsMatch(trainee, "[0-9]")
                 || !Regex.IsMatch(trainee, "[a-z]")
                 || !Regex.IsMatch(trainee, "[A-Z]"))
            {
                result = false;
            }

            return result;
        }
    }
}
