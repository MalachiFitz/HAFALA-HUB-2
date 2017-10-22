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

        public static string passingText;
        public static string passingAlertGroup;
        public static string passingPath;
        public Page_AlertsArchive()
        {
            
            InitializeComponent();
        }
        private static string directory = @"c:\users\admin\db";
        private static string[] names = Directory.GetFiles(directory, "*.txt");
        private void button1_Click(object sender, EventArgs e)
        {
            New_Alert NewAlert = new New_Alert();
            NewAlert.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            foreach (string name in names)
            {
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(name));
            }
            panel1.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string desired = textBox1.Text;
            bool flag = File.Exists(directory +@"\" +desired +".txt");
            if (flag)
            {
                string AlertText = File.ReadAllText(@"c:\users\admin\db\" + textBox1.Text + ".txt");
                passingText = AlertText;
                passingAlertGroup = textBox1.Text;
                passingPath = @"C:\users\admin\db\" + textBox1.Text + ".txt";
                Alert_Display alert_Display = new Alert_Display();
                alert_Display.Show();
            }
            else
            {
                MessageBox.Show("The alertgroup you have inserted is either wrong or doesn't exist yet in the archive."
                    , "oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }
            string curAlertGroup =listBox1.SelectedItem.ToString();
            string AlertText = File.ReadAllText(@"c:\users\admin\db\" + curAlertGroup + ".txt");
            passingText = AlertText;
            passingAlertGroup = curAlertGroup;
            passingPath = @"C:\users\admin\db\" + curAlertGroup + ".txt";
            Alert_Display alert_Display = new Alert_Display();
            alert_Display.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            panel1.Visible = false;
        }
    }
}
