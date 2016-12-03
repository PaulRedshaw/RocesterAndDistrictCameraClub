using Radcc.Model;
using System;
using System.Collections.Generic;

namespace Radcc.Data
{
    public interface IProgrammeRepository
    {
        IEnumerable<Programme> GetAllProgrammeEvents();

        IEnumerable<Programme> CurrentYearsProgramme(DateTime startDate, DateTime endDate);

        Programme GetNextProgrammeEvent();
        Programme GetProgrammeById(int id);
        void Add(Programme entity);
        void Update(Programme entity);
        void Delete(Programme entity);

    }
}