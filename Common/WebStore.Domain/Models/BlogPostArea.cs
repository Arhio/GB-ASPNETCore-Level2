﻿namespace WebStore.Domain.Models
{
    public class BlogPostArea
    {
        public string Title { get; set; }
        public string User { get; set; }
        public string Clock { get; set; }
        public string Date { get; set; }
        public string Pic { get; set; }
        public string Context { get; set; }
        public string[] ArrayContext { get; set; }

        public BlogPostArea() { }
        public BlogPostArea(string title, string user, string clock, string date, string pic, string[] context)
        {
            Title = title;
            User = user;
            Clock = clock;
            Date = date;
            Pic = pic;
            ArrayContext = context;
        }
    }
}
