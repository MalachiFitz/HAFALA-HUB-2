namespace Hafala_Hub
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UpperMinimizeButton = new System.Windows.Forms.Button();
            this.UpperExitButton = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.RadioButton();
            this.ToolsButton = new System.Windows.Forms.RadioButton();
            this.ContactListButton = new System.Windows.Forms.RadioButton();
            this.FSAutoButton = new System.Windows.Forms.RadioButton();
            this.AlertsArchiveButton = new System.Windows.Forms.RadioButton();
            this.MenuButton = new System.Windows.Forms.RadioButton();
            this.page_Tools1 = new Hafala_Hub.Page_Tools();
            this.page_FSAuto1 = new Hafala_Hub.Page_FSAuto();
            this.page_Contactlist1 = new Hafala_Hub.Page_Contactlist();
            this.page_AlertsArchive1 = new Hafala_Hub.Page_AlertsArchive();
            this.page_Menu1 = new Hafala_Hub.Page_Menu();
            this.UpperPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpperPanel.Controls.Add(this.label1);
            this.UpperPanel.Controls.Add(this.UpperMinimizeButton);
            this.UpperPanel.Controls.Add(this.UpperExitButton);
            this.UpperPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(1096, 42);
            this.UpperPanel.TabIndex = 0;
            this.UpperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpperPanel_MouseDown);
            this.UpperPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperPanel_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hafala Hub";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // UpperMinimizeButton
            // 
            this.UpperMinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.UpperMinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UpperMinimizeButton.FlatAppearance.BorderSize = 0;
            this.UpperMinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.UpperMinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.UpperMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpperMinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("UpperMinimizeButton.Image")));
            this.UpperMinimizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpperMinimizeButton.Location = new System.Drawing.Point(1013, -1);
            this.UpperMinimizeButton.Name = "UpperMinimizeButton";
            this.UpperMinimizeButton.Size = new System.Drawing.Size(41, 42);
            this.UpperMinimizeButton.TabIndex = 3;
            this.UpperMinimizeButton.UseVisualStyleBackColor = false;
            this.UpperMinimizeButton.Click += new System.EventHandler(this.UpperMinimizeButton_Click);
            // 
            // UpperExitButton
            // 
            this.UpperExitButton.BackColor = System.Drawing.Color.Transparent;
            this.UpperExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpperExitButton.BackgroundImage")));
            this.UpperExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UpperExitButton.FlatAppearance.BorderSize = 0;
            this.UpperExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.UpperExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.UpperExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpperExitButton.Location = new System.Drawing.Point(1055, 0);
            this.UpperExitButton.Name = "UpperExitButton";
            this.UpperExitButton.Size = new System.Drawing.Size(41, 42);
            this.UpperExitButton.TabIndex = 2;
            this.UpperExitButton.UseVisualStyleBackColor = false;
            this.UpperExitButton.Click += new System.EventHandler(this.UpperExitButton_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Controls.Add(this.pictureBox1);
            this.LeftPanel.Controls.Add(this.ExitButton);
            this.LeftPanel.Controls.Add(this.ToolsButton);
            this.LeftPanel.Controls.Add(this.ContactListButton);
            this.LeftPanel.Controls.Add(this.FSAutoButton);
            this.LeftPanel.Controls.Add(this.AlertsArchiveButton);
            this.LeftPanel.Controls.Add(this.MenuButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 42);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(314, 583);
            this.LeftPanel.TabIndex = 1;
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.LeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.DimGray;
            this.ExitButton.Location = new System.Drawing.Point(0, 489);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(314, 65);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.TabStop = true;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.CheckedChanged += new System.EventHandler(this.ExitButton_CheckedChanged);
            // 
            // ToolsButton
            // 
            this.ToolsButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ToolsButton.BackColor = System.Drawing.Color.White;
            this.ToolsButton.FlatAppearance.BorderSize = 0;
            this.ToolsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.ToolsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.ToolsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ToolsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsButton.ForeColor = System.Drawing.Color.DimGray;
            this.ToolsButton.Location = new System.Drawing.Point(0, 423);
            this.ToolsButton.Name = "ToolsButton";
            this.ToolsButton.Size = new System.Drawing.Size(314, 65);
            this.ToolsButton.TabIndex = 6;
            this.ToolsButton.TabStop = true;
            this.ToolsButton.Text = "Tools";
            this.ToolsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToolsButton.UseVisualStyleBackColor = false;
            this.ToolsButton.CheckedChanged += new System.EventHandler(this.ToolsButton_CheckedChanged);
            // 
            // ContactListButton
            // 
            this.ContactListButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ContactListButton.BackColor = System.Drawing.Color.White;
            this.ContactListButton.FlatAppearance.BorderSize = 0;
            this.ContactListButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.ContactListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.ContactListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ContactListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactListButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactListButton.ForeColor = System.Drawing.Color.DimGray;
            this.ContactListButton.Location = new System.Drawing.Point(0, 358);
            this.ContactListButton.Name = "ContactListButton";
            this.ContactListButton.Size = new System.Drawing.Size(314, 65);
            this.ContactListButton.TabIndex = 5;
            this.ContactListButton.TabStop = true;
            this.ContactListButton.Text = "Contacts List";
            this.ContactListButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ContactListButton.UseVisualStyleBackColor = false;
            this.ContactListButton.CheckedChanged += new System.EventHandler(this.ContactListButton_CheckedChanged);
            // 
            // FSAutoButton
            // 
            this.FSAutoButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.FSAutoButton.BackColor = System.Drawing.Color.White;
            this.FSAutoButton.FlatAppearance.BorderSize = 0;
            this.FSAutoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.FSAutoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.FSAutoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.FSAutoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FSAutoButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSAutoButton.ForeColor = System.Drawing.Color.DimGray;
            this.FSAutoButton.Location = new System.Drawing.Point(0, 293);
            this.FSAutoButton.Name = "FSAutoButton";
            this.FSAutoButton.Size = new System.Drawing.Size(314, 65);
            this.FSAutoButton.TabIndex = 4;
            this.FSAutoButton.TabStop = true;
            this.FSAutoButton.Text = "Filesystem Automation";
            this.FSAutoButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FSAutoButton.UseVisualStyleBackColor = false;
            this.FSAutoButton.CheckedChanged += new System.EventHandler(this.FSAutoButton_CheckedChanged);
            // 
            // AlertsArchiveButton
            // 
            this.AlertsArchiveButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.AlertsArchiveButton.BackColor = System.Drawing.Color.White;
            this.AlertsArchiveButton.FlatAppearance.BorderSize = 0;
            this.AlertsArchiveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.AlertsArchiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.AlertsArchiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.AlertsArchiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlertsArchiveButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertsArchiveButton.ForeColor = System.Drawing.Color.DimGray;
            this.AlertsArchiveButton.Location = new System.Drawing.Point(0, 228);
            this.AlertsArchiveButton.Name = "AlertsArchiveButton";
            this.AlertsArchiveButton.Size = new System.Drawing.Size(314, 65);
            this.AlertsArchiveButton.TabIndex = 3;
            this.AlertsArchiveButton.TabStop = true;
            this.AlertsArchiveButton.Text = "Alerts Archive";
            this.AlertsArchiveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AlertsArchiveButton.UseVisualStyleBackColor = false;
            this.AlertsArchiveButton.CheckedChanged += new System.EventHandler(this.AlertsArchiveButton_CheckedChanged);
            // 
            // MenuButton
            // 
            this.MenuButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.MenuButton.BackColor = System.Drawing.Color.White;
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.ForeColor = System.Drawing.Color.DimGray;
            this.MenuButton.Location = new System.Drawing.Point(0, 163);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(314, 65);
            this.MenuButton.TabIndex = 2;
            this.MenuButton.TabStop = true;
            this.MenuButton.Text = "Menu";
            this.MenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.CheckedChanged += new System.EventHandler(this.MenuButton_CheckedChanged);
            // 
            // page_Tools1
            // 
            this.page_Tools1.Location = new System.Drawing.Point(314, 42);
            this.page_Tools1.Name = "page_Tools1";
            this.page_Tools1.Size = new System.Drawing.Size(782, 583);
            this.page_Tools1.TabIndex = 6;
            // 
            // page_FSAuto1
            // 
            this.page_FSAuto1.Location = new System.Drawing.Point(314, 42);
            this.page_FSAuto1.Name = "page_FSAuto1";
            this.page_FSAuto1.Size = new System.Drawing.Size(782, 583);
            this.page_FSAuto1.TabIndex = 5;
            // 
            // page_Contactlist1
            // 
            this.page_Contactlist1.Location = new System.Drawing.Point(314, 42);
            this.page_Contactlist1.Name = "page_Contactlist1";
            this.page_Contactlist1.Size = new System.Drawing.Size(782, 583);
            this.page_Contactlist1.TabIndex = 4;
            // 
            // page_AlertsArchive1
            // 
            this.page_AlertsArchive1.Location = new System.Drawing.Point(314, 42);
            this.page_AlertsArchive1.Name = "page_AlertsArchive1";
            this.page_AlertsArchive1.Size = new System.Drawing.Size(782, 583);
            this.page_AlertsArchive1.TabIndex = 3;
            // 
            // page_Menu1
            // 
            this.page_Menu1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.page_Menu1.Location = new System.Drawing.Point(314, 42);
            this.page_Menu1.Name = "page_Menu1";
            this.page_Menu1.Size = new System.Drawing.Size(782, 583);
            this.page_Menu1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AccessibleDescription = "BackgroundForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1096, 625);
            this.Controls.Add(this.page_Menu1);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.page_Tools1);
            this.Controls.Add(this.page_FSAuto1);
            this.Controls.Add(this.page_Contactlist1);
            this.Controls.Add(this.page_AlertsArchive1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Hafala Hub";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Button UpperExitButton;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button UpperMinimizeButton;
        private System.Windows.Forms.RadioButton MenuButton;
        private System.Windows.Forms.RadioButton AlertsArchiveButton;
        private System.Windows.Forms.RadioButton ExitButton;
        private System.Windows.Forms.RadioButton ToolsButton;
        private System.Windows.Forms.RadioButton ContactListButton;
        private System.Windows.Forms.RadioButton FSAutoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Page_AlertsArchive page_AlertsArchive1;
        private Page_Contactlist page_Contactlist1;
        private Page_FSAuto page_FSAuto1;
        private Page_Tools page_Tools1;
        private Page_Menu page_Menu1;
    }
}

