using Radcc.Data.Context;
using Radcc.Data.Infrastructure;
using Radcc.Data.Persistence;
using Radcc.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System;
using System.Linq.Expressions;
using System.Linq;

namespace Radcc.Data
{
    public class UsefulLinkRepository : IUsefulLinkRepository
    {
        private readonly ApplicationDbContext _context;
        public UsefulLinkRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        

        public UsefulLink GetById(int id)
        {
            return this._context.UsefulLinks.Find(id);
        }
        public void Add(UsefulLink link)
        {
            this._context.UsefulLinks.Add(link);
           
        }
        public void Update(UsefulLink link)
        {
            this._context.Entry(link);
       
        }
        public void Delete(UsefulLink link)
        {
            this._context.UsefulLinks.Remove(link);
        
        }

        public IEnumerable<UsefulLink> GetAllLinks()
        {
            return _context.UsefulLinks.ToList();

        }

       
       
    }
}          
        

