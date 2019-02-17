using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1
{
    public class Article
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string title { get; set; }
        public string keywords { get; set; }
        public string content { get; set; }
        public string url { get; set; }
        public int student_id { get; set; }

        public Article(string title, string keywords, string content, string url)
        {
            this.title = title;
            this.keywords = keywords;
            this.content = content;
            this.url = url;
            this.student_id = 104;
        }

        public Article()
        {
        }

    }
}
