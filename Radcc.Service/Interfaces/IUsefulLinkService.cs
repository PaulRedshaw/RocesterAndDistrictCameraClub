using Radcc.Model;
using System.Collections.Generic;

namespace Radcc.Service.Interfaces
{
    public interface IUsefulLinkService
    {
        List<UsefulLink> GetAllLinks();
        UsefulLink GetUsefulLinkById(int id);
        void CreateUsefulLink(UsefulLink link);
        void UpdateUsefulLink(UsefulLink link);
        void DeleteUsefulLink(UsefulLink link);
        void SaveChanges();

    }
}
