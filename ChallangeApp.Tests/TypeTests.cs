using System.Security.Cryptography.X509Certificates;

namespace ChallangeApp.Tests
{
    public class TypeTests
    {


        [Test]
        public void WhenWeCompareUsers_ShouldGiveNotEqualResult()
        {
            //arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Tomasz");

            //assert
            Assert.AreNotEqual(user1, user2);

            Employee GetUser(string name)
            {

                return new Employee(name);

            }
        }
        [Test]
        public void WhenWeCompareTwoUsersWithTheSameLogin_ShouldGiveEqualResult()
        {
            //arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            //assert
            Assert.AreEqual(user1.Name, user2.Name);


            Employee GetUser(string name)
            {

                return new Employee(name);
            }
        }
                [Test]
                public void WhenThereAreTwoDifferentNumbers_ShouldGiveNotEqualResult()
                {
                    //arrange
                    int number1 = 5;
                    int number2 = 10;

                    //assert
                    Assert.AreNotEqual(number1, number2);

                }
                [Test]
                public void WhenTwoStringsHaveTheSameValue_ShouldGiveTheSameResult()
                {
                    //arrange
                    string number1 = "Adam";
                    string number2 = "Adam";

                    //assert

                    Assert.AreEqual(number1, number2);
                } 
        
    }
}
