using Entities;
using System;
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
        public static User UpdatingUser = new User();
        public string FName;
        public string LName;
        public DateTime Date = DateTime.Now;
        public List<Reward> Rewards;

        public UserForm()
        {
            Rewards = new List<Reward>();

            UpdatingUser.FName = "";
            UpdatingUser.LName = "";
            UpdatingUser.DateOfBirth = DateTime.Now;

            InitializeComponent();
        }

        public UserForm(User user)
        {
            UpdatingUser.LName = user.LName;
            UpdatingUser.FName = user.FName;
            UpdatingUser.DateOfBirth = user.DateOfBirth;

            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ctlUserDateTimePicker.MaxDate = DateTime.Now;
            ctlUserDateTimePicker.MinDate = new DateTime(DateTime.Now.Year - 150, 1, 1);
            ctlUserDateTimePicker.Value = UpdatingUser.DateOfBirth;
            ctlFirstNamePicker.Text = UpdatingUser.FName;
            ctlSecNamePicker.Text = UpdatingUser.LName;

            foreach (Reward reward in MainForm.Rewards.GetRewards())
            {
                ctlRewardsCheckBox.Items.Add(reward.Title);
            }
        }

        private void ctlFirstNameTextBox_Validated(object sender, EventArgs e)
        {
            FName = ctlFirstNamePicker.Text;
        }

        private void ctlFirstNamePicker_Validating(object sender, CancelEventArgs e)
        {
            if (ctlFirstNamePicker == null)
            {
                ctlUserErrorProvider.SetError(ctlFirstNamePicker, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                ctlUserErrorProvider.SetError(ctlFirstNamePicker, string.Empty);
                e.Cancel = false;
            }
        }

        private void ctlSecNamePicker_Validating(object sender, CancelEventArgs e)
        {
            if (ctlSecNamePicker == null)
            {
                ctlUserErrorProvider.SetError(ctlSecNamePicker, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                ctlUserErrorProvider.SetError(ctlSecNamePicker, string.Empty);
                e.Cancel = false;
            }
        }

        private void ctlSecNamePicker_Validated(object sender, EventArgs e)
        {
            LName = ctlSecNamePicker.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;

            var RewardNames = new List<string>();

            foreach (string item in ctlRewardsCheckBox.CheckedItems)
            {
                RewardNames.Add(item);
            }

            Rewards = RewardNames.Select(c => new Reward { Title = c}).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ctlUserDateTimePicker_Validated(object sender, EventArgs e)
        {
            Date = ctlUserDateTimePicker.Value;
        }
    }
}
