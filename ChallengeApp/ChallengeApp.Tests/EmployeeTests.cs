namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectGrades_ReturnTheMinGrade()
        {
            // arrange
            var employee = new Employee("Wojciech", "Kowalski", 40);
            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddGrade(3);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(3, statistics.Min);
        }

        [Test]
        public void WhenEmployeeCollectGrades_ReturnTheMaxGrade()
        {
            // arrange
            var employee = new Employee("Wojciech", "Kowalski", 40);
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(4);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(5, statistics.Max);
        }

        [Test]
        public void WhenEmployeeCollectGrades_ReturnTheAverageResult()
        {
            // arrange
            var employee = new Employee("Wojciech", "Kowalski", 40);
            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddGrade(2);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(3.67,2), Math.Round(statistics.Average, 2));
        }

    }
}