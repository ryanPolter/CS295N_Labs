using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RyanPolterSite.Models
{
    public class StoriesModel
    {

        public int StoriesModelId { get; set; }
        public string StoryTitle { get; set; }
        public string Topic { get; set; }
        public int Year { get; set; }
        public string StoryText { get; set; }
        public string SubmitterName { get; set; }
        public DateTime SubmitDate { get; set; }


    }
}
