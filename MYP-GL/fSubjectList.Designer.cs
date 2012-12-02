namespace MYP_GL
{
    partial class fSubjectList
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_subjects = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_grades = new System.Windows.Forms.ListBox();
            this.but_Edit = new System.Windows.Forms.Button();
            this.but_Grades = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_new = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subjects";
            // 
            // lb_subjects
            // 
            this.lb_subjects.FormattingEnabled = true;
            this.lb_subjects.Location = new System.Drawing.Point(13, 30);
            this.lb_subjects.Name = "lb_subjects";
            this.lb_subjects.Size = new System.Drawing.Size(132, 251);
            this.lb_subjects.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Overall Grade";
            // 
            // lb_grades
            // 
            this.lb_grades.FormattingEnabled = true;
            this.lb_grades.Location = new System.Drawing.Point(154, 30);
            this.lb_grades.Name = "lb_grades";
            this.lb_grades.Size = new System.Drawing.Size(69, 251);
            this.lb_grades.TabIndex = 3;
            // 
            // but_Edit
            // 
            this.but_Edit.Location = new System.Drawing.Point(229, 30);
            this.but_Edit.Name = "but_Edit";
            this.but_Edit.Size = new System.Drawing.Size(93, 23);
            this.but_Edit.TabIndex = 4;
            this.but_Edit.Text = "Edit Subject";
            this.but_Edit.UseVisualStyleBackColor = true;
            // 
            // but_Grades
            // 
            this.but_Grades.Location = new System.Drawing.Point(229, 60);
            this.but_Grades.Name = "but_Grades";
            this.but_Grades.Size = new System.Drawing.Size(93, 23);
            this.but_Grades.TabIndex = 5;
            this.but_Grades.Text = "Manage Grades";
            this.but_Grades.UseVisualStyleBackColor = true;
            // 
            // but_delete
            // 
            this.but_delete.Location = new System.Drawing.Point(229, 90);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(93, 23);
            this.but_delete.TabIndex = 6;
            this.but_delete.Text = "Delete Subject";
            this.but_delete.UseVisualStyleBackColor = true;
            // 
            // but_new
            // 
            this.but_new.Location = new System.Drawing.Point(230, 120);
            this.but_new.Name = "but_new";
            this.but_new.Size = new System.Drawing.Size(92, 23);
            this.but_new.TabIndex = 7;
            this.but_new.Text = "New Subject";
            this.but_new.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Current User:";
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(230, 163);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(44, 13);
            this.lUser.TabIndex = 9;
            this.lUser.Text = "testuser";
            // 
            // fSubjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 293);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_new);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_Grades);
            this.Controls.Add(this.but_Edit);
            this.Controls.Add(this.lb_grades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_subjects);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fSubjectList";
            this.Text = "MYP GL - Subject List";
            this.Load += new System.EventHandler(this.fSubjectList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_subjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_grades;
        private System.Windows.Forms.Button but_Edit;
        private System.Windows.Forms.Button but_Grades;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_new;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lUser;

    }
}