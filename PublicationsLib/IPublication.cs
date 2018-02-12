using System;
using System.Collections.Generic;
using System.Text;

namespace PublicationsLib
{
    public interface IPublication
    {
        string Title { get; set; }
        string Author { get; set; }
        DateTime PubDate { get; set; }

        string GetFullName();
    }
}
