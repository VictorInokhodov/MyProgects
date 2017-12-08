namespace WinForms
{
    partial class RewardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlTitlePicker = new System.Windows.Forms.TextBox();
            this.ctlDescriptionPicker = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctlErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctlErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // ctlTitlePicker
            // 
            this.ctlTitlePicker.Location = new System.Drawing.Point(113, 54);
            this.ctlTitlePicker.Name = "ctlTitlePicker";
            this.ctlTitlePicker.Size = new System.Drawing.Size(170, 26);
            this.ctlTitlePicker.TabIndex = 2;
            this.ctlTitlePicker.Validating += new System.ComponentModel.CancelEventHandler(this.ctlTitlePicker_Validating);
            this.ctlTitlePicker.Validated += new System.EventHandler(this.ctlTitlePicker_Validated);
            // 
            // ctlDescriptionPicker
            // 
            this.ctlDescriptionPicker.Location = new System.Drawing.Point(12, 123);
            this.ctlDescriptionPicker.Name = "ctlDescriptionPicker";
            this.ctlDescriptionPicker.Size = new System.Drawing.Size(346, 162);
            this.ctlDescriptionPicker.TabIndex = 3;
            this.ctlDescriptionPicker.Text = "";
            this.ctlDescriptionPicker.Validated += new System.EventHandler(this.ctlDescriptionPicker_Validated);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(157, 303);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 47);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(265, 303);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 47);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctlErrorProvider
            // 
            this.ctlErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ctlErrorProvider.ContainerControl = this;
            // 
            // RewardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 362);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctlDescriptionPicker);
            this.Controls.Add(this.ctlTitlePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RewardForm";
            this.Text = "RewardForm";
            this.Load += new System.EventHandler(this.RewardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctlTitlePicker;
        private System.Windows.Forms.RichTextBox ctlDescriptionPicker;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider ctlErrorProvider;
    }
}