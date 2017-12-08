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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctlFNamePicker = new System.Windows.Forms.TextBox();
            this.ctlLnamePicker = new System.Windows.Forms.TextBox();
            this.ctlDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ctlErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctlErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlRewardsCheckBox
            // 
            this.ctlRewardsCheckBox.FormattingEnabled = true;
            this.ctlRewardsCheckBox.Location = new System.Drawing.Point(12, 165);
            this.ctlRewardsCheckBox.Name = "ctlRewardsCheckBox";
            this.ctlRewardsCheckBox.Size = new System.Drawing.Size(382, 193);
            this.ctlRewardsCheckBox.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(186, 365);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 48);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(293, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 48);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctlFNamePicker
            // 
            this.ctlFNamePicker.Location = new System.Drawing.Point(139, 34);
            this.ctlFNamePicker.Name = "ctlFNamePicker";
            this.ctlFNamePicker.Size = new System.Drawing.Size(212, 26);
            this.ctlFNamePicker.TabIndex = 3;
            this.ctlFNamePicker.Validating += new System.ComponentModel.CancelEventHandler(this.ctlFNamePicker_Validating);
            this.ctlFNamePicker.Validated += new System.EventHandler(this.ctlFNamePicker_Validated);
            // 
            // ctlLnamePicker
            // 
            this.ctlLnamePicker.Location = new System.Drawing.Point(139, 69);
            this.ctlLnamePicker.Name = "ctlLnamePicker";
            this.ctlLnamePicker.Size = new System.Drawing.Size(212, 26);
            this.ctlLnamePicker.TabIndex = 4;
            this.ctlLnamePicker.Validating += new System.ComponentModel.CancelEventHandler(this.ctlLnamePicker_Validating);
            this.ctlLnamePicker.Validated += new System.EventHandler(this.ctlLnamePicker_Validated);
            // 
            // ctlDatePicker
            // 
            this.ctlDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ctlDatePicker.Location = new System.Drawing.Point(139, 101);
            this.ctlDatePicker.Name = "ctlDatePicker";
            this.ctlDatePicker.Size = new System.Drawing.Size(212, 26);
            this.ctlDatePicker.TabIndex = 5;
            // 
            // ctlErrorProvider
            // 
            this.ctlErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ctlErrorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Birth date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rewards:";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 425);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlDatePicker);
            this.Controls.Add(this.ctlLnamePicker);
            this.Controls.Add(this.ctlFNamePicker);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctlRewardsCheckBox);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ctlRewardsCheckBox;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox ctlFNamePicker;
        private System.Windows.Forms.TextBox ctlLnamePicker;
        private System.Windows.Forms.DateTimePicker ctlDatePicker;
        private System.Windows.Forms.ErrorProvider ctlErrorProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}