using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _28_ViewModel.Models;

namespace _28_ViewModel.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult WithViewModel()
        {
            Student sObj = new Student() { Rollno = 3, Name = "Abhishek" };
            Assessment aObj = new Assessment() { Csharpmarks = 38, MVCmarks = 40, Bootstrapmarks = 45 };
            Marksheet mObj = new Marksheet();
            mObj.MyStudent = sObj;
            mObj.Assessment = aObj;
            
            return View(mObj);
        }
    }
}