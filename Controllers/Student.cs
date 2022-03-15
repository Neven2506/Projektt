using Projektt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projektt.Controllers
{
    public class Student : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Title = "Početna o studentima";
            ViewBag.Fakultet = "Međimursko veleučilište";
            return View();
        }
        public ActionResult Popis()
        {
            StudentiDB studentDB = new StudentiDB(); //alt + enter
            return View(studentDB);
        }
        public ActionResult Detalji (int? id)
        {
            if (id.HasValue)
                StudentiDB studentiDB = new StudentiDB();

            Student student = studentDB.VratiListu()
                .FirsDefault(x => x.ID == id);
            if(student ==null)
            {

            }
                    return View(Student)
        }
    }
}