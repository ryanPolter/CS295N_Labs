using RyanPolterSite.Models;
using System.Collections.Generic;

namespace RyanPolterSite
{
    public static class Quiz
    {
        //  Here is the logic for the quiz
        public const string TRUE = "true";
        public const string FALSE = "false";

        public static List<QuizVM> GenerateQuestionSet()
        {
            var set = new List<QuizVM>();

            set.Add(new QuizVM
            {
                Type = QuestionType.ShortAnswer,
                Question = "What is Nujabes's real given name?",
                Answer = "Jun Seba"
            });

            set.Add(new QuizVM
            {
                Type = QuestionType.Numeric,
                Question = "How many studio albums (mixtapes not included) did Nujabes release?",
                Answer = "3"
            });

            set.Add(new QuizVM
            {
                Type = QuestionType.TrueFalse,
                Question = "Nujabes was a major contributor to the soundtrack of Samurai Champloo.",
                Answer = TRUE
            });

            set.Add(new QuizVM
            {
                Type = QuestionType.ShortAnswer,
                Question = "Nujabes frequently collaborated with ____, most notably on their Luv(sic) series of songs",
                Answer = "Shing02"
            });

            set.Add(new QuizVM
            {
                Type = QuestionType.TrueFalse,
                Question = "Nujabes was born in the 1980s.",
                Answer = FALSE
            });

            return set;
        }

        public static void CheckAnswers(List<QuizVM> answers)
        {
            foreach (QuizVM set in answers)
            {
                set.IsRight = set.Answer == set.UserAnswer;
            }
        }

    }
}
