using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PublicationsLib;

namespace DemoPublicationWeb.Controllers
{
    public class PublicationController : Controller
    {
        private readonly IPublicationRepo _pubRepo;

        public PublicationController(IPublicationRepo pubRepo)
        {
            _pubRepo = pubRepo;
        }


        // GET: Publication
        public ActionResult Index()
        {
            return View(_pubRepo.ListAll());
        }

        // GET: Publication/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Publication/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Publication/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}