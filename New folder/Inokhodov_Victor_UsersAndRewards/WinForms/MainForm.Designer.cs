namespace WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctlUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.ctlUserContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctlRewardDataGridView = new System.Windows.Forms.DataGridView();
            this.ctlRewardContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRewardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRewardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.ctlTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsersDataGridView)).BeginInit();
            this.ctlUserContextMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlRewardDataGridView)).BeginInit();
            this.ctlRewardContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.addNewRewardToolStripMenuItem,
            this.toolStripMenuItem2,
            this.updateUserToolStripMenuItem,
            this.updateRewardToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteUserToolStripMenuItem,
            this.deleteRewardToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.addNewUserToolStripMenuItem.Text = "Add new user...";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // addNewRewardToolStripMenuItem
            // 
            this.addNewRewardToolStripMenuItem.Name = "addNewRewardToolStripMenuItem";
            this.addNewRewardToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.addNewRewardToolStripMenuItem.Text = "Add new reward...";
            this.addNewRewardToolStripMenuItem.Click += new System.EventHandler(this.addNewRewardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(235, 6);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.updateUserToolStripMenuItem.Text = "Update user";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // updateRewardToolStripMenuItem
            // 
            this.updateRewardToolStripMenuItem.Name = "updateRewardToolStripMenuItem";
            this.updateRewardToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.updateRewardToolStripMenuItem.Text = "Update reward";
            this.updateRewardToolStripMenuItem.Click += new System.EventHandler(this.updateRewardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(235, 6);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.deleteUserToolStripMenuItem.Text = "Delete user";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // deleteRewardToolStripMenuItem
            // 
            this.deleteRewardToolStripMenuItem.Name = "deleteRewardToolStripMenuItem";
            this.deleteRewardToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.deleteRewardToolStripMenuItem.Text = "Delete reward";
            this.deleteRewardToolStripMenuItem.Click += new System.EventHandler(this.deleteRewardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(235, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ctlTabControl
            // 
            this.ctlTabControl.Controls.Add(this.tabPage1);
            this.ctlTabControl.Controls.Add(this.tabPage2);
            this.ctlTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTabControl.Location = new System.Drawing.Point(0, 33);
            this.ctlTabControl.Name = "ctlTabControl";
            this.ctlTabControl.SelectedIndex = 0;
            this.ctlTabControl.Size = new System.Drawing.Size(618, 391);
            this.ctlTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctlUsersDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(610, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ctlUsersDataGridView
            // 
            this.ctlUsersDataGridView.AllowUserToAddRows = false;
            this.ctlUsersDataGridView.AllowUserToDeleteRows = false;
            this.ctlUsersDataGridView.AllowUserToResizeRows = false;
            this.ctlUsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctlUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlUsersDataGridView.ContextMenuStrip = this.ctlUserContextMenu;
            this.ctlUsersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlUsersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ctlUsersDataGridView.Name = "ctlUsersDataGridView";
            this.ctlUsersDataGridView.ReadOnly = true;
            this.ctlUsersDataGridView.RowTemplate.Height = 28;
            this.ctlUsersDataGridView.Size = new System.Drawing.Size(604, 352);
            this.ctlUsersDataGridView.TabIndex = 0;
            // 
            // ctlUserContextMenu
            // 
            this.ctlUserContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctlUserContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.updateUserToolStripMenuItem1,
            this.deleteUserToolStripMenuItem1});
            this.ctlUserContextMenu.Name = "ctlUserContextMenu";
            this.ctlUserContextMenu.Size = new System.Drawing.Size(193, 94);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.addUserToolStripMenuItem.Text = "Add user...";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // updateUserToolStripMenuItem1
            // 
            this.updateUserToolStripMenuItem1.Name = "updateUserToolStripMenuItem1";
            this.updateUserToolStripMenuItem1.Size = new System.Drawing.Size(192, 30);
            this.updateUserToolStripMenuItem1.Text = "Update user...";
            this.updateUserToolStripMenuItem1.Click += new System.EventHandler(this.updateUserToolStripMenuItem1_Click);
            // 
            // deleteUserToolStripMenuItem1
            // 
            this.deleteUserToolStripMenuItem1.Name = "deleteUserToolStripMenuItem1";
            this.deleteUserToolStripMenuItem1.Size = new System.Drawing.Size(192, 30);
            this.deleteUserToolStripMenuItem1.Text = "Delete user";
            this.deleteUserToolStripMenuItem1.Click += new System.EventHandler(this.deleteUserToolStripMenuItem1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctlRewardDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rewards";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctlRewardDataGridView
            // 
            this.ctlRewardDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctlRewardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlRewardDataGridView.ContextMenuStrip = this.ctlRewardContextMenu;
            this.ctlRewardDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlRewardDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ctlRewardDataGridView.Name = "ctlRewardDataGridView";
            this.ctlRewardDataGridView.RowTemplate.Height = 28;
            this.ctlRewardDataGridView.Size = new System.Drawing.Size(604, 352);
            this.ctlRewardDataGridView.TabIndex = 0;
            // 
            // ctlRewardContextMenu
            // 
            this.ctlRewardContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctlRewardContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRewardToolStripMenuItem,
            this.updateRewardToolStripMenuItem1,
            this.deleteRewardToolStripMenuItem1});
            this.ctlRewardContextMenu.Name = "ctlRewardContextMenu";
            this.ctlRewardContextMenu.Size = new System.Drawing.Size(214, 94);
            // 
            // addRewardToolStripMenuItem
            // 
            this.addRewardToolStripMenuItem.Name = "addRewardToolStripMenuItem";
            this.addRewardToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.addRewardToolStripMenuItem.Text = "Add reward...";
            this.addRewardToolStripMenuItem.Click += new System.EventHandler(this.addRewardToolStripMenuItem_Click);
            // 
            // updateRewardToolStripMenuItem1
            // 
            this.updateRewardToolStripMenuItem1.Name = "updateRewardToolStripMenuItem1";
            this.updateRewardToolStripMenuItem1.Size = new System.Drawing.Size(213, 30);
            this.updateRewardToolStripMenuItem1.Text = "Update reward...";
            this.updateRewardToolStripMenuItem1.Click += new System.EventHandler(this.updateRewardToolStripMenuItem1_Click);
            // 
            // deleteRewardToolStripMenuItem1
            // 
            this.deleteRewardToolStripMenuItem1.Name = "deleteRewardToolStripMenuItem1";
            this.deleteRewardToolStripMenuItem1.Size = new System.Drawing.Size(213, 30);
            this.deleteRewardToolStripMenuItem1.Text = "Delete reward";
            this.deleteRewardToolStripMenuItem1.Click += new System.EventHandler(this.deleteRewardToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 424);
            this.Controls.Add(this.ctlTabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Users and Rewards";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ctlTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsersDataGridView)).EndInit();
            this.ctlUserContextMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlRewardDataGridView)).EndInit();
            this.ctlRewardContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRewardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl ctlTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ctlUsersDataGridView;
        private System.Windows.Forms.DataGridView ctlRewardDataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRewardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRewardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip ctlUserContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip ctlRewardContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addRewardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRewardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteRewardToolStripMenuItem1;
    }
}

