using Department.BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsersAndRewardsWeb.Controllers
{
    public class UserController : Controller
    {
        public static UsersBL users = new UsersBL(new ServiseOptions {
            Context = "adonet",
            ConnectionString = @"Data Source=DESKTOP-RNTU9JF\SQLEXPRESS;Initial Catalog=UsersAndRewards;Integrated Security=True" });

        public static RewardsBL rewards = new RewardsBL(new ServiseOptions
        {
            Context = "adonet",
            ConnectionString = @"Data Source=DESKTOP-RNTU9JF\SQLEXPRESS;Initial Catalog=UsersAndRewards;Integrated Security=True"
        });

        // GET: User
        public ActionResult Index()
        {
            ViewBag.Users = users.GetUser().Select(UserDataGridView.GetModel).ToList();
            ViewBag.Rewards = rewards.GetRewards();
            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult DeleteUser(int userId)
        {
            var currentuser = users.GetUser().FirstOrDefault(u => u.ID == userId);
            if (currentuser != null)
            {
                users.DeleteUser(currentuser.ID);
            }

            return RedirectToAction("Index", "User");
        }

        [HttpGet]
        public ActionResult Save(int userId = 0)
        {
            if (users.GetUser().Any(c => c.ID == userId))
            {
                ViewBag.User = users.GetUser().FirstOrDefault(c => c.ID == userId);
            }
            else
            {
                ViewBag.User = new User() { FName = "", LName = "", DateOfBirth = DateTime.Now };
            }
            return View();
        }
        public ActionResult Save(User userModel)
        {
            if (userModel != null)
            {
                if (!users.GetUser().Any(c => c.ID == userModel.ID))
                {
                    // add
                    users.AddUser(userModel);
                }
                else
                {
                    // update
                    var currentUser = users.GetUser().FirstOrDefault(u => u.ID == userModel.ID);
                    if (currentUser != null)
                    {
                        var user = userModel;
                        currentUser.FName = user.FName;
                        currentUser.LName = user.LName;
                        currentUser.DateOfBirth = user.DateOfBirth;
                        currentUser.Rewards = user.Rewards;
                    }
                }
            }

            return RedirectToAction("Index");
        }
    }
}