using Radcc.Model.Classes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Radcc.Model
{
    public class Programme
    {
        public int Id { get; set; }
        public DateTime EventDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        [DisplayFormat(DataFormatString = "{0:dddd MMM yyyy}")]
        public string FormattedEventDate
        {
            get
            {
                var formattedDate = string.Format(new CustomDateProvider(), "{0}", EventDate);
                return formattedDate;
            }
        }
   
        public string StartTime
        {
            get { return EventDate.ToString("hh:mm tt"); }

        }

        public string ArriveTime
        {
            get { return EventDate.AddMinutes(-30).ToString("hh:mm tt"); }

        }


    }
}
