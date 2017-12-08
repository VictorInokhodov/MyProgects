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
        public static RewardsBL Rewards;
        private UsersBL Users;

        public MainForm(ServiseOptions options)
        {
            Rewards = new RewardsBL(options);
            Users = new UsersBL(options);
            InitializeComponent();
            DisplayUsers();
            DisplayRewards();
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
                    FName = uf.User.FName,
                    LName = uf.User.LName,
                    DateOfBirth = uf.User.DateOfBirth,
                    Rewards = uf.User.Rewards
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

            ctlUsersDataGridView.DataSource = Users.GetUser().Select(UserDataGridView.GetModel).ToList();
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
            int id = (int)ctlRewardDataGridView.SelectedCells[0].OwningRow.Cells[0].Value;

            Rewards.DeleteReward(id);

            DisplayRewards();
            DisplayUsers();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser(sender, e);
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            var id = (int)ctlUsersDataGridView.SelectedCells[0].OwningRow.Cells[0].Value;

            Users.DeleteUser(id);

            DisplayUsers();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUser(sender, e);
        }

        private void UpdateUser(object sender, EventArgs e)
        {
            var userData = (UserDataGridView)ctlUsersDataGridView.SelectedCells[0].OwningRow.DataBoundItem;

            var userDT = new User
            {
                ID = (int)ctlUsersDataGridView.SelectedCells[0].OwningRow.Cells[0].Value,
                FName = (string)ctlUsersDataGridView.SelectedCells[0].OwningRow.Cells[1].Value,
                LName = (string)ctlUsersDataGridView.SelectedCells[0].OwningRow.Cells[2].Value,
                DateOfBirth = (DateTime)ctlUsersDataGridView.SelectedCells[0].OwningRow.Cells[3].Value
            };

            UserForm form = new UserForm(userDT);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                userDT.FName = form.User.FName;
                userDT.LName = form.User.LName;
                userDT.DateOfBirth = form.User.DateOfBirth;
                userDT.Rewards = form.User.Rewards;
            }

            Users.UpdateUser(userDT);

            DisplayUsers();
        }

        private void updateRewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReward(sender, e);
        }

        public void UpdateReward(object sender, EventArgs e)
        {
            var rewardDT = new Reward
            {
                ID = (int)ctlRewardDataGridView.SelectedCells[0].OwningRow.Cells[0].Value,
                Title = (string)ctlRewardDataGridView.SelectedCells[0].OwningRow.Cells[1].Value,
                Description = (string)ctlRewardDataGridView.SelectedCells[0].OwningRow.Cells[2].Value
            };

            RewardForm form = new RewardForm(rewardDT);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                rewardDT.Title = form.Title;
                rewardDT.Description = form.Description;
            }

            Rewards.UpdateReward(rewardDT);

            DisplayUsers();
            DisplayRewards();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser(sender, e);
        }

        private void updateUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateUser(sender, e);
        }

        private void deleteUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteUser(sender, e);
        }

        private void addRewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReward(sender, e);
        }

        private void updateRewardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateReward(sender, e);
        }

        private void deleteRewardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteReward(sender, e);
        }
    }
}

