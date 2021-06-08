using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class BiletController : Controller
    {

        BiletManager biletManager = new BiletManager(new EfBiletDal());
        public IActionResult Index()
        {
            var bilet = biletManager.GetAll();
            return View(bilet);

        }
        public ActionResult DeleteBilet(int id)
        {
            var biletvalue = biletManager.GetById(id);
            biletManager.Delete(biletvalue);
            return RedirectToAction("Index");
        }
    }
}
