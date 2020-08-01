using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoatRegistrationAndRenting.DAO;
using BoatRegistrationAndRenting.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoatRegistrationAndRenting.Controllers
{
    public class BoatController : Controller
    {
        BoatDAO boatDao;
        public BoatController(BoatDAO boatDao) {
            this.boatDao = boatDao;
        }
        
        // GET: BoatController/Details/5
        public BoatModel Details(int id)
        {
            return boatDao.Get(id);   
        }

       

        // POST: BoatController/Create
        [HttpPost]
        public string Create(BoatModel boat)
        {
           

                try
                {
                    return "Boat Created with ID : " + boatDao.AddBoat(boat);
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            
            
        }

        // POST: BoatController/Delete/5
        [HttpPost]
         public ActionResult Delete(string name)
        {
            try
            {
                boatDao.DeleteBoat(name);
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
