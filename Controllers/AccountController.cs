using DatabaseFromApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseFromApplication.Controllers
{
    public class AccountController : Controller
    {   
        // GET: Account
        [Route("signup")]
        public ActionResult Signup()
        {
            return View();
        }

        [Route("signup")]
        [HttpPost]
        public ActionResult Signup(SignupUserModel userModel)
        {if(ModelState.IsValid)
            { ModelState.Clear(); }
            return View();
        }

        
    }
}