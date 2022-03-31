using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uc2ReflectionException;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // Uc 1 Test case 1.1
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            string expected = "SAD";
            string message = " I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string mood = moodAnalyser.AnalyserMood();

            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        // Uc 1 Test case 1.2
        [DataRow("I am in Happy Mood")]
        // Uc 2 Null DataRow
        [DataRow(null)]
        public void GivenHappyShouldReturnHappy(string message)
        {
            string expected = "HAPPY";
            string message1 = " I am in Happy Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message1);

            string mood = moodAnalyser.AnalyserMood();

            Assert.AreEqual(expected, mood);
        }
    }
}
