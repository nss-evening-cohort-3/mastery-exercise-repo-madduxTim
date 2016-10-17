﻿using RepoQuiz.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepoQuiz.Controllers
{
    public class StudentController : Controller
    {
        StudentRepo repo = new StudentRepo();
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Students = repo.GetAllStudents();
            return View();
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
