using Radcc.Model;
using Radcc.Mvc.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Radcc.Mvc.ViewModels
{
    public class ProgrammeViewModel 
    {
        public int Id { get; set; }
        public DateTime EventDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }

       
       
    }
}