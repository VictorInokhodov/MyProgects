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
            this.ctlRewardsCheckBox = new System.Windows.Forms.CheckedListBox();
            this.ctlFName = new System.Windows.Forms.Label();
            this.ctlFirstNamePicker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlSecNamePicker = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlUserDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlUserErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUserErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlRewardsCheckBox
            // 
            this.ctlRewardsCheckBox.FormattingEnabled = true;
            this.ctlRewardsCheckBox.Location = new System.Drawing.Point(12, 187);
            this.ctlRewardsCheckBox.Name = "ctlRewardsCheckBox";
            this.ctlRewardsCheckBox.Size = new System.Drawing.Size(411, 193);
            this.ctlRewardsCheckBox.TabIndex = 0;
            // 
            // ctlFName
            // 
            this.ctlFName.AutoSize = true;
            this.ctlFName.Location = new System.Drawing.Point(27, 30);
            this.ctlFName.Name = "ctlFName";
            this.ctlFName.Size = new System.Drawing.Size(88, 20);
            this.ctlFName.TabIndex = 1;
            this.ctlFName.Text = "First name:";
            // 
            // ctlFirstNamePicker
            // 
            this.ctlFirstNamePicker.Location = new System.Drawing.Point(146, 27);
            this.ctlFirstNamePicker.Name = "ctlFirstNamePicker";
            this.ctlFirstNamePicker.Size = new System.Drawing.Size(220, 26);
            this.ctlFirstNamePicker.TabIndex = 2;
            this.ctlFirstNamePicker.Validating += new System.ComponentModel.CancelEventHandler(this.ctlFirstNamePicker_Validating);
            this.ctlFirstNamePicker.Validated += new System.EventHandler(this.ctlFirstNameTextBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Second name:";
            // 
            // ctlSecNamePicker
            // 
            this.ctlSecNamePicker.Location = new System.Drawing.Point(146, 79);
            this.ctlSecNamePicker.Name = "ctlSecNamePicker";
            this.ctlSecNamePicker.Size = new System.Drawing.Size(220, 26);
            this.ctlSecNamePicker.TabIndex = 4;
            this.ctlSecNamePicker.Validating += new System.ComponentModel.CancelEventHandler(this.ctlSecNamePicker_Validating);
            this.ctlSecNamePicker.Validated += new System.EventHandler(this.ctlSecNamePicker_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date of birth:";
            // 
            // ctlUserDateTimePicker
            // 
            this.ctlUserDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ctlUserDateTimePicker.Location = new System.Drawing.Point(146, 126);
            this.ctlUserDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.ctlUserDateTimePicker.Name = "ctlUserDateTimePicker";
            this.ctlUserDateTimePicker.Size = new System.Drawing.Size(220, 26);
            this.ctlUserDateTimePicker.TabIndex = 6;
            this.ctlUserDateTimePicker.Validated += new System.EventHandler(this.ctlUserDateTimePicker_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rewards:";
            // 
            // ctlUserErrorProvider
            // 
            this.ctlUserErrorProvider.ContainerControl = this;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(226, 386);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 40);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(328, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 39);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 432);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctlUserDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctlSecNamePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlFirstNamePicker);
            this.Controls.Add(this.ctlFName);
            this.Controls.Add(this.ctlRewardsCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlUserErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ctlRewardsCheckBox;
        private System.Windows.Forms.Label ctlFName;
        private System.Windows.Forms.TextBox ctlFirstNamePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctlSecNamePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ctlUserDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider ctlUserErrorProvider;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
    }
}