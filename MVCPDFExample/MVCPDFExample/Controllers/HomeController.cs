using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPDFExample.Models;
using Rotativa;

namespace MVCPDFExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ProductModel pm = new ProductModel();
            ViewBag.ListProduct = pm.findAll();
            return View();
        }

        public ActionResult ExportPDF()
        {
            return new ActionAsPdf("Index")
            {
                FileName = Server.MapPath("~/Content/ListProducts.pdf")
            };

        }
    }
}