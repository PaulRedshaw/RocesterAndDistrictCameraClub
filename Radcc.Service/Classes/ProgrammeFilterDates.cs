using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radcc.Service.Classes
{
    public sealed class ProgrammeFilterDates
    {

        public DateTime GetStartDate(DateTime filterDate)
        {
            var startDate = new DateTime();
            if (filterDate.Month >=  1 && filterDate.Month <= 5)
            {
                startDate = new DateTime(filterDate.Year - 1, 06, 01);
            }
            else
            {
                startDate = new DateTime(filterDate.Year, 06, 01);
            }

            return startDate;
        }
        public DateTime GetEndDate(DateTime filterDate)
        {
            var endDate = new DateTime();
            if (filterDate.Month >= 1 && filterDate.Month <= 5)
            {
                endDate = new DateTime(filterDate.Year , 05, 31);
            }
            else
            {
                endDate = new DateTime(filterDate.Year + 1, 05, 31);
            }
            return endDate;
        }



    }
}
