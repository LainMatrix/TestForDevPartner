using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.Entities;
using Domain.Concrete;
using  WebUI.Controllers;

namespace WebUI.Controllers
{
    public class ReportController : Controller
    {
        private IRepository repository=new EFRepository();

        //public ReportController(IRepository repo)
        //{
        //    repository = repo;
        //}

        // GET: Report
        public ActionResult List()
        {
            return View(repository);
        }
    }
}