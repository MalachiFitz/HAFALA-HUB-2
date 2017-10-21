// Loading libraries
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafala_Hub
{
    public partial class Form1 : Form
    {
        //
        // Variable Definition: -----------------------------------------------#
        //
        // Variables for form movement:
        // 1. 
        Point lastClick;
        //
        // 2.
        int Tog = 1;
        //
        // Colors varaibles:
        // 1. Main color (Blue)
        Color MainColor;
        // 2. Secondary color (Gray)
        Color SecondaryColor;
        // 3. Background color (WhiteSmoke)
        Color BackgroundColor;
        // 4. Regualar test color (Black)
        Color TextColor1;
        // 5. Iregular text color (Gray)
        Color TextColor2;
        // 6. Highlighted text color (Blue)
        Color HighlightedTextColor;
        //
        // End of Variable Definition -----------------------------------------#
        

        public Form1()
        {
            InitializeComponent();
        }


        // --------------------------------------------------------------------
        // Background mouse down form movement.
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
        // --------------------------------------------------------------------



        // --------------------------------------------------------------------
        // Upper panel mouse down form movement.
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
        // --------------------------------------------------------------------



        // --------------------------------------------------------------------
        // X button in the upper panel.
        private void UpperExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // --------------------------------------------------------------------



        // --------------------------------------------------------------------
        // Left panel mouse down form movement.
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
        // --------------------------------------------------------------------



        // --------------------------------------------------------------------
        // MenuButton clicked events:
        private void MenuButton_CheckedChanged(object sender, EventArgs e)
        {
            // Buttons' colors changes:
            MenuButton.ForeColor = Color.DodgerBlue;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DimGray;
            // Brings linked Page to front:
            page_Menu1.BringToFront();
        }
        // --------------------------------------------------------------------



        // --------------------------------------------------------------------
        // AlertsArchiveButton clicked events:
        private void AlertsArchiveButton_CheckedChanged(object sender, EventArgs e)
        {
            // Buttons' colors changes:
            AlertsArchiveButton.ForeColor = Color.DodgerBlue;
            MenuButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DimGray;
            // Brings linked Page to front:
            page_AlertsArchive1.BringToFront();
        }
        // --------------------------------------------------------------------



        // --------------------------------------------------------------------
        // FSAutoButton clicked events:
        private void FSAutoButton_CheckedChanged(object sender, EventArgs e)
        {
            // Buttons' colors changes:
            FSAutoButton.ForeColor = Color.DodgerBlue;
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DimGray;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            MenuButton.ForeColor = Color.DimGray;
            // Brings linked Page to front:
            page_FSAuto1.BringToFront();
        }
        // --------------------------------------------------------------------



        // --------------------------------------------------------------------
        // ContactListButton clicked events:
        private void ContactListButton_CheckedChanged(object sender, EventArgs e)
        {
            // Buttons' colors changes:
            ContactListButton.ForeColor = Color.DodgerBlue;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DimGray;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            MenuButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            // Brings linked Page to front:
            page_Contactlist1.BringToFront();
        }
        // --------------------------------------------------------------------



        // --------------------------------------------------------------------
        // ToolsButton clicked events:
        private void ToolsButton_CheckedChanged(object sender, EventArgs e)
        {
            // Buttons' colors changes:
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DodgerBlue;
            ExitButton.ForeColor = Color.DimGray;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            MenuButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            // Brings linked Page to front:
            page_Tools1.BringToFront();
        }
        // --------------------------------------------------------------------



        // --------------------------------------------------------------------
        // ExitButton clicked events:
        private void ExitButton_CheckedChanged(object sender, EventArgs e)
        {
            // Buttons' colors changes:
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DodgerBlue;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            MenuButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            // Brings linked Page to front:
            Application.Exit();
        }
        // --------------------------------------------------------------------


        // --------------------------------------------------------------------
        // UpperMinimizeButton clicked events:
        private void UpperMinimizeButton_Click(object sender, EventArgs e)
        {
            // Minimizes applictaion window:
            this.WindowState = FormWindowState.Minimized;
        }
        // --------------------------------------------------------------------



        // --------------------------------------------------------------------
        // Hafala logo image mouse down form movement.
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        // --------------------------------------------------------------------



        // --------------------------------------------------------------------
        // Upper panel label mouse down form movement.
        private void label1_MouseDown(object sender, MouseEventArgs e)
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
        // --------------------------------------------------------------------


    }
}