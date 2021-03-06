﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PublicationsLib
{
    public class Book : IPublication
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PubDate { get; set; }

        public string GetFullName()
        {
            return $"This is a book: {Title} by {Author}";
        }
    }
}
