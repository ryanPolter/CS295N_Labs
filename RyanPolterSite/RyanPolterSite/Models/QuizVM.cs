namespace RyanPolterSite.Models
{
    public enum QuestionType
    {
        ShortAnswer,
        Numeric,
        MultipleChoice,
        TrueFalse
    }
    public class QuizVM
    {
        
        public QuestionType Type { get; set; }
        public string Question { get; set; }
        //  Answer means the correct answer
        public string Answer { get; set; }      
        public string UserAnswer { get; set; }
        //  Should return True if the user gets the question right
        public bool? IsRight { get; set; } = null;

        //  From class??
        //public string UserAnswer1 { get; set; }
        //public string UserAnswer2 { get; set; }
        //public string UserAnswer3 { get; set; }

        //public string RightOrWrong1 { get; set; }
        //public string RightOrWrong2 { get; set; }
        //public string RightOrWrong3 { get; set; }

    }
}
