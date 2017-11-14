using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hafala_Hub
{
    public partial class Page_AlertsArchive : UserControl
    {
        Point lastClick;
        public static string passingText;
        public static string passingAlertGroup;
        public static string passingPath;
        public Page_AlertsArchive()
        {
            InitializeComponent();
        }
        private static string DirectoryPath = @"E:\DB";
        private static string[] names = Directory.GetFiles(DirectoryPath, "*.txt");
        private void button1_Click(object sender, EventArgs e)
        {
            New_Alert NewAlert = new New_Alert();
            NewAlert.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            foreach (string name in names)
            {
                AlertGroupList.Items.Add(Path.GetFileNameWithoutExtension(name));
            }
            panel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string desired = SearchTxtBox.Text;
            bool flag = File.Exists(DirectoryPath + @"\" +desired +".txt");
            if (flag)
            {
                string AlertText = File.ReadAllText(DirectoryPath + @"\" +SearchTxtBox.Text + ".txt");
                passingText = AlertText;
                passingAlertGroup = SearchTxtBox.Text;
                passingPath = DirectoryPath + SearchTxtBox.Text + ".txt";
                Alert_Display alert_Display = new Alert_Display();
                alert_Display.Show();
            }
            else
            {
                MessageBox.Show("The alertgroup you have inserted is either wrong or doesn't exist yet in the archive."
                    , "oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (AlertGroupList.SelectedItem == null)
            {
                return;
            }
            string curAlertGroup =AlertGroupList.SelectedItem.ToString();
            string AlertText = File.ReadAllText(DirectoryPath + @"\" + curAlertGroup + ".txt");
            passingText = AlertText;
            passingAlertGroup = curAlertGroup;
            passingPath = DirectoryPath + curAlertGroup + ".txt";
            Alert_Display alert_Display = new Alert_Display();
            alert_Display.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AlertGroupList.Items.Clear();
            panel1.Visible = false;
        }

        private void ReadEditButton_MouseMove(object sender, MouseEventArgs e)
        {
            ReadEditButton.ForeColor = Color.DodgerBlue;
        }

        private void ReadEditButton_MouseDown(object sender, MouseEventArgs e)
        {
            ReadEditButton.ForeColor = Color.DodgerBlue;
        }

        private void AddButton_MouseDown(object sender, MouseEventArgs e)
        {
            AddButton.ForeColor = Color.DodgerBlue;
        }

        private void AddButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.ForeColor = Color.DodgerBlue;
        }

        private void ReadEditButton_MouseLeave(object sender, EventArgs e)
        {
            ReadEditButton.ForeColor = Color.DimGray;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.DimGray;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            New_Alert NewAlert = new New_Alert();
            NewAlert.Show();
        }

        private void SearchOrEditImageButton_Click(object sender, EventArgs e)
        {
            foreach (string name in names)
            {
                AlertGroupList.Items.Add(Path.GetFileNameWithoutExtension(name));
            }
            panel1.Show();
        }

        private void SearchOrEditImageButton_MouseMove(object sender, MouseEventArgs e)
        {
            ReadEditButton.ForeColor = Color.DodgerBlue;
        }

        private void SearchOrEditImageButton_MouseLeave(object sender, EventArgs e)
        {
            ReadEditButton.ForeColor = Color.DimGray;
        }

        private void SearchOrEditImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            ReadEditButton.ForeColor = Color.DodgerBlue;
        }

        private void AddFileImageButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.ForeColor = Color.DodgerBlue;

        }

        private void AddFileImageButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.DimGray;

        }

        private void AddFileImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            AddButton.ForeColor = Color.DodgerBlue;

        }
    }
}
