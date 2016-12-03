using Radcc.Data;
using Radcc.Data.Interfaces;
using Radcc.Model;
using Radcc.Service.Classes;
using Radcc.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Radcc.Service.Services
{
    public class ProgrammeService : IProgrammeService
    {
        private IProgrammeRepository _programmeRepository;
        private IUnitOfWork _unitOfWork;
        public ProgrammeService(IProgrammeRepository eventRepository, IUnitOfWork unitOfWork)
        {
            this._programmeRepository = eventRepository;
            this._unitOfWork = unitOfWork;
        }

        public List<Programme> CurrentYearsProgramme()
        {
            var datefilter = new ProgrammeFilterDates();
            var startDate = datefilter.GetStartDate(DateTime.Today);
            var endDate = datefilter.GetEndDate(DateTime.Today);
            var programme = _programmeRepository.GetMany(d => d.EventDate > startDate && d.EventDate < endDate);
            return programme.ToList();
        }

        public Programme GetNextProgrammeEvent()
        {
            var nextProgrammeEvent = _programmeRepository.GetMany(p => p.EventDate > DateTime.Today).OrderBy(p => p.EventDate).FirstOrDefault();
            return nextProgrammeEvent;
        }

        public Programme GetProgrammeById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddProgramme(Programme programme)
        {
            throw new NotImplementedException();
        }

        public void UpdateProgramme(Programme programme)
        {
            throw new NotImplementedException();
        }

        public void DeleteProgramme(Programme programme)
        {
            throw new NotImplementedException();
        }

        public List<Programme> GetAllProgrammeEvents()
        {
           return _programmeRepository.GetAll().ToList();
        }

        public void SaveProgramme()
        {
            _unitOfWork.Commit();        }
    }
}
