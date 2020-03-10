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
    public partial class SemestersToTeach_Form : Form
    {
        private TeachingAssistant assistant;

        public SemestersToTeach_Form()
        {
            InitializeComponent();
        }
        public SemestersToTeach_Form(ref TeachingAssistant assistant)
        {
            this.assistant = assistant;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SemestersToTeach_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;

            if (winter.Checked == true)
                flag++;
            if (spring.Checked == true)
                flag++;
            if (summer.Checked == true)
                flag++;
            if (flag == 2)
            {
                /*
                //Save data to teaching assistant
                Semester[] semestersToTeach = new Semester[2];
                int j = 0;
                if (winter.Checked == true)
                {
                    semestersToTeach[j] = Semester.First;
                    j++;
                }
                if (spring.Checked == true)
                {
                    semestersToTeach[j] = Semester.Second;
                    j++;
                }
                if (summer.Checked == true)
                {
                    semestersToTeach[j] = Semester.Third;
                    j++;
                }
                this.assistant.SemestersToTeach = semestersToTeach;
                */

                MessageBox.Show("office hours saved");
                this.Close();
            }
            if (flag != 2)
                MessageBox.Show("Wrong entery, try again please.");
        }
    }
}
