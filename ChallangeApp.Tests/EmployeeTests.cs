using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallangeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsIsCalled_ShouldReturnCorrectMinValue()
        {
            //arrange
            var employee = new Employee("Adam", "Nowak");
            employee.AddGrade(10);
            employee.AddGrade(25);
            employee.AddGrade(15);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(10, statistics.MinValue);
        }

        [Test]
        public void WhenGetStatisticsIsCalled_ShouldReturnCorrectMaxValue()
        {
            //arrange
            var employee = new Employee("Adam", "Nowak");
            employee.AddGrade(10);
            employee.AddGrade(25);
            employee.AddGrade(15);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(25, statistics.MaxValue);
        }

        [Test]
        public void WhenGetStatisticsIsCalled_ShouldReturnCorrectAverageValue()
        {
            //arrange
            var employee = new Employee("Adam", "Nowak");
            employee.AddGrade(10);
            employee.AddGrade(25);
            employee.AddGrade(15);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(16.67, 2), Math.Round(statistics.Average, 2));
        }
    }
}
