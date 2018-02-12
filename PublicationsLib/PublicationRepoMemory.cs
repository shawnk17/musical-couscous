using System;
using System.Collections.Generic;
using System.Text;

namespace PublicationsLib
{
    public class PublicationRepoMemory : IPublicationRepo
    {
        private static List<IPublication> _publications;

        public PublicationRepoMemory()
        {
            if(_publications == null)
            {
                _publications = new List<IPublication>();
                _publications.Add(new Book { Title = "Things and Stuff", Author = "Shawn", PubDate = DateTime.Now });
            }
        }
        public void Add(IPublication newPublication)
        {
            _publications.Add(newPublication);
        }

        public IPublication GetByTitle(string title)
        {
            return _publications.Find(p => p.Title == title);
        }

        public List<IPublication> ListAll()
        {
            return _publications;
        }
    }
}
