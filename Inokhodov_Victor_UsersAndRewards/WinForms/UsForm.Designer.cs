namespace WinForms
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctlRewardsListBox = new System.Windows.Forms.CheckedListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctlFName = new System.Windows.Forms.Label();
            this.ctlLName = new System.Windows.Forms.Label();
            this.ctlDate = new System.Windows.Forms.Label();
            this.ctlFNamePicker = new System.Windows.Forms.TextBox();
            this.ctlLNamePicker = new System.Windows.Forms.TextBox();
            this.ctlDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ctlErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctlErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlRewardsListBox
            // 
            this.ctlRewardsListBox.FormattingEnabled = true;
            this.ctlRewardsListBox.Location = new System.Drawing.Point(12, 177);
            this.ctlRewardsListBox.Name = "ctlRewardsListBox";
            this.ctlRewardsListBox.Size = new System.Drawing.Size(367, 172);
            this.ctlRewardsListBox.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(171, 355);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 45);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(278, 355);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctlFName
            // 
            this.ctlFName.AutoSize = true;
            this.ctlFName.Location = new System.Drawing.Point(12, 30);
            this.ctlFName.Name = "ctlFName";
            this.ctlFName.Size = new System.Drawing.Size(88, 20);
            this.ctlFName.TabIndex = 3;
            this.ctlFName.Text = "First name:";
            // 
            // ctlLName
            // 
            this.ctlLName.AutoSize = true;
            this.ctlLName.Location = new System.Drawing.Point(12, 65);
            this.ctlLName.Name = "ctlLName";
            this.ctlLName.Size = new System.Drawing.Size(88, 20);
            this.ctlLName.TabIndex = 4;
            this.ctlLName.Text = "Last name:";
            // 
            // ctlDate
            // 
            this.ctlDate.AutoSize = true;
            this.ctlDate.Location = new System.Drawing.Point(12, 102);
            this.ctlDate.Name = "ctlDate";
            this.ctlDate.Size = new System.Drawing.Size(82, 20);
            this.ctlDate.TabIndex = 5;
            this.ctlDate.Text = "Birth date:";
            // 
            // ctlFNamePicker
            // 
            this.ctlFNamePicker.Location = new System.Drawing.Point(120, 27);
            this.ctlFNamePicker.Name = "ctlFNamePicker";
            this.ctlFNamePicker.Size = new System.Drawing.Size(200, 26);
            this.ctlFNamePicker.TabIndex = 6;
            this.ctlFNamePicker.Validating += new System.ComponentModel.CancelEventHandler(this.ctlFNamePicker_Validating);
            this.ctlFNamePicker.Validated += new System.EventHandler(this.ctlFNamePicker_Validated);
            // 
            // ctlLNamePicker
            // 
            this.ctlLNamePicker.Location = new System.Drawing.Point(120, 62);
            this.ctlLNamePicker.Name = "ctlLNamePicker";
            this.ctlLNamePicker.Size = new System.Drawing.Size(200, 26);
            this.ctlLNamePicker.TabIndex = 7;
            this.ctlLNamePicker.Validating += new System.ComponentModel.CancelEventHandler(this.ctlLNamePicker_Validating);
            this.ctlLNamePicker.Validated += new System.EventHandler(this.ctlLNamePicker_Validated);
            // 
            // ctlDatePicker
            // 
            this.ctlDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ctlDatePicker.Location = new System.Drawing.Point(120, 97);
            this.ctlDatePicker.Name = "ctlDatePicker";
            this.ctlDatePicker.Size = new System.Drawing.Size(200, 26);
            this.ctlDatePicker.TabIndex = 8;
            // 
            // ctlErrorProvider
            // 
            this.ctlErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ctlErrorProvider.ContainerControl = this;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 412);
            this.Controls.Add(this.ctlDatePicker);
            this.Controls.Add(this.ctlLNamePicker);
            this.Controls.Add(this.ctlFNamePicker);
            this.Controls.Add(this.ctlDate);
            this.Controls.Add(this.ctlLName);
            this.Controls.Add(this.ctlFName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctlRewardsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ctlRewardsListBox;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label ctlFName;
        private System.Windows.Forms.Label ctlLName;
        private System.Windows.Forms.Label ctlDate;
        private System.Windows.Forms.TextBox ctlFNamePicker;
        private System.Windows.Forms.TextBox ctlLNamePicker;
        private System.Windows.Forms.DateTimePicker ctlDatePicker;
        private System.Windows.Forms.ErrorProvider ctlErrorProvider;
    }
}