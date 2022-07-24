using System;

namespace Chapter9
{
    class l5PasswordVerifier
    {
        public static void Run()
        {
            string usersPassword = "Jjjjf";

            if (l5PasswordVerifier.ValidPassword(usersPassword))
            {
                Console.WriteLine("Your password is valid! ");
            }
            else
            {
                Console.WriteLine("Your password is invalid. Please try again. ");
            }


        }

        public static bool ValidPassword(string password)
        {
            int index = 0;
            int passwLength = 6;
            bool validPassword = false;

            while (index < password.Length)
            {

                if (password.Length >= passwLength && HasUpperCase(password) && HasLowerCase(password) && HasDigit(password))
                {
                    validPassword = true;
                }
                else
                {
                    validPassword = false;
                }
                index++;

            }
            return validPassword;
        }

        public static bool HasUpperCase(string password)
        {
            bool valid = false;
            int index = 0;

            while (index < password.Length)
            {
                if (Char.IsUpper(password[index]))
                {
                    valid = true;

                }
                index++;
            }
            return valid;
        }

        public static bool HasLowerCase(string password)
        {
            bool valid = false;
            int index = 0;

            while (index < password.Length)
            {
                if (Char.IsLower(password[index]))
                {
                    valid = true;
                }
                index++;
            }
            return valid;
        }
        public static bool HasDigit(string password)
        {
            bool valid = false;
            int index = 0;

            while (index < password.Length)
            {
                if (Char.IsDigit(password[index]))
                {
                    valid = true;
                }
                index++;
            }
            return valid;
        }

    }
}