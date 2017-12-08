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

namespace WinForms
{
    public partial class UserForm : Form
    {
        public User User;

        public string FName;
        public string LName;
        public DateTime Date;
        public List<Reward> Rewards;

        public UserForm()
        {
            InitializeComponent();

            User = new User
            {
                FName = "",
                LName = "",
                DateOfBirth = DateTime.Now
            };
        }

        public UserForm(User user)
        {
            InitializeComponent();

            User.DateOfBirth = user.DateOfBirth;
            User.FName = user.FName;
            User.LName = user.LName;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ctlDatePicker.MaxDate = DateTime.Now;
            ctlDatePicker.MinDate = new DateTime(DateTime.Now.Year - 150, 1, 1);
            ctlDatePicker.Value = User.DateOfBirth;

            ctlFNamePicker.Text = User.FName;
            ctlLNamePicker.Text = User.LName;

            foreach (Reward reward in MainForm.Rewards.GetRewards())
            {
                ctlRewardsListBox.Items.Add(reward.Title);
            }
        }

        private void ctlFNamePicker_Validating(object sender, CancelEventArgs e)
        {
            if (ctlFNamePicker == null)
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
            FName = ctlFNamePicker.Text;
        }

        private void ctlLNamePicker_Validating(object sender, CancelEventArgs e)
        {
            if (ctlLNamePicker == null)
            {
                ctlErrorProvider.SetError(ctlLNamePicker, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                ctlErrorProvider.SetError(ctlLNamePicker, string.Empty);
                e.Cancel = false;
            }
        }

        private void ctlLNamePicker_Validated(object sender, EventArgs e)
        {
            LName = ctlLNamePicker.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;

            var RewardNames = new List<string>();

            foreach (string item in ctlRewardsListBox.CheckedItems)
            {
                RewardNames.Add(item);
            }

            Rewards = RewardNames.Select(c => new Reward { Title = c }).ToList();
        }
    }
}
