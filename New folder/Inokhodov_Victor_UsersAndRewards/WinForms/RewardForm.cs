using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Entities;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class RewardForm : Form
    {
        private static Reward Reward = new Reward();
        public string Title;
        public string Description;

        public RewardForm()
        {
            Reward.Title = "";
            Reward.Description = "";

            InitializeComponent();
        }

        public RewardForm(Reward reward)
        {
            Reward.Title = reward.Title;
            Reward.Description = reward.Description;

            InitializeComponent();
        }

        private void ctlTitlePicker_Validating(object sender, CancelEventArgs e)
        {
            string input = ctlTitlePicker.Text;

            if (String.IsNullOrEmpty(input))
            {
                ctlErrorProvider.SetError(ctlTitlePicker, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                ctlErrorProvider.SetError(ctlTitlePicker, String.Empty);
                e.Cancel = false;
            }
        }

        private void ctlTitlePicker_Validated(object sender, EventArgs e)
        {
            Title = ctlTitlePicker.Text;
        }

        private void ctlDescriptionPicker_Validated(object sender, EventArgs e)
        {
            Description = ctlDescriptionPicker.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
        }

        private void RewardForm_Load(object sender, EventArgs e)
        {
            ctlDescriptionPicker.Text = Reward.Description;
            ctlTitlePicker.Text = Reward.Title;
        }
    }
}
