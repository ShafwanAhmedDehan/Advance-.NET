using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ProtfolioDehanController : Controller
    {
        // GET: ProtfolioDehan
        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult Home()
        {
            string name = "Md Shafwan Ahmed Dehan";
            string email = "ahmedsad221999@gmail.com";
            string bio = "This is Dehan and I am an Engineer";
            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.Bio = bio;
            return View();
        }
        public ActionResult pageProfile()
        {
            Profile p1 = new Profile();
            p1.name = "Md Shafwan Ahmed Dehan";
            p1.DOB = "22th Aug 1999";
            p1.Nation = "Bangladeshi";
            p1.Bldgrp = "A+";
            p1.Address = "10/F4, Green Heaven, Mirbagh";
            p1.contactNo = "01317810827";
            p1.Hobby = "Playing Football";
            return View(p1);
        }
        public ActionResult Education()
        {
            Education e1 = new Education();
            e1.degree = "BSC";
            e1.inst = "AIUB";
            e1.year = "Last Semester";
            Education e2 = new Education();
            e2.degree = "HSC";
            e2.inst = "Dhaka College";
            e2.year = "2018";
            Education e3 = new Education();
            e3.degree = "SSC";
            e3.inst = "Shamsul Haque Khan School & College";
            e3.year = "2016";
            object[] edu = new object[] { e1,e2,e3 };
            ViewBag.EDU = edu;
            return View();
        }
        public ActionResult Projects()
        {
            Projectlist prj1 = new Projectlist();
            prj1.course = "C#";
            prj1.description = "Garden AID";
            Projectlist prj2 = new Projectlist();
            prj2.course = "Web Tech";
            prj2.description = "VMS Sytem";
            var myproject = new Projectlist[] { prj1, prj2 };
            return View(myproject);
        }
        public ActionResult Refer()
        {
            string name = "XYZ";
            string contact = "01xxxxxxxx";
            ViewBag.Rname = name;
            ViewBag.Rcontact = contact;
            return View();
        }
    }
}