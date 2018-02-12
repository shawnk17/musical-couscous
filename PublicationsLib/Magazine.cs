using System;
using System.Collections.Generic;
using System.Text;

namespace PublicationsLib
{
    public class Magazine : IPublication
    {
        // Backing Store
        private int _issueNum;

        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PubDate { get; set; }

        public int IssueNum
        {
            get
            {
                return _issueNum;
            }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Can't be less than 1");
                }
                _issueNum = value;
            }
        }

        public string GetFullName()
        {
            return $"This is a Magazine called {Title} and this is issue number {IssueNum}";
        }
    }
}
