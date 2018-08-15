using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeziKatılım.Web.Model;
using Microsoft.AspNetCore.Mvc;

namespace GeziKatılım.Web.Controllers
{
    public class TravelController : Controller
    {
        //travel/index
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "İyi günler" : "Günaydın";

            return View();
        }

        public ViewResult List()
        {
            var liste = Repository.Participants.Where(i => i.WillAttend == true);
            return View(liste);
        }

        [HttpGet]
        public ViewResult Apply()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Apply(Participant participant)
        {
                   
            if (ModelState.IsValid)
            {
                Repository.AddParticipant(participant);
                return View("Result", participant);

            }
            else
            {
                return View();
            }
        }
    }
}