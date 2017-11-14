namespace Hafala_Hub
{
    partial class Page_AlertsArchive
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_AlertsArchive));
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ReadEditButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.BackButton1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AlertGroupList = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.AddFileImageButton = new System.Windows.Forms.PictureBox();
            this.SearchOrEditImageButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddFileImageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchOrEditImageButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(166, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alerts Archive";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.DimGray;
            this.AddButton.Location = new System.Drawing.Point(89, 193);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(148, 33);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add a new alert";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            this.AddButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseDown);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            this.AddButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseMove);
            // 
            // ReadEditButton
            // 
            this.ReadEditButton.BackColor = System.Drawing.Color.Transparent;
            this.ReadEditButton.FlatAppearance.BorderSize = 0;
            this.ReadEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReadEditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReadEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadEditButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadEditButton.ForeColor = System.Drawing.Color.DimGray;
            this.ReadEditButton.Location = new System.Drawing.Point(475, 186);
            this.ReadEditButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReadEditButton.Name = "ReadEditButton";
            this.ReadEditButton.Size = new System.Drawing.Size(262, 46);
            this.ReadEditButton.TabIndex = 3;
            this.ReadEditButton.Text = "Search an existing alert or Edit ";
            this.ReadEditButton.UseVisualStyleBackColor = false;
            this.ReadEditButton.Click += new System.EventHandler(this.button2_Click);
            this.ReadEditButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReadEditButton_MouseDown);
            this.ReadEditButton.MouseLeave += new System.EventHandler(this.ReadEditButton_MouseLeave);
            this.ReadEditButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReadEditButton_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OpenFileButton);
            this.panel1.Controls.Add(this.BackButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SearchTxtBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 583);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(322, 492);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(108, 46);
            this.OpenFileButton.TabIndex = 2;
            this.OpenFileButton.Text = "Open";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // BackButton1
            // 
            this.BackButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.BackButton1.FlatAppearance.BorderSize = 0;
            this.BackButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BackButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BackButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton1.Location = new System.Drawing.Point(30, 27);
            this.BackButton1.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton1.Name = "BackButton1";
            this.BackButton1.Size = new System.Drawing.Size(96, 42);
            this.BackButton1.TabIndex = 3;
            this.BackButton1.Text = "back";
            this.BackButton1.UseVisualStyleBackColor = false;
            this.BackButton1.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AlertGroupList);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(248, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 313);
            this.panel2.TabIndex = 7;
            // 
            // AlertGroupList
            // 
            this.AlertGroupList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlertGroupList.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlertGroupList.FormattingEnabled = true;
            this.AlertGroupList.Location = new System.Drawing.Point(0, 0);
            this.AlertGroupList.Margin = new System.Windows.Forms.Padding(2);
            this.AlertGroupList.Name = "AlertGroupList";
            this.AlertGroupList.Size = new System.Drawing.Size(269, 312);
            this.AlertGroupList.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-184, 0);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(658, 398);
            this.textBox2.TabIndex = 0;
            this.textBox2.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(512, 97);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(56, 19);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alert group:";
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(275, 96);
            this.SearchTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(223, 20);
            this.SearchTxtBox.TabIndex = 4;
            // 
            // AddFileImageButton
            // 
            this.AddFileImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFileImageButton.Image = ((System.Drawing.Image)(resources.GetObject("AddFileImageButton.Image")));
            this.AddFileImageButton.Location = new System.Drawing.Point(100, 237);
            this.AddFileImageButton.Name = "AddFileImageButton";
            this.AddFileImageButton.Size = new System.Drawing.Size(161, 201);
            this.AddFileImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddFileImageButton.TabIndex = 5;
            this.AddFileImageButton.TabStop = false;
            this.AddFileImageButton.Click += new System.EventHandler(this.pictureBox1_Click);
            this.AddFileImageButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddFileImageButton_MouseDown);
            this.AddFileImageButton.MouseLeave += new System.EventHandler(this.AddFileImageButton_MouseLeave);
            this.AddFileImageButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddFileImageButton_MouseMove);
            // 
            // SearchOrEditImageButton
            // 
            this.SearchOrEditImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchOrEditImageButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchOrEditImageButton.Image")));
            this.SearchOrEditImageButton.Location = new System.Drawing.Point(542, 237);
            this.SearchOrEditImageButton.Name = "SearchOrEditImageButton";
            this.SearchOrEditImageButton.Size = new System.Drawing.Size(161, 201);
            this.SearchOrEditImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchOrEditImageButton.TabIndex = 6;
            this.SearchOrEditImageButton.TabStop = false;
            this.SearchOrEditImageButton.Click += new System.EventHandler(this.SearchOrEditImageButton_Click);
            this.SearchOrEditImageButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchOrEditImageButton_MouseDown);
            this.SearchOrEditImageButton.MouseLeave += new System.EventHandler(this.SearchOrEditImageButton_MouseLeave);
            this.SearchOrEditImageButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchOrEditImageButton_MouseMove);
            // 
            // Page_AlertsArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchOrEditImageButton);
            this.Controls.Add(this.ReadEditButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddFileImageButton);
            this.Name = "Page_AlertsArchive";
            this.Size = new System.Drawing.Size(782, 583);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddFileImageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchOrEditImageButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ReadEditButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.ListBox AlertGroupList;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button BackButton1;
        private System.Windows.Forms.PictureBox AddFileImageButton;
        private System.Windows.Forms.PictureBox SearchOrEditImageButton;
    }
}
