using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCoreAWSExamen.Models;
using MvcCoreAWSExamen.Repositories;

namespace MvcCoreAWSExamen.Controllers
{
    public class HomeController : Controller
    {

        RepositoryCoches repo;

        public HomeController(RepositoryCoches repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CochesMariaDb()
        {
            List<Coche> coches = this.repo.GetCoches();
            return View(coches);
        }
    }
}
