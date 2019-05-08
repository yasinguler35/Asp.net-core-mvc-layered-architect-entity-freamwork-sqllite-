using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BlogApp.Entity
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body  { get; set; }
        [BindNever]
        public DateTime Date { get; set; }
        public bool isApproved { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }

        public bool isHome { get; set; }
    }
}