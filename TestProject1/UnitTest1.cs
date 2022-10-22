using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace MoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void ShouldReturnsadMood()
        {
            //Arrange
            MoodAnalyser moodAnalyzer = new MoodAnalyser("I am in sad Mood");
            //Act
            string Actual = moodAnalyzer.Analyse();
            //Assert
            Assert.AreEqual("sad", Actual);

        }

        [TestMethod]
        public void ShouldReturnHappyMood()
        {
            //Arrange
            MoodAnalyser moodAnalyzer = new MoodAnalyser("I am in any mood");
            //Act
            string Actual = moodAnalyzer.Analyse();
            //Assert
            Assert.AreEqual("happy", Actual);

        }
        [TestMethod]
        public void ShouldReturnHappyMoodWhenMessageIsNull()
        {

            MoodAnalyser moodAnalyzer = new MoodAnalyser(null);
            string result = moodAnalyzer.Analyse();
            Assert.AreEqual("happy", result);
        }
    }
}