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
    public partial class OfficeHours_Form : Form
    {
        private TeachingAssistant assistant;

        public OfficeHours_Form(ref TeachingAssistant user)
        {
            this.assistant = user;
            InitializeComponent();
        }

        public OfficeHours_Form()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if ((hour_from.Text).All(char.IsDigit) && (hour_to.Text).All(char.IsDigit) && (minute_from.Text).All(char.IsDigit) && (minute_to.Text).All(char.IsDigit))
                if (int.Parse(hour_from.Text) < int.Parse(hour_to.Text) || (int.Parse(hour_from.Text) == int.Parse(hour_to.Text) && int.Parse(minute_from.Text) < int.Parse(minute_to.Text)))
                {
                   // assistant.OfficeHoursFrom = new DateTime(0, 0, 0, int.Parse(hour_from.Text), int.Parse(minute_from.Text), 0);
                   // assistant.OfficeHoursTo = new DateTime(0, 0, 0, int.Parse(hour_to.Text), int.Parse(minute_to.Text), 0);
                    MessageBox.Show("office hours saved");
                    this.Close();
                }
                else
                    MessageBox.Show("Wrong entery(ies), try again please.");
            else
                MessageBox.Show("Wrong entery(ies), try again please.");
        }

        private void OfficeHours_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
