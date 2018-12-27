using Statistics.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Statistics.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StatisticsCalculator()
        {
            return View();
        }

        public ActionResult Probabilities()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult CertifiedUsers()
        {
            return View();
        }

        public ActionResult DailyPerformanceLevel1()
        {
            return View("~/Views/Home/DailyPerformance/Level1.cshtml");
        }

        public ActionResult DailyPerformanceLevel2()
        {
            return View("~/Views/Home/DailyPerformance/Level2.cshtml");
        }

        public ActionResult DailyPerformanceLevel3()
        {
            return View("~/Views/Home/DailyPerformance/Level3.cshtml");
        }

        public ActionResult DailyPerformanceLevel4()
        {
            return View("~/Views/Home/DailyPerformance/Level4.cshtml");
        }

        public ActionResult DailyPerformanceLevel5()
        {
            return View("~/Views/Home/DailyPerformance/Level5.cshtml");
        }

    }
}