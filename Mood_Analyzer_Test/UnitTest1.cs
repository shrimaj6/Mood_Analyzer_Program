using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer_Program;

namespace Mood_Analyzer_Test

{
    [TestClass]
    public class TestMood
    {
        [TestMethod]
        public void NullMood()
        {
            string msg = " ";
            string expected = "HAPPY";

            MoodAnalyzer mood = new MoodAnalyzer(msg);

            string actual = mood.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getCustomNullException()
        {
            string expected = "message should not be null";
            MoodAnalyzer modeAnalyzer = new MoodAnalyzer(" ");

            try
            {
                string actual = modeAnalyzer.AnalyseMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void getCustomEmptyException()
        {
            string expected = "message should not be empty";
            MoodAnalyzer modeAnalyzer = new MoodAnalyzer(string.Empty);

            try
            {
                string actual = modeAnalyzer.AnalyseMood1();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]

        public void MoodAnalyseClassName()
        {
            try
            {
                string msg = null;

                object expected = new MoodAnalyzer(msg);
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser");
                expected.Equals(obj);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        [TestMethod]

        public void MoodAnalyseWrongClassName()
        {
            try
            {
                string msg = null;
                object expected = new MoodAnalyzer(msg);
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyserWrong", "MoodAnalyserWrong");
                expected.Equals(obj);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        [TestMethod]

        public void MoodAnalyseWrongConstructor()
        {
            try
            {
                string msg = null;
                object expected = new MoodAnalyzer(msg);
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyserWrong");
                expected.Equals(obj);
            }

            catch (CustomException ex)
            {
                Assert.AreEqual("Constructor not found", ex.Message);
            }
        }

        [TestMethod]

        public void ParameterisedConstructor_MoodAnalyseClassName()
        {
            object expected = new MoodAnalyzer("HAPPY");
            object obj = MoodAnalyzerFactory.MoodAnalyserParameterisedConstructor("MSTestMoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser","HAPPY");
            expected.Equals(obj);
        }

        [TestMethod]

        public void ParameterisedConstructor_WrongClassName()
        {
            try
            {
                object expected = new MoodAnalyzer("HAPPY");
                object obj = MoodAnalyzerFactory.MoodAnalyserParameterisedConstructor("MSTestMoodAnalyzerProblem.MoodAnalyserWrong", "MoodAnalyser");
                expected.Equals(obj);
            }

            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        [TestMethod]
        public void ParameterisedConstructor_WrongConstrcutorName()
        {
            try
            {
                object expected = new MoodAnalyzer("HAPPY");
                object obj = MoodAnalyzerFactory.MoodAnalyserParameterisedConstructor("MSTestMoodAnalyzerProblem.MoodAnalyser", "MoodAnalyserWrong");
                expected.Equals(obj);
            }

            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }
    }
}




