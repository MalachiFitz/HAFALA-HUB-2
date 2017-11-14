using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hafala_Hub
{
    public partial class New_Alert : Form
    {
        public New_Alert()
        {
            InitializeComponent();
            AlertGroupTextbox.GotFocus += GotFocus.EventHandle(RemoveText);
            AlertGroupTextbox.LostFocus += LostFocus.EventHandle(AddText);

            public RemoveText(object sender, EventArgs e)
            {
                AlertGroupTextbox.Text = "";
            }

            public AddText(object sender, EventArgs e)
            {
                if (String.IsNullOrWhiteSpace(myTxtbx.Text))
                {
                    AlertGroupTextbox.Text = "Enter text here...";
                }
            }
        }

        private string AGTEXT = "Paste the alert group from the Panorama.";
        private string DESCTEXT = "Describe the alert so other operators will now what is the alert meaning...";
        private string SLNTEXT = "Provide 1 solution or more that will elimintate the problem.";
        
        private void SaveFile_Button_Click(object sender, EventArgs e)
        {
            if (AlertGroupTextbox.Text == AGTEXT || DescriptionTextbox.Text == DESCTEXT || SolutionsTextbox.Text == SLNTEXT)
            {
                return;
            }
            DialogResult result;
            if (AlertGroupTextbox.Text == "")
                return;
            if (DescriptionTextbox.Text == "")
            {

                result = MessageBox.Show("You have to write a description and add solutions.", "Saving Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                    return;
            }
            if (DescriptionTextbox.Text != "")
            {
                result = MessageBox.Show("Have you finished writing everything?" + "\r\n" + "Also, make sure your info is correct and valid.", "Confirm Saving?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                String AlertGroup = AlertGroupTextbox.Text;
                String DirectoryPath = @"E:\DB";
                String Path = DirectoryPath + @"\" + AlertGroup + ".txt";
                String text = "Alert Description:" + "\r\n" + DescriptionTextbox.Text + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Suggested Solution: " + "\r\n" + SolutionsTextbox.Text;

                File.WriteAllText(Path, text);
                MessageBox.Show("Your alert has been added", "New Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AlertGroupTextbox.Clear();
                DescriptionTextbox.Clear();
                SolutionsTextbox.Clear();
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        Point lastClick;
        private void New_Alert_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void New_Alert_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
    } 
}
