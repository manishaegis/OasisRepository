using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using oasis.Manager.Abstraction;
using oasis.Web.Models;

namespace oasis.Web.Controllers
{
    public class DetailController : Controller
    {
        private readonly IDetail _detail;

        public DetailController(IDetail detail)
        {
            _detail = detail;
        }


        // GET: Detail
        public ActionResult Index()
        {
            var model = _detail.GetAll().Select(x => new DetailViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return View(model);
        }

        
    }
}