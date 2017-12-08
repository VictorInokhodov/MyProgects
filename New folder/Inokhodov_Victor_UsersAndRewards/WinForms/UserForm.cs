using System;
using System.Collections.Generic;
using System.ComponentModel;
using Entities;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class UserForm : Form
    {
        public User User;

        public UserForm()
        {
            InitializeComponent();

            User = new User
            {
                FName = "",
                LName = "",
                DateOfBirth = DateTime.Now,
                Rewards = new List<Reward>()
            };
        }

        public UserForm(User user)
        {
            InitializeComponent();

            User = new User
            {
                FName = user.FName,
                LName = user.LName,
                DateOfBirth = user.DateOfBirth,
                Rewards = new List<Reward>()
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ctlDatePicker.Value = User.DateOfBirth;
            ctlDatePicker.MaxDate = DateTime.Now;
            ctlDatePicker.MinDate = new DateTime(DateTime.Now.Year - 150, 1, 1);

            ctlFNamePicker.Text = User.FName;
            ctlLnamePicker.Text = User.LName;

            foreach (Reward reward in MainForm.Rewards.GetRewards())
            {
                ctlRewardsCheckBox.Items.Add(reward.Title);
            }
        }

        private void ctlFNamePicker_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctlFNamePicker.Text))
            {
                ctlErrorProvider.SetError(ctlFNamePicker, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                ctlErrorProvider.SetError(ctlFNamePicker, string.Empty);
                e.Cancel = false;
            }
        }

        private void ctlFNamePicker_Validated(object sender, EventArgs e)
        {
            User.FName = ctlFNamePicker.Text;
        }

        private void ctlLnamePicker_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctlLnamePicker.Text))
            {
                ctlErrorProvider.SetError(ctlLnamePicker, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                ctlErrorProvider.SetError(ctlLnamePicker, string.Empty);
                e.Cancel = false;
            }
        }

        private void ctlLnamePicker_Validated(object sender, EventArgs e)
        {
            User.LName = ctlLnamePicker.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;

            var RewardNames = new List<string>();
            var allRewards = MainForm.Rewards.GetRewards();
            foreach (string item in ctlRewardsCheckBox.CheckedItems)
            {
                var reward = allRewards.FirstOrDefault(r => r.Title == item);
                if (reward != null)
                {
                    User.Rewards.Add(reward);
                }
            }

            User.DateOfBirth = ctlDatePicker.Value;
        }
    }
}
