using RyanPolterSite;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RyanPolterSiteTests
{
    public class QuizTests
    {
        // Ternary review stuff https://www.tutorialsteacher.com/csharp/csharp-ternary-operator

        [Fact]
        public void CheckCorrectAnswersTest()
        {
            //  Arrange
            var set = Quiz.GenerateQuestionSet();
            //  This will set all answers to the correct answer
            foreach (var answer in set)
                answer.UserAnswer = answer.Answer;


            //  Act
            Quiz.CheckAnswers(set);

            //  Assert 
            bool result = true;
            foreach (var answer in set)
                result = result && (answer.IsRight ?? false);
            Assert.True(result);
        }

        [Fact]
        public void CheckWrongAnswersTest()
        {
            //  Arrange
            var set = Quiz.GenerateQuestionSet();
            foreach (var answer in set)
                answer.UserAnswer = "A wrong answer";


            //  Act
            Quiz.CheckAnswers(set);

            //  Assert 
            bool result = false;
            foreach (var answer in set)
                result = result || (answer.IsRight ?? false);
            Assert.False(result);
        }
    }
}
