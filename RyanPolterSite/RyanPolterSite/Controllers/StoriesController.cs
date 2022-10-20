using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RyanPolterSite.Models;

namespace RyanPolterSite.Controllers
{
    public class StoriesController : Controller
    {
        public IActionResult Index(string storyTitle, string topic, int year, string storyText, string submitterName, DateTime date)
        {
            StoriesModel story = new StoriesModel();
            story.StoryTitle = storyTitle;
            story.Topic = topic;
            story.Year = year; 
            story.StoryText = storyText;
            story.SubmitterName = submitterName;
            story.SubmitDate = date;
            return View(story);
        }

        public IActionResult StoryPost()
        {
            return View();
        }


        [HttpPost]
        public IActionResult StoryPost(StoriesModel model)
        {
            return RedirectToAction("Index",
                new
                {
                    storyTitle = model.StoryTitle,
                    topic = model.Topic,
                    year = model.Year,
                    storyText = model.StoryText,
                    submitterName = model.SubmitterName,
                    date = DateTime.Now

                }
            );
        }
    }
}
