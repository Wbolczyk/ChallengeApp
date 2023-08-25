namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectPositiveScores_ShouldTheResult()
        {
            // arrange
            var employee = new Employee("Wojciech", "Kowalski", 40, 0);
            employee.AddScore(5);
            employee.AddScore(4);
            employee.AddScore(3);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(12, result);
        }

        [Test]
        public void WhenEmployeeCollectNegativeScores_ShouldTheResult()
        {
            //arrange
            var employee = new Employee("Aleksandra", "Nowak", 44, 0);
            employee.AddScore(5);
            employee.AddScore(4);
            employee.AddScore(-6);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(3, result);
        }           
    }
}