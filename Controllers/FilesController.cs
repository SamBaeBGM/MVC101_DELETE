using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mvc101.Controllers
{
    public class FilesController : Controller
    {
        // GET: Process
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles("TextFiles").Select(f=> Path.GetFileName(f)).ToArray();
            ViewBag.Files = files;
            return View();
        }

        public ActionResult Content(string id) {
            string[] f = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory() + "/TextFiles/" + id);
            return View(f);
        }
        

    }
}