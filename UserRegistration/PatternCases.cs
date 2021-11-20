using System.Text.RegularExpressions;
namespace UserRegistration
{
    public class PatternCheck
    {
        public const string patternForFName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string patternForLName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string patternForEmail = "^[a-z]{3,}([$#@!%?&*._-]?[a-z]+)?[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}([.]?[a-z]+)?$";
        public const string patternForPhoneNo = "^[1-9]{2}\\s[6-9]{1}[0-9]{9}$";
        public const string patternForPassword = "^[A-Za-z0-9!@#$%^&*_-]{8,}$";
        public const string patternForPwd = "[A-Z]{1,}[A-Za-z0-9!@#$%^&*_-]{7,}$";
        public const string patternForPasWd = "[A-Z]{1,}[0-9]{1,}[A-Za-z0-9!@#$%^&*_-]{6,}$";
        public const string patternForPaswd = "[A-Z]{1,}[0-9]{1,}[!@#$%^&*_-]{1,}[A-Za-z0-9!@#$%^&*_-]{5,}$";
        public const string patternForAllEmail = "^[a-z]{3,}([!@#$%^+&*._-]?[0-9]+)?[@]{1}[0-9a-z]{1,}[.]{1}[a-z]{2,}([.]?[a-z]+)?$";

        public bool FirstNameValidation(string FirstName)
        {
            return Regex.IsMatch(FirstName, patternForFName);
        }
        public bool LastNameValidation(string LastName)
        {
            return Regex.IsMatch(LastName, patternForLName);
        }
        public bool EmailValidation(string Email)
        {
            return Regex.IsMatch(Email, patternForEmail);
        }
        public bool PhoneNoValidation(string PhoneNo)
        {
            return Regex.IsMatch(PhoneNo, patternForPhoneNo);
        }
        public bool UC_5_PasswordValidation(string Password)
        {
            return Regex.IsMatch(Password, patternForPassword);
        }
        public bool UC_6_PasswordValidation(string Password)
        {
            return Regex.IsMatch(Password, patternForPwd);
        }
        public bool UC_7_PasswordValidation(string Password)
        {
            return Regex.IsMatch(Password, patternForPasWd);
        }
        public bool UC_8_PasswordValidation(string Password)
        {
            return Regex.IsMatch(Password, patternForPaswd);
        }
        public bool allEmailValidation(string Email)
        {
            return Regex.IsMatch(Email, patternForAllEmail);
        }
    }
}