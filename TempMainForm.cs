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
    public partial class TempMainForm : Form
    {
        private BasicUser_Form basicUserForm;
        private BasicUser user;
        private TeachingAssist_Form teachingAssistForm;
        public TempMainForm()
        {
            InitializeComponent();
        }

        private void TempMainForm_Load(object sender, EventArgs e)
        {

        }

        private void BasicUser_button_Click(object sender, EventArgs e)
        {
            // ---------------
            user = new BasicUser("mai", "benami", "307889402", 22, "maibe", "benami24");

            // ---------------

            this.basicUserForm = new BasicUser_Form(ref user);
            this.Hide();
            basicUserForm.FormClosed += new FormClosedEventHandler(basicUserForm_FormClosed);
            basicUserForm.ShowDialog();
        }
        private void basicUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.basicUserForm.Close();
            this.basicUserForm = null;
            this.Show();
        }

        private void TeachingAssistant_Menu_Click(object sender, EventArgs e)
        {
            this.teachingAssistForm = new TeachingAssist_Form();
            this.Hide();
            teachingAssistForm.FormClosed += new FormClosedEventHandler(teachingAssistForm_FormClosed);
            teachingAssistForm.ShowDialog();
        }

        private void teachingAssistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.teachingAssistForm.Close();
            this.teachingAssistForm = null;
            this.Show();
        }

        private void TestSQLConnection_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=tcp:sce-group20-project.database.windows.net,1433;Database=ProjectDataBase;User ID=Group20@sce-group20-project;Password=gKrt@gyT;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection opened successfully.\n");

                    TempSQLConnectionTestForm temp = new TempSQLConnectionTestForm();
                    temp.ShowDialog();
                    /*
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    int i = 0;
                    string sql = null;

                    sql = "SELECT * FROM TeachingAssistantTable";

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

                    MessageBox.Show(result);
                    MessageBox.Show("Length = " + ds.Tables[0].Rows[0].ItemArray[0].ToString().Length);
                    */
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to open connection, shutting down.\n");
                    ex.GetType();
                    return;
                }
            }
        }
    }
}
