using FormSystem.DataBase;
using FormSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSystem.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        [HttpGet]
        public ActionResult SignUpForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUpForm(Models.UserInfo user)
        {
            if(ModelState.IsValid)
            {
                var database = new Adv_Dot_NetEntities();
                database.UserInfoes.Add(Convert(user));
                database.SaveChanges();
                return RedirectToAction("SignUpForm");
            }
            return View(user);
        }

        DataBase.UserInfo Convert(Models.UserInfo users)
        {
            var u1 = new DataBase.UserInfo() {

                Name = users.Name,
                Username = users.Uname,
                Gender = users.Gender, 
                email = users.email,
                SID = users.SID,
                DOB = users.DOB
            };
            return u1;
        }
    }
}