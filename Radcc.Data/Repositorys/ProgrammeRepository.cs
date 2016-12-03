using Radcc.Data.Context;
using Radcc.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Radcc.Data
{
    public class ProgrammeRepository : IProgrammeRepository

    {
        private readonly ApplicationDbContext _context;
        public ProgrammeRepository(ApplicationDbContext context)
        {
            this._context = context;

        }
        public IEnumerable<Programme> CurrentYearsProgramme(DateTime startDate, DateTime endDate)
        {

            var programme = _context.Programmes.Where(d => d.EventDate > startDate && d.EventDate < endDate).OrderBy(d => d.EventDate).ToList();
            return programme.ToList();
        }

        public Programme GetNextProgrammeEvent()
        {
            var nextProgrammeEvent = _context.Programmes.Where(p => p.EventDate > DateTime.Today).FirstOrDefault();
            return nextProgrammeEvent;
        }
        public IEnumerable<Programme> GetAllProgrammeEvents()
        {
            return _context.Programmes.ToList();
        }
        public Programme GetProgrammeById(int id)
        {
            return _context.Programmes.Find(id);
        }

        public void Add(Programme entity)
        {
            _context.Programmes.Add(entity);
        }

        public void Update(Programme entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Programme entity)
        {
            _context.Programmes.Remove(entity);
        }




    }
}
