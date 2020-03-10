using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20
{
    public partial class BasicUser_Registration_Form : Form
    {
        private BasicUser basicUser;
        public BasicUser_Registration_Form(ref BasicUser user)
        {
            this.basicUser = user;
            //this.FormClosed += new FormClosedEventHandler();
            InitializeComponent();
        }


        private void Register_button_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (basicUser.EnterIntInput(FirstName_textBox.Text) == false)
            {
                FNameError_label.Show();
                flag = false;
            }
            if (basicUser.EnterIntInput(LastName_textBox.Text) == false)
            {
                LNameError_label.Show();
                flag = false;
            }
            if (basicUser.EnterIDInput(textBox1.Text) == false)
            {
                IDError_label.Show();
                flag = false;
            }

            int age;
            try
            {
                age = int.Parse(Age_textBox.Text);
                if (basicUser.EnterAgeInput(age) == false)
                {
                    AgeError_label.Show();
                    flag = false;
                }
            }
            catch (System.IO.IOException ex)
            {
                //Console.WriteLine("Error, your input isn't an integer({0}), try again please.\n", ex.GetType().ToString());
                AgeError_label.Show();
                flag = false;
                ex.GetType();
            }
            catch (Exception ex)
            {
                AgeError_label.Show();
                flag = false;
                ex.GetType();
                //Console.WriteLine("Unknown error ({0}), try again please.\n", ex.GetType().ToString());
            }
            if (basicUser.EnterUsernamePassInput(Username_textBox.Text) == false) //username
            {
                UsernameError_label.Show();
                flag = false;
            }
            if (basicUser.EnterUsernamePassInput(Password_textBox.Text) == false) // pass
            {
                PassError_label.Show();
                flag = false;
            }

            if (flag == false)
                MessageBox.Show("Wrong entery(ies), try again please.");
            else
            {
                MessageBox.Show("Registered successfully.");
                basicUser.FirstName = FirstName_textBox.Text;
                basicUser.LastName = LastName_textBox.Text;
                basicUser.Id = textBox1.Text;
                basicUser.Age = int.Parse(Age_textBox.Text);
                basicUser.Username = Username_textBox.Text;
                basicUser.Password = Password_textBox.Text;
                this.Close();
            }
        }
    }
}
