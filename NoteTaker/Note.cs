using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaker
{
    internal class Note
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int ID { get; set; }

        public Note(string title, string content, int id)
        {
            this.Title = title;
            this.Content = content;
            this.ID = id;
        }
    }
}
