namespace MYP_GL
{
    partial class Form_AddUser
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
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Class = new System.Windows.Forms.TextBox();
            this.tb_StudentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.but_AddUser = new System.Windows.Forms.Button();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(12, 25);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(260, 20);
            this.tb_FirstName.TabIndex = 1;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(12, 68);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(260, 20);
            this.tb_LastName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // tb_Class
            // 
            this.tb_Class.Location = new System.Drawing.Point(12, 107);
            this.tb_Class.Name = "tb_Class";
            this.tb_Class.Size = new System.Drawing.Size(100, 20);
            this.tb_Class.TabIndex = 4;
            // 
            // tb_StudentID
            // 
            this.tb_StudentID.Location = new System.Drawing.Point(172, 107);
            this.tb_StudentID.Name = "tb_StudentID";
            this.tb_StudentID.Size = new System.Drawing.Size(100, 20);
            this.tb_StudentID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student Number";
            // 
            // but_AddUser
            // 
            this.but_AddUser.Location = new System.Drawing.Point(12, 133);
            this.but_AddUser.Name = "but_AddUser";
            this.but_AddUser.Size = new System.Drawing.Size(100, 23);
            this.but_AddUser.TabIndex = 8;
            this.but_AddUser.Text = "Add User";
            this.but_AddUser.UseVisualStyleBackColor = true;
            // 
            // but_Cancel
            // 
            this.but_Cancel.Location = new System.Drawing.Point(172, 133);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(100, 23);
            this.but_Cancel.TabIndex = 9;
            this.but_Cancel.Text = "Cancel";
            this.but_Cancel.UseVisualStyleBackColor = true;
            // 
            // Form_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 163);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.but_AddUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_StudentID);
            this.Controls.Add(this.tb_Class);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.label1);
            this.Name = "Form_AddUser";
            this.Text = "Form_AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Class;
        private System.Windows.Forms.TextBox tb_StudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_AddUser;
        private System.Windows.Forms.Button but_Cancel;
    }
}