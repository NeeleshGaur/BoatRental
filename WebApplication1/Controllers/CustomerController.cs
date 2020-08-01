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
    public class CustomerController : Controller
    {
        CustomerDAO dao;
        public CustomerController(CustomerDAO dao) {
            this.dao = dao;
        }

        // GET: CustomerController/Details/5
        public CustomerModel Details(int id)
        {
            return dao.Get(id);
        }


        // POST: CustomerController/Create
        [HttpPost]
        
        public string Create(string name)
        {
            try
            {
                CustomerModel model = new CustomerModel();
                model.CustomerName = name;
                return "Customer added with id : " + dao.Add(model);
            }
            catch
            {
                return "Customer couldn't be added";
            }
        }

            }
}
