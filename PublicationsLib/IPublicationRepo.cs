using System;
using System.Collections.Generic;
using System.Text;

namespace PublicationsLib
{
    public interface IPublicationRepo
    {
        List<IPublication> ListAll();
        IPublication GetByTitle(string title);
        void Add(IPublication newPublication);
    }
}
