using System;
using Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department.BLL;

namespace WinForms
{
    public partial class MainForm : Form
    {
        public static RewardsBL Rewards = new RewardsBL();
        private UsersBL Users;

        public MainForm()
        {
            Users = new UsersBL();
            InitializeComponent();
            DisplayUsers();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser(sender, e);
        }

        private void AddNewUser(object sender, EventArgs e)
        {
            User user;

            UserForm uf = new UserForm();
            if (uf.ShowDialog() == DialogResult.OK)
            {
                user = new User
                {
                    FName = uf.FName,
                    LName = uf.LName,
                    DateOfBirth = uf.Date,
                    Rewards = uf.Rewards
                };

                Users.AddUser(user);

                DisplayUsers();
            }
        }

        private void DisplayRewards()
        {
            ctlRewardDataGridView.DataSource = null;

            ctlRewardDataGridView.DataSource = Rewards.GetRewards();
        }

        private void DisplayUsers()
        {
            ctlUsersDataGridView.DataSource = null;

            var users = Users.GetUser().ToList();

            var usersView = users.Select(UserDataGridView.GetModel).ToList();

            ctlUsersDataGridView.DataSource = usersView;
        }

        private void addNewRewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReward(sender, e);
        }

        private void AddReward(object sender, EventArgs e)
        {
            Reward reward;

            RewardForm uf = new RewardForm();
            if (uf.ShowDialog() == DialogResult.OK)
            {
                reward = new Reward
                {
                    Title = uf.Title,
                    Description = uf.Description
                };

                Rewards.AddReward(reward);
            }

            DisplayRewards();
        }

        private void deleteRewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteReward(sender, e);
        }

        private void DeleteReward(object sender, EventArgs e)
        {
            Reward reward = (Reward)ctlRewardDataGridView.SelectedCells[0].OwningRow.DataBoundItem;

            Rewards.DeleteReward(reward);

            DisplayRewards();
            DisplayUsers();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser(sender, e);
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            var userData = (UserDataGridView)ctlUsersDataGridView.SelectedCells[0].OwningRow.DataBoundItem;

            foreach (User user in Users.GetUser())
            {
                if (userData.Id == user.ID)
                {
                    Users.DeleteUser(user);

                    break;
                }
            }

            DisplayUsers();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUser(sender, e);
        }

        private void UpdateUser(object sender, EventArgs e)
        {
            var userData = (UserDataGridView)ctlUsersDataGridView.SelectedCells[0].OwningRow.DataBoundItem;

            foreach (User user in Users.GetUser())
            {
                if (userData.Id == user.ID)
                {
                    UserForm form = new UserForm(user);
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        user.FName = form.FName;
                        user.LName = form.LName;
                        user.DateOfBirth = form.Date;
                        user.Rewards = form.Rewards;
                    }

                    break;
                }
            }

            DisplayUsers();
        }

        private void updateRewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReward(sender, e);
        }

        public void UpdateReward(object sender, EventArgs e)
        {
            var reward = (Reward)ctlRewardDataGridView.SelectedCells[0].OwningRow.DataBoundItem;
            Reward prevReward = new Reward { Title = reward.Title};

            RewardForm form = new RewardForm(reward);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                reward.Title = form.Title;
                reward.Description = form.Description;
            }

            Users.UpdateRewards(prevReward, reward);

            DisplayUsers();
            DisplayRewards();
        }
    }
}

