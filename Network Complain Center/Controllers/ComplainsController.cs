﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network_Complain_Center.Controllers
{
    public class ComplainsController : Controller
    {
        //
        // GET: /Complains/

        public ActionResult Index()
        {
            return View();
        }

    }
}
