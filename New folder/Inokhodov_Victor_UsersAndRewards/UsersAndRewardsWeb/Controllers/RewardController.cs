using Department.BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsersAndRewardsWeb.Controllers
{
    public class RewardController : Controller
    {
        public RewardsBL rewards = UserController.rewards;

        [HttpGet]
        public ActionResult Save(int rewardId = 0)
        {
            if (rewardId == 0)
            {
                ViewBag.Reward = new Reward() { Title = "", Description = "" };
            }
            else
            {
                ViewBag.Reward = rewards.GetRewards().FirstOrDefault(c => c.ID == rewardId);
            }

            return View();
        }
        [HttpPost]
        public ActionResult Save(Reward reward)
        {
            if (reward != null)
            {
                if (string.IsNullOrEmpty(reward.Title))
                {
                    return new HttpStatusCodeResult(404, "Title can't be empty :(");
                }
                if (reward.Description == null)
                {
                    reward.Description = "";
                }

                if (rewards.GetRewards().Any(c => c.ID == reward.ID))
                {
                    rewards.UpdateReward(reward);
                }
                else
                {
                    rewards.AddReward(reward);
                }
            }

            return RedirectToAction("Index", "User");
        }

        public ActionResult Delete(int rewardId)
        {
            var currentReward = rewards.GetRewards().FirstOrDefault(u => u.ID == rewardId);
            if (currentReward != null)
            {
                rewards.DeleteReward(currentReward.ID);
            }

            return RedirectToAction("Index", "User");
        }
    }
}