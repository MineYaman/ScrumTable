using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımYapımıProje
{
   public class Tasklar :Story
    {
        public int TaskSayisi { get; set; }
        public int TaskNo { get; set; }
        public int OncelikSirasi { get; set; }
        public string TaskIcerigi { get; set; }
        public string TaskAuthor{ get; set; }
        public DateTime TaskDeadline { get; set; }

        private List<Tasklar> Task = new List<Tasklar>();
        
        public void TaskOlustur(Tasklar t)
        {
           Task.Add(t);
        }

        public List<Tasklar> TaskList()
        {
            return Task;
        }
    }
}
