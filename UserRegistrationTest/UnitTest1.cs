using RegularExpressionProblem;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void FirstNameValidationTest1()
        {
            string name = "Chetan";
            UserDetails user = new UserDetails();
            bool result = user.ValidateFirstname(name);
            Assert.AreEqual(true, result);
        }
      
        
        [TestMethod]
        public void LastNameValidationTest1()
        {
            string name = "Gharjare";
            UserDetails user = new UserDetails();
            bool result = user.ValidateLastname(name);
            Assert.AreEqual(true, result);
        }
        
        [TestMethod]
        public void EmailValidationTest1()
        {
            string email = "gharjarechetan11@gmail.com";
            UserDetails user = new UserDetails();
            bool result = user.ValidateEmailAddress(email);
            Assert.AreEqual(true, result);
        }
        
        [TestMethod]
        public void PhoneNumberValidationTest1()
        {
            string phn = "91 9374547331";
            UserDetails user = new UserDetails();
            bool result = user.Validatephonenumber(phn);
            Assert.AreEqual(true, result);
        }
       
        [TestMethod]
        public void PasswordValidationTest1()
        {
            string pwd = "Chetan@23";
            UserDetails user = new UserDetails();
            bool result = user.Validatepassword(pwd);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        [DataRow("gharjarechetan11@gmail.com")]
        
        public void ParamterizedEmailTest(string Email)
        {
            UserDetails user = new UserDetails();
            bool result = user.ValidateEmailAddress(Email);
            Assert.AreEqual(true, result);
        }
    }
}