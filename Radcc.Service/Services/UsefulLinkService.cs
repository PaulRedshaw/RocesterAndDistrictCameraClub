using Radcc.Data;
using Radcc.Data.Interfaces;
using Radcc.Model;
using Radcc.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radcc.Service.Services
{
   


    public class UsefulLinkService : IUsefulLinkService
    {
       
        private readonly IUnitOfWork _unitOfWork;
        public UsefulLinkService(IUnitOfWork unitOfWork)
        {
           
            this._unitOfWork = unitOfWork;
        }
        public void CreateUsefulLink(UsefulLink link)
        {
            this._unitOfWork.UsefulLinks.Add(link);
            SaveChanges();
        }

        public void DeleteUsefulLink(UsefulLink link)
        {
            this._usefulLinkRepository.Delete(link);
            SaveChanges();
        }

        public List<UsefulLink> GetAllLinks()
        {
            return _usefulLinkRepository.GetAll().ToList();
     
        }

       

        public void UpdateUsefulLink(UsefulLink link)
        {
            this._usefulLinkRepository.Update(link);
            SaveChanges();
        }

        public UsefulLink GetUsefulLinkById(int id)
        {
            return this._usefulLinkRepository.GetById(id);
        }
    }
}
