﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VerifactsWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ForCorporate()
        {
            return View();
        }

        public ActionResult ForIndividual()
        {
            return View();
        }

        public ActionResult ForCandidate()
        {
            return View();
        }

        public ActionResult Career()
        {
            return View();
        }

        public ActionResult ClientsSpeak()
        {
            return View();
        }

        public ActionResult PressReleases()
        {
            return View();
        }

        public ActionResult TermsOfUse()
        {
            return View();
        }

        public ActionResult Insights()
        {
            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        public ActionResult OurAdvantage()
        {
            return View();
        }
    }
}