using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Statistics.Controllers
{
    public class TestsController : Controller
    {
        Statistics.Models.UserDatabaseEntities user = new Statistics.Models.UserDatabaseEntities();

        // GET: Tests
        public ActionResult Main()
        {
            return View();
        }

        public ActionResult TestLevel1()
        {
            Random rand = new Random();
            int level1 = rand.Next(1, 4);
            return View("~/Views/Tests/PackageOfTests/Level1/Test" + level1 + ".cshtml");
        }

        public ActionResult TestLevel2()
        {
            Random rand = new Random();
            int level2 = rand.Next(1, 3);
            var userId = Session["UserId"].ToString();
            var completed = user.Level_1.Where(a => a.UserId.ToString() == userId && a.Completed == true).FirstOrDefault();
            if (completed == null)
            {
                TempData["msg"] = "<script>alert('Please first complete previous levels');</script>";
                return RedirectToAction("Main", "Tests");
            }
            return View("~/Views/Tests/PackageOfTests/Level2/Test" + level2 + ".cshtml");
        }

        public ActionResult TestLevel3()
        {
            Random rand = new Random();
            int level3 = rand.Next(1, 3);
            var userId = Session["UserId"].ToString();
            var completed = user.Level_2.Where(a => a.UserId.ToString() == userId && a.Completed == true)
                                               .FirstOrDefault();
            if (completed == null)
            {
                TempData["msg"] = "<script>alert('Please first complete previous levels');</script>";
                return RedirectToAction("Main", "Tests");
            }
            return View("~/Views/Tests/PackageOfTests/Level3/Test" + level3 + ".cshtml");
        }

        public ActionResult TestLevel4()
        {
            Random rand = new Random();
            int level4 = rand.Next(1, 3);
            var userId = Session["UserId"].ToString();
            var completed = user.Level_3.Where(a => a.UserId.ToString() == userId && a.Completed == true)
                                               .FirstOrDefault();
            if (completed == null)
            {
                TempData["msg"] = "<script>alert('Please first complete previous levels');</script>";
                return RedirectToAction("Main", "Tests");
            }
            return View("~/Views/Tests/PackageOfTests/Level4/Test" + level4 + ".cshtml");
        }

        public ActionResult TestLevel5()
        {
            Random rand = new Random();
            int level5 = rand.Next(1, 3);
            var userId = Session["UserId"].ToString();
            var completed = user.Level_4.Where(a => a.UserId.ToString() == userId && a.Completed == true)
                                               .FirstOrDefault();
            if (completed == null)
            {
                TempData["msg"] = "<script>alert('Please first complete previous levels');</script>";
                return RedirectToAction("Main", "Tests");

            }
            return View("~/Views/Tests/PackageOfTests/Level5/Test" + level5 + ".cshtml");

        }

    }
}