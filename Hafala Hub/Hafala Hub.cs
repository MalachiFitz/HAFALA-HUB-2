using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Hafala_Hub
{
    public partial class HafalaHub : Form
    {
        Point lastClick;
        public HafalaHub()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void UpperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void UpperPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void UpperExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        
        private void MenuButton_CheckedChanged(object sender, EventArgs e)
        {
            MenuButton.ForeColor = Color.DodgerBlue;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DimGray;
            page_Menu1.BringToFront();
        }

        private void AlertsArchiveButton_CheckedChanged(object sender, EventArgs e)
        {
            AlertsArchiveButton.ForeColor = Color.DodgerBlue;
            MenuButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DimGray;
            page_AlertsArchive1.BringToFront();
        }

        private void FSAutoButton_CheckedChanged(object sender, EventArgs e)
        {
            FSAutoButton.ForeColor = Color.DodgerBlue;
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DimGray;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            MenuButton.ForeColor = Color.DimGray;
            page_FSAuto1.BringToFront();
        }

        private void ContactListButton_CheckedChanged(object sender, EventArgs e)
        {
            ContactListButton.ForeColor = Color.DodgerBlue;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DimGray;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            MenuButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            page_Contactlist1.BringToFront();
        }

        private void ToolsButton_CheckedChanged(object sender, EventArgs e)
        {
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DodgerBlue;
            ExitButton.ForeColor = Color.DimGray;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            MenuButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            page_Tools1.BringToFront();
        }

        private void ExitButton_CheckedChanged(object sender, EventArgs e)
        {
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DodgerBlue;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            MenuButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            Application.Exit();
        }

        private void UpperMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }
    }
}