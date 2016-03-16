using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MyTravelSite01.Models;

namespace MyTravelSite01.Controllers
{
    public class DestinationsController : Controller
    {
        private MyTravelsContext db = new MyTravelsContext();
        public IActionResult Index()
        {
            return View(db.Destinations.ToList());
        }
        public IActionResult Details(int searchId)
        {
            Destination selectedDestination = db.Destinations.FirstOrDefault(x => x.Id == searchId);
            return View(selectedDestination);
        }
    }
}
