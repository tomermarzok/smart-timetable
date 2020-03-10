using Project_Team_20.TeachingAssistant_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Team_20
{
    public partial class TeachingAssist_Form : Form
    {
        private NumOfDays_Form NumOfDaysForm;
        private SemestersToTeach_Form SemesterToTeachForm;
        private OfficeHours_Form OfficeHoursForm;
        private TeachingAssistant teachingAssist;
        public TeachingAssist_Form()
        {
            teachingAssist = null;
            InitializeComponent();
        }

        private void NumOfDays_button_Click(object sender, EventArgs e)
        {
            this.NumOfDaysForm = new NumOfDays_Form();
            this.Hide();
            //NumOfDaysForm.FormClosed += new FormClosedEventHandler(NumOfDaysForm_FormClosed);
            NumOfDaysForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            NumOfDaysForm.ShowDialog();
        }

        private void DaysToTeach_button_Click(object sender, EventArgs e)
        {

        }

        private void SemestersToTeach_button_Click(object sender, EventArgs e)
        {
            this.SemesterToTeachForm = new SemestersToTeach_Form();
            this.Hide();
            //SemesterToTeachForm.FormClosed += new FormClosedEventHandler(SemesterToTeachForm_FormClosed);
            SemesterToTeachForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            SemesterToTeachForm.ShowDialog();

        }

        private void ChooceOfficeHours_button_Click(object sender, EventArgs e)
        {
            //need to add     if(מערכת שעות exist)
            this.OfficeHoursForm = new OfficeHours_Form();
            this.Hide();
            //OfficeHoursForm.FormClosed += new FormClosedEventHandler(OfficeHoursForm_FormClosed);
            OfficeHoursForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            OfficeHoursForm.ShowDialog();
        }

        private void ChangeOfficeHours_button_Click(object sender, EventArgs e)
        {
            //need to add     if(מערכת שעות exist)
            this.OfficeHoursForm = new OfficeHours_Form();
            this.Hide();
            //OfficeHoursForm.FormClosed += new FormClosedEventHandler(OfficeHoursForm_FormClosed);
            OfficeHoursForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            OfficeHoursForm.ShowDialog();
        }

        private void AddNewTeachingAssist_button_Click(object sender, EventArgs e)
        {
            /*AddNewTeachingAssistantForm regForm = new AddNewTeachingAssistantForm();
            regForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            regForm.ShowDialog();
            regForm.CallBasicUserRegisteration();
            //regForm = null;
            */
            this.Hide();

            //BasicUser newUser = null;
            //BasicUser_Registration_Form regForm = new BasicUser_Registration_Form(ref newUser);
            this.teachingAssist = new TeachingAssistant();
            this.teachingAssist.FirstName = "empty";
            BasicUser temp = (BasicUser)this.teachingAssist;
            BasicUser_Registration_Form regForm = new BasicUser_Registration_Form(ref temp);
            regForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            regForm.ShowDialog();

            if(temp != null)
            {
                String tempt = "The new user details: FirstName:" + temp.FirstName + ", lastname:" + temp.LastName + ",password:" + temp.Password;
                MessageBox.Show(tempt);
                // -------------------------------------------------------------------

                teachingAssistantTableTableAdapter.Insert(temp.FirstName, temp.LastName, temp.Id, temp.Age, temp.Username, temp.Password, null, null, null, 0, 0, null, null, null);



                /*ProjectDataBaseDataSet test = new ProjectDataBaseDataSet();
                //test.TeachingAssistantTable.
                test.TeachingAssistantTable.InitVars();
                
                                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    int i = 0;
                    string sql = null;

                sql = String.Format("INSERT INTO TeachingAssistantTable (firstName, lastName, id, age, userName,password) VALUES(%s, %s, %s, %d, %s, %s)", temp.FirstName, temp.LastName, temp.Id, temp.Age, temp.Username, temp.Password);
                //sql = "SELECT * FROM TeachingAssistantTable";

                command = new SqlCommand(sql, conn);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    adapter.Dispose();
                    command.Dispose();

                    String result = "";
                    for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        result+= (ds.Tables[0].Rows[i].ItemArray[0] 
                            + "--" + ds.Tables[0].Rows[i].ItemArray[1] 
                            + "--" + ds.Tables[0].Rows[i].ItemArray[2] 
                            + "--" + ds.Tables[0].Rows[i].ItemArray[3]
                            + "--" + ds.Tables[0].Rows[i].ItemArray[4]
                            + "--" + ds.Tables[0].Rows[i].ItemArray[5]
                            + "\n");

                    }
                    */
                // --------------------------------------------------------------------
            }            
        }

        private void FormClosedHandling(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Close();
            sender = null;
            this.Show();           
        }

        private void teachingAssistantTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachingAssistantTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectDataBaseDataSet1);

        }

        private void TeachingAssist_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataBaseDataSet1.TeachingAssistantTable' table. You can move, or remove it, as needed.
            this.teachingAssistantTableTableAdapter.Fill(this.projectDataBaseDataSet1.TeachingAssistantTable);

        }


        /*private void SemesterToTeachForm_FormClosed(object sender, FormClosedEventArgs e)
         {
             this.SemesterToTeachForm.Close();
             this.SemesterToTeachForm = null;
             this.Show();
         }*/

        /*
        private void OfficeHoursForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.OfficeHoursForm.Close();
            this.OfficeHoursForm = null;
            this.Show();
        }
        */
        /*
        private void NumOfDaysForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.NumOfDaysForm.Close();
            this.NumOfDaysForm = null;
            this.Show();
        }
        */
    }


}
