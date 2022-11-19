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
        ApplicationDbContext context;
        public StoriesController(ApplicationDbContext c)
        {
            context = c;
        }

        //  This function fires when clicking on stories page && after clicking "Submit your Story!", but now just brings me back to Stories Page
        public IActionResult Index(int storyId)
        {
            // If the http request doesn't have a storiesModelId, then storiesModelId= 0.
            var story = context.Stories
                .Where(story => story.StoriesModelId == storyId)
                .SingleOrDefault();  // default is null
            // If no story is found, a null is sent to the view.
            return View(story);
        }
        


        //  This brings me to the story post forum
        public IActionResult StoryPost()
        {
            return View();
        }

        //  This function fires when clicking "Submit Your Story!" 
        [HttpPost]
        public IActionResult StoryPost(StoriesModel model)
        {
            model.SubmitDate = DateTime.Now;
            //  Store model in database
            context.Stories.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index", new { storyId = model.StoriesModelId });

            /*
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
            */
        }



        /*
        public IActionResult Index(string storyId
            /string storyTitle, string topic, int year, string storyText, string submitterName, DateTime date/)
        {

            StoriesModel story = new StoriesModel();

            /*
            story.StoryTitle = storyTitle;
            story.Topic = topic;
            story.Year = year; 
            story.StoryText = storyText;
            story.SubmitterName = submitterName;
            story.SubmitDate = date;
            //

            story = context.Stories.First();
            return View(story);
        }
        */
    }
}
