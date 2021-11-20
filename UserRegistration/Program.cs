using System;
using System.Collections.Generic;
namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 19 Program\n");
            Console.WriteLine("Please selct following options\n");
            Console.WriteLine(" 1.UC_1\n 2.UC_2\n 3.UC_3\n 4.UC_4\n 5.UC_5\n 6.UC_6\n 7.UC_7\n 8.UC_8\n 9.UC_9\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PatternCheck FName = new PatternCheck();
                    Console.WriteLine("Please enter fisrt name");
                    string FirstName = Console.ReadLine();
                    FName.FirstNameValidation(FirstName);
                    Console.WriteLine(FName.FirstNameValidation(FirstName));
                    break;
                case 2:
                    PatternCheck LName = new PatternCheck();
                    Console.WriteLine("Please enter last name");
                    string LastName = Console.ReadLine();
                    LName.LastNameValidation(LastName);
                    Console.WriteLine(LName.LastNameValidation(LastName));
                    break;
                case 3:
                    PatternCheck Email = new PatternCheck();
                    Console.WriteLine("Please enter your email");
                    string email = Console.ReadLine();
                    Email.EmailValidation(email);
                    Console.WriteLine(Email.EmailValidation(email));
                    break;
                case 4:
                    PatternCheck Phone = new PatternCheck();
                    Console.WriteLine("Please enter your phone number with country code");
                    string phoneNo = Console.ReadLine();
                    Phone.PhoneNoValidation(phoneNo);
                    Console.WriteLine(Phone.PhoneNoValidation(phoneNo));
                    break;
                case 5:
                    PatternCheck PassWord = new PatternCheck();
                    Console.WriteLine("Please enter your password");
                    string passWord = Console.ReadLine();
                    PassWord.UC_5_PasswordValidation(passWord);
                    Console.WriteLine(PassWord.UC_5_PasswordValidation(passWord));
                    break;
                case 6:
                    PatternCheck Pwd = new PatternCheck();
                    Console.WriteLine("Please enter your password");
                    string Pswd = Console.ReadLine();
                    Pwd.UC_6_PasswordValidation(Pswd);
                    Console.WriteLine(Pwd.UC_6_PasswordValidation(Pswd));
                    break;
                case 7:
                    PatternCheck PasWd = new PatternCheck();
                    Console.WriteLine("Please enter your password");
                    string PaWd = Console.ReadLine();
                    PasWd.UC_7_PasswordValidation(PaWd);
                    Console.WriteLine(PasWd.UC_7_PasswordValidation(PaWd));
                    break;
                case 8:
                    PatternCheck Paswd = new PatternCheck();
                    Console.WriteLine("Please enter your password");
                    string PassWd = Console.ReadLine();
                    Paswd.UC_8_PasswordValidation(PassWd);
                    Console.WriteLine(Paswd.UC_8_PasswordValidation(PassWd));
                    break;
                case 9:
                    PatternCheck EmailRegex = new PatternCheck();
                    List<string> sampleEmailList = new List<string>()
                    {
                        "abc@yahoo.com",
                        "abc-100@yahoo.com",
                        "abc.100@yahoo.com",
                        "abc111@abc.com",
                        "abc-100@abc.net",
                        "abc.100@abc.com.au",
                        "abc@1.com",
                        "abc@gmail.com.com",
                        "abc+100@gmail.com"
                    };

                    foreach (string item in sampleEmailList)
                    {
                        if (EmailRegex.EmailValidation(item))
                            if (EmailRegex.allEmailValidation(item))
                            {
                                Console.WriteLine(EmailRegex.EmailValidation(item));
                                Console.WriteLine(EmailRegex.allEmailValidation(item));
                                Console.WriteLine("Valid Email");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Email");
                            }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}