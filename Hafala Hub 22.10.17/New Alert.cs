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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (textBox1.Text == "")
                return;
            if (textBox2.Text == "")
            {

                result = MessageBox.Show("Are you sure you can't write a few words about the alert?", "Description", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                    return;
            }
            result = MessageBox.Show("Are you have finished writing everything you need?", "Sure?" ,MessageBoxButtons.YesNo ,MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            String AlertGroup = textBox1.Text;
            String DBPath = @"c:\Users\Admin\DB";
            String Path = DBPath + @"\" + AlertGroup+".txt";
            String text = "Alert Description:" + "\r\n" +  textBox2.Text + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Suggested Solution: " + "\r\n" + textBox3.Text;
            
            File.WriteAllText(Path, text);
            MessageBox.Show("Your alert has been added", "New Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_Alert_Load(object sender, EventArgs e)
        {

        }
    } 
}
