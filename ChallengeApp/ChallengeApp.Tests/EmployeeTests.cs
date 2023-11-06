namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectGrades_ReturnTheMinGrade()
        {
            // arrange
            var employee = new Employee("Wojciech", "Kowalski",'M', 40);
            employee.AddGrade('a');
            employee.AddGrade("1");
            employee.AddGrade(3);
            employee.AddGrade('E');

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(1, statistics.Min);
        }

        [Test]
        public void WhenEmployeeCollectGrades_ReturnTheMaxGrade()
        {
            // arrange
            var employee = new Employee("Wojciech", "Kowalski", 'M', 40);
            employee.AddGrade('A');
            employee.AddGrade("1");
            employee.AddGrade(3);
            employee.AddGrade('E');

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void WhenEmployeeCollectGrades_ReturnTheAverageResult()
        {
            // arrange
            var employee = new Employee("Wojciech", "Kowalski",'M', 40);
            employee.AddGrade('a');
            employee.AddGrade("17");
            employee.AddGrade(33);
            employee.AddGrade('E');
            employee.AddGrade(3);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(34.60, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void WhenEmployeeCollectGrades_ReturnTheAverageLetterResult()
        {
            // arrange
            var employee = new Employee("Wojciech", "Kowalski",'M', 40);
            employee.AddGrade('a');
            employee.AddGrade("17");
            employee.AddGrade(33);
            employee.AddGrade('E');
            employee.AddGrade(3);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('D', statistics.AverageLetter);
        }
    }
}