using System;
using System.Collections.Generic;
using System.Text;

namespace PublicationsLib
{
    public class PublicationHandler
    {
        private readonly IPublication _publication;

        public PublicationHandler(IPublication publication)
        {
            _publication = publication;
        }

        public string GetPublicationFullName()
        {
            return _publication.GetFullName();
        }
    }
}
