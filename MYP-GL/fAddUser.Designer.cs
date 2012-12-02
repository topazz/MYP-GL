namespace MYP_GL
{
    partial class fAddUser
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
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butCreate = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(12, 25);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(186, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(12, 66);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(186, 20);
            this.txtLastname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(12, 106);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(183, 20);
            this.txtClass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(12, 146);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(186, 20);
            this.txtStudentID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student ID";
            // 
            // butCreate
            // 
            this.butCreate.Location = new System.Drawing.Point(123, 172);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(75, 23);
            this.butCreate.TabIndex = 8;
            this.butCreate.Text = "Create";
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(12, 172);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 9;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // fAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 203);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fAddUser";
            this.Text = "Add User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAddUser_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.Button butCancel;
    }
}