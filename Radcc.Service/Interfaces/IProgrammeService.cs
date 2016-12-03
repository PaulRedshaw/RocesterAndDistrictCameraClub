
using Radcc.Data.Interfaces;
using Radcc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radcc.Service.Interfaces
{
    public interface IProgrammeService
    {
        List<Programme> CurrentYearsProgramme();

        Programme GetNextProgrammeEvent();

        List<Programme> GetAllProgrammeEvents();
        Programme GetProgrammeById(int id);

        void AddProgramme(Programme programme);

        void UpdateProgramme(Programme programme);

        void DeleteProgramme(Programme programme);
        void SaveProgramme();

   }
}
