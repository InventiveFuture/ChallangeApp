
using System.Reflection.Metadata;

namespace ChallangeApp.Tests
{
    public class Tests
    {


        [Test]
        public void WhenUsersResultsAreGathered_ShouldReturnCorrectSum()
        {
            //arrange
            var user = new Employee("Andrzej", "Kaczmarek", 40);
            user.AddScore(9);
            user.AddScore(11);
            user.DeleteScore(-20);
            user.Multiplication(3 * 2);



            //act
            var result = user.Result;


            //assert
            Assert.AreEqual(6, result);




        }
    }
}