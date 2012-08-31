namespace MYP_GL
{
    partial class Form_UserList
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
            this.lb_users = new System.Windows.Forms.ListBox();
            this.but_AddUser = new System.Windows.Forms.Button();
            this.but_RemoveUser = new System.Windows.Forms.Button();
            this.but_EditUser = new System.Windows.Forms.Button();
            this.but_SelectUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_users
            // 
            this.lb_users.FormattingEnabled = true;
            this.lb_users.Location = new System.Drawing.Point(13, 13);
            this.lb_users.Name = "lb_users";
            this.lb_users.Size = new System.Drawing.Size(290, 264);
            this.lb_users.TabIndex = 0;
            // 
            // but_AddUser
            // 
            this.but_AddUser.Location = new System.Drawing.Point(309, 13);
            this.but_AddUser.Name = "but_AddUser";
            this.but_AddUser.Size = new System.Drawing.Size(117, 23);
            this.but_AddUser.TabIndex = 1;
            this.but_AddUser.Text = "Add User";
            this.but_AddUser.UseVisualStyleBackColor = true;
            // 
            // but_RemoveUser
            // 
            this.but_RemoveUser.Location = new System.Drawing.Point(310, 43);
            this.but_RemoveUser.Name = "but_RemoveUser";
            this.but_RemoveUser.Size = new System.Drawing.Size(116, 22);
            this.but_RemoveUser.TabIndex = 2;
            this.but_RemoveUser.Text = "Remove User";
            this.but_RemoveUser.UseVisualStyleBackColor = true;
            // 
            // but_EditUser
            // 
            this.but_EditUser.Location = new System.Drawing.Point(310, 71);
            this.but_EditUser.Name = "but_EditUser";
            this.but_EditUser.Size = new System.Drawing.Size(116, 23);
            this.but_EditUser.TabIndex = 3;
            this.but_EditUser.Text = "Edit User";
            this.but_EditUser.UseVisualStyleBackColor = true;
            // 
            // but_SelectUser
            // 
            this.but_SelectUser.Location = new System.Drawing.Point(310, 100);
            this.but_SelectUser.Name = "but_SelectUser";
            this.but_SelectUser.Size = new System.Drawing.Size(116, 23);
            this.but_SelectUser.TabIndex = 4;
            this.but_SelectUser.Text = "Select User";
            this.but_SelectUser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 286);
            this.Controls.Add(this.but_SelectUser);
            this.Controls.Add(this.but_EditUser);
            this.Controls.Add(this.but_RemoveUser);
            this.Controls.Add(this.but_AddUser);
            this.Controls.Add(this.lb_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "MYP Grade List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_users;
        private System.Windows.Forms.Button but_AddUser;
        private System.Windows.Forms.Button but_RemoveUser;
        private System.Windows.Forms.Button but_EditUser;
        private System.Windows.Forms.Button but_SelectUser;
    }
}

