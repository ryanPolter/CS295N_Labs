using Microsoft.AspNetCore.Mvc;
using RyanPolterSite.Models;
using System.Collections.Generic;

namespace RyanPolterSite.Controllers
{
    public class QuizController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
           //   This was all moved to Home controller
        public IActionResult Quiz()
        {
            List<QuizVM> questionSet = RyanPolterSite.Quiz.GenerateQuestionSet();
            return View(questionSet);
        }

        [HttpPost]
        public IActionResult Quiz(List<QuizVM> answers)
        {
            var quesions = RyanPolterSite.Quiz.GenerateQuestionSet();
            for(int i = 0; i < quesions.Count; i++)
            {
                quesions[i].UserAnswer = answers[i].UserAnswer;
            }
            RyanPolterSite.Quiz.CheckAnswers(quesions);
            return View(quesions);
        }
    }
}
