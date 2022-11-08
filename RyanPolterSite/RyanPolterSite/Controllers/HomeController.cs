using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RyanPolterSite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RyanPolterSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        
        public IActionResult Stories()
        {
            return View();
        }

        //public IActionResult Quiz()
        //{
        //    return View();
        //}
        public IActionResult Quiz()
        {
            List<QuizVM> questionSet = RyanPolterSite.Quiz.GenerateQuestionSet();
            return View(questionSet);
        }

        [HttpPost]
        public IActionResult Quiz(List<QuizVM> answers)
        {
            var quesions = RyanPolterSite.Quiz.GenerateQuestionSet();
            for (int i = 0; i < quesions.Count; i++)
            {
                quesions[i].UserAnswer = answers[i].UserAnswer;
            }
            RyanPolterSite.Quiz.CheckAnswers(quesions);
            return View(quesions);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
