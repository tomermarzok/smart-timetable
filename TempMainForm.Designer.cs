namespace Project_Team_20
{
    partial class TempMainForm
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
            this.Secretary_Menu = new System.Windows.Forms.Button();
            this.HeadOfDepartment_Menu = new System.Windows.Forms.Button();
            this.Lecturer_Menu = new System.Windows.Forms.Button();
            this.TeachingAssistant_Menu = new System.Windows.Forms.Button();
            this.BasicUser_button = new System.Windows.Forms.Button();
            this.TestSQLConnection_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Secretary_Menu
            // 
            this.Secretary_Menu.Location = new System.Drawing.Point(29, 215);
            this.Secretary_Menu.Name = "Secretary_Menu";
            this.Secretary_Menu.Size = new System.Drawing.Size(75, 35);
            this.Secretary_Menu.TabIndex = 1;
            this.Secretary_Menu.Text = "Secretary Menu";
            this.Secretary_Menu.UseVisualStyleBackColor = true;
            // 
            // HeadOfDepartment_Menu
            // 
            this.HeadOfDepartment_Menu.Location = new System.Drawing.Point(29, 12);
            this.HeadOfDepartment_Menu.Name = "HeadOfDepartment_Menu";
            this.HeadOfDepartment_Menu.Size = new System.Drawing.Size(75, 48);
            this.HeadOfDepartment_Menu.TabIndex = 2;
            this.HeadOfDepartment_Menu.Text = "Head Of Department Menu";
            this.HeadOfDepartment_Menu.UseVisualStyleBackColor = true;
            // 
            // Lecturer_Menu
            // 
            this.Lecturer_Menu.Location = new System.Drawing.Point(29, 81);
            this.Lecturer_Menu.Name = "Lecturer_Menu";
            this.Lecturer_Menu.Size = new System.Drawing.Size(75, 36);
            this.Lecturer_Menu.TabIndex = 3;
            this.Lecturer_Menu.Text = "Lecturer Menu";
            this.Lecturer_Menu.UseVisualStyleBackColor = true;
            // 
            // TeachingAssistant_Menu
            // 
            this.TeachingAssistant_Menu.Location = new System.Drawing.Point(29, 136);
            this.TeachingAssistant_Menu.Name = "TeachingAssistant_Menu";
            this.TeachingAssistant_Menu.Size = new System.Drawing.Size(75, 58);
            this.TeachingAssistant_Menu.TabIndex = 4;
            this.TeachingAssistant_Menu.Text = "Teaching Assistant Menu";
            this.TeachingAssistant_Menu.UseVisualStyleBackColor = true;
            this.TeachingAssistant_Menu.Click += new System.EventHandler(this.TeachingAssistant_Menu_Click);
            // 
            // BasicUser_button
            // 
            this.BasicUser_button.Location = new System.Drawing.Point(184, 25);
            this.BasicUser_button.Name = "BasicUser_button";
            this.BasicUser_button.Size = new System.Drawing.Size(75, 23);
            this.BasicUser_button.TabIndex = 5;
            this.BasicUser_button.Text = "BasicUser";
            this.BasicUser_button.UseVisualStyleBackColor = true;
            this.BasicUser_button.Click += new System.EventHandler(this.BasicUser_button_Click);
            // 
            // TestSQLConnection_button
            // 
            this.TestSQLConnection_button.Location = new System.Drawing.Point(184, 136);
            this.TestSQLConnection_button.Name = "TestSQLConnection_button";
            this.TestSQLConnection_button.Size = new System.Drawing.Size(75, 42);
            this.TestSQLConnection_button.TabIndex = 6;
            this.TestSQLConnection_button.Text = "Test SQL Connection";
            this.TestSQLConnection_button.UseVisualStyleBackColor = true;
            this.TestSQLConnection_button.Click += new System.EventHandler(this.TestSQLConnection_button_Click);
            // 
            // TempMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.TestSQLConnection_button);
            this.Controls.Add(this.BasicUser_button);
            this.Controls.Add(this.TeachingAssistant_Menu);
            this.Controls.Add(this.Lecturer_Menu);
            this.Controls.Add(this.HeadOfDepartment_Menu);
            this.Controls.Add(this.Secretary_Menu);
            this.Name = "TempMainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TempMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Secretary_Menu;
        private System.Windows.Forms.Button HeadOfDepartment_Menu;
        private System.Windows.Forms.Button Lecturer_Menu;
        private System.Windows.Forms.Button TeachingAssistant_Menu;
        private System.Windows.Forms.Button BasicUser_button;
        private System.Windows.Forms.Button TestSQLConnection_button;
    }
}

