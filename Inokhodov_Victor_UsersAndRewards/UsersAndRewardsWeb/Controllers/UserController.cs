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
            ViewBag.AllRewards = rewards.GetRewards();
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

            ViewBag.AllRewards = rewards.GetRewards();

            return View();
        }
        [HttpPost]
        public ActionResult Save(User user, string[] names)
        {
            if (user != null)
            {
                if(
                    string.IsNullOrEmpty(user.FName) ||
                    string.IsNullOrEmpty(user.LName) ||
                    (user.DateOfBirth.Year > DateTime.Now.Year ||
                    user.DateOfBirth.Year < DateTime.Now.Year - 150))
                {
                    return new HttpStatusCodeResult(404, "Incorrect user data :(");
                }

                user.Rewards = new List<Reward>();

                if (names != null)
                {
                    foreach (string name in names)
                    {
                        if (rewards.GetRewards().Any(c => c.Title == name))
                        {
                            user.Rewards.Add(rewards.GetRewards().First(c => c.Title == name));
                        }
                    }
                }

                if (!users.GetUser().Any(c => c.ID == user.ID))
                {
                    users.AddUser(user);
                }
                else
                {
                    users.UpdateUser(user);
                }
            }

            return RedirectToAction("Index");
        }
    }
}