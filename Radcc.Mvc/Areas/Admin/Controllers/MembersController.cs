﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Radcc.Mvc.Areas.Admin.Controllers
{
    public class MembersController : Controller
    {
        // GET: Admin/Members
        public ActionResult Index()
        {
            return View();
        }
    }
}