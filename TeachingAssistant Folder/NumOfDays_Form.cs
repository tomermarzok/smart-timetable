using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20.TeachingAssistant_Folder
{
    public partial class NumOfDays_Form : Form
    {
        private TeachingAssistant assistant;
    
        public NumOfDays_Form(ref TeachingAssistant user)
        {
            this.assistant = user;
            InitializeComponent();
        }

        public NumOfDays_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text).All(char.IsDigit))
            {

                if (int.Parse(textBox1.Text) > 0)
                {
                    //this.assistant.NumOfDaysToTeach=int.Parse(textBox1.Text);//save data
                    MessageBox.Show("office hours saved");
                    this.Close();
                }
                else
                    MessageBox.Show("Wrong entery, try again please.");
            }
            else
                MessageBox.Show("Wrong entery, try again please.");
   

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NumOfDays_Form_Load(object sender, EventArgs e)
        {
            
        }
    }
}
