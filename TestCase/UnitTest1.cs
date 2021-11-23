using NUnit.Framework;
using UserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {
        PatternCheck check;

        [SetUp]
        public void Setup()
        {
            check = new PatternCheck();
        }
        [Test]
        public void FNameTest()
        {
            var resultFName = check.FirstNameValidation("Naresh");
            Assert.AreEqual(true, resultFName);
        }
        [Test]
        public void LNameTest()
        {
            var resultLName = check.LastNameValidation("Chinna");
            Assert.AreEqual(true, resultLName);
        }
        [Test]
        public void EmailTest()
        {
            var resultEmail = check.EmailValidation("abc@bl.co");
            Assert.AreEqual(true, resultEmail);
        }
        [Test]
        public void PhoneNoTest()
        {
            var resultPhone = check.PhoneNoValidation("91 9848022338");
            Assert.AreEqual(true, resultPhone);
        }
        [Test]
        public void UC_5_PasswordTest()
        {
            var resultPassword = check.UC_5_PasswordValidation("asdflkjh124");
            Assert.AreEqual(true, resultPassword);
        }
        [Test]
        public void UC_6_PasswordTest()
        {
            var resultPwd = check.UC_6_PasswordValidation("asdF44rghjvn");
            Assert.AreEqual(true, resultPwd);
        }
        [Test]
        public void UC_7_PasswordTest()
        {
            var resultPasWd = check.UC_7_PasswordValidation("asdF44rghjvn");
            Assert.AreEqual(true, resultPasWd);
        }
        [Test]
        public void UC_8_PasswordTest()
        {
            var resultPaswd = check.UC_8_PasswordValidation("adftB23@daeif");
            Assert.AreEqual(true, resultPaswd);
        }

        [Test]
        public void AllEmailTest()
        {
            var resultEmail = check.allEmailValidation("abc+100@gmail.com");
            Assert.AreEqual(true, resultEmail);
        }
    }
}