using System;
using System.Collections.Generic;
using Statistics.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace Statistics.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        //Registration Action
        [HttpGet]
        public ActionResult RegistrationForm()
        {
            return View();
        }

        //Registration POST action 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegistrationForm(User user)
        {
            

            // Model Validation 
            if (ModelState.IsValid && !IsEmailExist(user.Email))
            {
                //  Crypto passHack = new Crypto();
                //  user.Password = passHack.Hash(user.Password);
                //user.ConfirmPassword = passHack.Hash(user.ConfirmPassword);

                if(user.Password != user.ConfirmPassword)
                {
                    ModelState.AddModelError("", "Confirm password and password does not match");
                    return View();
                }

                //save to DataBase
                using (UserDatabaseEntities dc = new UserDatabaseEntities())
                {
                    dc.User.Add(user);
                    dc.SaveChanges();
                    TempData["msg"] = "<script>alert('Registration succesfully');</script>";
                    return RedirectToAction("LoginForm", "User");
                }
               
            }
            ModelState.AddModelError("", "This email email already exists");
            return View();
        }

        public ActionResult LoginForm()
        {
            return View();
        }

        //Login POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginForm(UserLogin login)
        {

            using (UserDatabaseEntities dc = new UserDatabaseEntities())
            {
                var v = dc.User.Where(a => a.Email == login.Email && a.Password == login.Password).FirstOrDefault();
            //    var c = dc.User.Where(a => a.Password == login.Password).FirstOrDefault();
                if(v != null) {
                    Session["UserId"] = v.UserId;
                    Session["FirstName"] = v.FirstName;
                    Session["Email"] = v.Email;
                    
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Invalid  credentials");
            return View(login);

        }


        [NonAction]
        public bool IsEmailExist(string emailID)
        {
            using (UserDatabaseEntities dc = new UserDatabaseEntities())
            {
                var v = dc.User.Where(a => a.Email == emailID).FirstOrDefault();
                return v != null;
            }
        }
        //Logout
        public ActionResult logout()
        {
            Session.Contents.RemoveAll();
            return RedirectToAction("Index", "Home");
        }
    }
}