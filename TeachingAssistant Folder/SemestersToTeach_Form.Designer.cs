namespace Project_Team_20.TeachingAssistant_Folder
{
    partial class SemestersToTeach_Form
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
            this.winter = new System.Windows.Forms.CheckBox();
            this.spring = new System.Windows.Forms.CheckBox();
            this.summer = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winter
            // 
            this.winter.AutoSize = true;
            this.winter.Location = new System.Drawing.Point(104, 62);
            this.winter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.winter.Name = "winter";
            this.winter.Size = new System.Drawing.Size(57, 17);
            this.winter.TabIndex = 0;
            this.winter.Text = "Winter";
            this.winter.UseVisualStyleBackColor = true;
            // 
            // spring
            // 
            this.spring.AutoSize = true;
            this.spring.Location = new System.Drawing.Point(104, 104);
            this.spring.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spring.Name = "spring";
            this.spring.Size = new System.Drawing.Size(56, 17);
            this.spring.TabIndex = 1;
            this.spring.Text = "Spring";
            this.spring.UseVisualStyleBackColor = true;
            // 
            // summer
            // 
            this.summer.AutoSize = true;
            this.summer.Location = new System.Drawing.Point(104, 146);
            this.summer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.summer.Name = "summer";
            this.summer.Size = new System.Drawing.Size(64, 17);
            this.summer.TabIndex = 2;
            this.summer.Text = "Summer";
            this.summer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose 2 semesters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SemestersToTeach_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.summer);
            this.Controls.Add(this.spring);
            this.Controls.Add(this.winter);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SemestersToTeach_Form";
            this.Text = "SemestersToTeach_Form";
            this.Load += new System.EventHandler(this.SemestersToTeach_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox winter;
        private System.Windows.Forms.CheckBox spring;
        private System.Windows.Forms.CheckBox summer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}