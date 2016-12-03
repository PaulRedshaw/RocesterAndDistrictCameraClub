using System.Collections.Generic;
using Radcc.Model;

namespace Radcc.Data
{
    public interface IUsefulLinkRepository
    {
        IEnumerable<UsefulLink> GetAllLinks();
        UsefulLink GetById(int id);
        void Add(UsefulLink link);
        void Update(UsefulLink link);
        void Delete(UsefulLink link);
        
        
       
    }
}