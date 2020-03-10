namespace Project_Team_20
{
    partial class TeachingAssist_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CourseToTeach_button = new System.Windows.Forms.Button();
            this.DaysToTeach_button = new System.Windows.Forms.Button();
            this.HoursToTeach_button = new System.Windows.Forms.Button();
            this.TimeBetweenClassses_button = new System.Windows.Forms.Button();
            this.NumOfDays_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChooceOfficeHours_button = new System.Windows.Forms.Button();
            this.ChangeOfficeHours_button = new System.Windows.Forms.Button();
            this.PrintSchedule_button = new System.Windows.Forms.Button();
            this.searchLecturer_button = new System.Windows.Forms.Button();
            this.SearchTeachingAssist_button = new System.Windows.Forms.Button();
            this.SemestersToTeach_button = new System.Windows.Forms.Button();
            this.AddNewTeachingAssist_button = new System.Windows.Forms.Button();
            this.projectDataBaseDataSet1 = new Project_Team_20.ProjectDataBaseDataSet();
            this.teachingAssistantTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachingAssistantTableTableAdapter = new Project_Team_20.ProjectDataBaseDataSetTableAdapters.TeachingAssistantTableTableAdapter();
            this.tableAdapterManager = new Project_Team_20.ProjectDataBaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingAssistantTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseToTeach_button
            // 
            this.CourseToTeach_button.Location = new System.Drawing.Point(12, 29);
            this.CourseToTeach_button.Name = "CourseToTeach_button";
            this.CourseToTeach_button.Size = new System.Drawing.Size(150, 23);
            this.CourseToTeach_button.TabIndex = 0;
            this.CourseToTeach_button.Text = "Choose Courses To Teach";
            this.CourseToTeach_button.UseVisualStyleBackColor = true;
            // 
            // DaysToTeach_button
            // 
            this.DaysToTeach_button.Location = new System.Drawing.Point(12, 58);
            this.DaysToTeach_button.Name = "DaysToTeach_button";
            this.DaysToTeach_button.Size = new System.Drawing.Size(150, 23);
            this.DaysToTeach_button.TabIndex = 1;
            this.DaysToTeach_button.Text = "Choose Days To Teach";
            this.DaysToTeach_button.UseVisualStyleBackColor = true;
            this.DaysToTeach_button.Click += new System.EventHandler(this.DaysToTeach_button_Click);
            // 
            // HoursToTeach_button
            // 
            this.HoursToTeach_button.Location = new System.Drawing.Point(12, 87);
            this.HoursToTeach_button.Name = "HoursToTeach_button";
            this.HoursToTeach_button.Size = new System.Drawing.Size(150, 23);
            this.HoursToTeach_button.TabIndex = 2;
            this.HoursToTeach_button.Text = "Choose Hours To Teach";
            this.HoursToTeach_button.UseVisualStyleBackColor = true;
            // 
            // TimeBetweenClassses_button
            // 
            this.TimeBetweenClassses_button.Location = new System.Drawing.Point(12, 115);
            this.TimeBetweenClassses_button.Name = "TimeBetweenClassses_button";
            this.TimeBetweenClassses_button.Size = new System.Drawing.Size(150, 23);
            this.TimeBetweenClassses_button.TabIndex = 3;
            this.TimeBetweenClassses_button.Text = "Time Between Classes";
            this.TimeBetweenClassses_button.UseVisualStyleBackColor = true;
            // 
            // NumOfDays_button
            // 
            this.NumOfDays_button.Location = new System.Drawing.Point(12, 145);
            this.NumOfDays_button.Name = "NumOfDays_button";
            this.NumOfDays_button.Size = new System.Drawing.Size(150, 23);
            this.NumOfDays_button.TabIndex = 4;
            this.NumOfDays_button.Text = "Num Of Days To Teach";
            this.NumOfDays_button.UseVisualStyleBackColor = true;
            this.NumOfDays_button.Click += new System.EventHandler(this.NumOfDays_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teaching Assistance Preferences:";
            // 
            // ChooceOfficeHours_button
            // 
            this.ChooceOfficeHours_button.Location = new System.Drawing.Point(12, 203);
            this.ChooceOfficeHours_button.Name = "ChooceOfficeHours_button";
            this.ChooceOfficeHours_button.Size = new System.Drawing.Size(150, 23);
            this.ChooceOfficeHours_button.TabIndex = 7;
            this.ChooceOfficeHours_button.Text = "Chooce Office Hours";
            this.ChooceOfficeHours_button.UseVisualStyleBackColor = true;
            this.ChooceOfficeHours_button.Click += new System.EventHandler(this.ChooceOfficeHours_button_Click);
            // 
            // ChangeOfficeHours_button
            // 
            this.ChangeOfficeHours_button.Location = new System.Drawing.Point(12, 232);
            this.ChangeOfficeHours_button.Name = "ChangeOfficeHours_button";
            this.ChangeOfficeHours_button.Size = new System.Drawing.Size(150, 23);
            this.ChangeOfficeHours_button.TabIndex = 8;
            this.ChangeOfficeHours_button.Text = "Change Office Hours";
            this.ChangeOfficeHours_button.UseVisualStyleBackColor = true;
            this.ChangeOfficeHours_button.Click += new System.EventHandler(this.ChangeOfficeHours_button_Click);
            // 
            // PrintSchedule_button
            // 
            this.PrintSchedule_button.Location = new System.Drawing.Point(248, 29);
            this.PrintSchedule_button.Name = "PrintSchedule_button";
            this.PrintSchedule_button.Size = new System.Drawing.Size(150, 23);
            this.PrintSchedule_button.TabIndex = 9;
            this.PrintSchedule_button.Text = "Print Schedule";
            this.PrintSchedule_button.UseVisualStyleBackColor = true;
            // 
            // searchLecturer_button
            // 
            this.searchLecturer_button.Location = new System.Drawing.Point(248, 58);
            this.searchLecturer_button.Name = "searchLecturer_button";
            this.searchLecturer_button.Size = new System.Drawing.Size(150, 23);
            this.searchLecturer_button.TabIndex = 10;
            this.searchLecturer_button.Text = "Search Lecturer";
            this.searchLecturer_button.UseVisualStyleBackColor = true;
            // 
            // SearchTeachingAssist_button
            // 
            this.SearchTeachingAssist_button.Location = new System.Drawing.Point(248, 87);
            this.SearchTeachingAssist_button.Name = "SearchTeachingAssist_button";
            this.SearchTeachingAssist_button.Size = new System.Drawing.Size(150, 39);
            this.SearchTeachingAssist_button.TabIndex = 11;
            this.SearchTeachingAssist_button.Text = "Search Teaching Assistance";
            this.SearchTeachingAssist_button.UseVisualStyleBackColor = true;
            // 
            // SemestersToTeach_button
            // 
            this.SemestersToTeach_button.Location = new System.Drawing.Point(12, 174);
            this.SemestersToTeach_button.Name = "SemestersToTeach_button";
            this.SemestersToTeach_button.Size = new System.Drawing.Size(150, 23);
            this.SemestersToTeach_button.TabIndex = 12;
            this.SemestersToTeach_button.Text = "Semesters To Teach";
            this.SemestersToTeach_button.UseVisualStyleBackColor = true;
            this.SemestersToTeach_button.Click += new System.EventHandler(this.SemestersToTeach_button_Click);
            // 
            // AddNewTeachingAssist_button
            // 
            this.AddNewTeachingAssist_button.Location = new System.Drawing.Point(248, 232);
            this.AddNewTeachingAssist_button.Name = "AddNewTeachingAssist_button";
            this.AddNewTeachingAssist_button.Size = new System.Drawing.Size(150, 39);
            this.AddNewTeachingAssist_button.TabIndex = 13;
            this.AddNewTeachingAssist_button.Text = "Add New Teaching Assistant";
            this.AddNewTeachingAssist_button.UseVisualStyleBackColor = true;
            this.AddNewTeachingAssist_button.Click += new System.EventHandler(this.AddNewTeachingAssist_button_Click);
            // 
            // projectDataBaseDataSet1
            // 
            this.projectDataBaseDataSet1.DataSetName = "ProjectDataBaseDataSet";
            this.projectDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachingAssistantTableBindingSource
            // 
            this.teachingAssistantTableBindingSource.DataMember = "TeachingAssistantTable";
            this.teachingAssistantTableBindingSource.DataSource = this.projectDataBaseDataSet1;
            // 
            // teachingAssistantTableTableAdapter
            // 
            this.teachingAssistantTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TeachingAssistantTableTableAdapter = this.teachingAssistantTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project_Team_20.ProjectDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TeachingAssist_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 476);
            this.Controls.Add(this.AddNewTeachingAssist_button);
            this.Controls.Add(this.SemestersToTeach_button);
            this.Controls.Add(this.SearchTeachingAssist_button);
            this.Controls.Add(this.searchLecturer_button);
            this.Controls.Add(this.PrintSchedule_button);
            this.Controls.Add(this.ChangeOfficeHours_button);
            this.Controls.Add(this.ChooceOfficeHours_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumOfDays_button);
            this.Controls.Add(this.TimeBetweenClassses_button);
            this.Controls.Add(this.HoursToTeach_button);
            this.Controls.Add(this.DaysToTeach_button);
            this.Controls.Add(this.CourseToTeach_button);
            this.Name = "TeachingAssist_Form";
            this.Text = "TeachingAssist_Form";
            this.Load += new System.EventHandler(this.TeachingAssist_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingAssistantTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CourseToTeach_button;
        private System.Windows.Forms.Button DaysToTeach_button;
        private System.Windows.Forms.Button HoursToTeach_button;
        private System.Windows.Forms.Button TimeBetweenClassses_button;
        private System.Windows.Forms.Button NumOfDays_button;

        private System.Windows.Forms.Button ChooceOfficeHours_button;
        private System.Windows.Forms.Button ChangeOfficeHours_button;
        private System.Windows.Forms.Button PrintSchedule_button;
        private System.Windows.Forms.Button searchLecturer_button;
        private System.Windows.Forms.Button SearchTeachingAssist_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SemestersToTeach_button;
        private System.Windows.Forms.Button AddNewTeachingAssist_button;
        private ProjectDataBaseDataSet projectDataBaseDataSet1;
        private System.Windows.Forms.BindingSource teachingAssistantTableBindingSource;
        private ProjectDataBaseDataSetTableAdapters.TeachingAssistantTableTableAdapter teachingAssistantTableTableAdapter;
        private ProjectDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}