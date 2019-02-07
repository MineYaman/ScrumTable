using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımYapımıProje
{
    public class Story
    {
        public string StoryAuthor{ get; set; }
        public int StoryID { get; set; }
        public string StoryTitle { get; set; }
        public int StorySayisi { get; set; }
        public DateTime StoryDate { get; set; }
        public  string Description { get; set; }

        private List<Story> Stories = new List<Story>();
        
        public void StoryEkle(Story s)
        {
            Stories.Add(s);
        }

        public List<Story> StoryList()
        {
            return Stories;
        }

    }
}
