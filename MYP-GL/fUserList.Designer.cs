namespace MYP_GL
{
    partial class fUserList
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
            this.lb_Users = new System.Windows.Forms.ListBox();
            this.butOpen = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butNew = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Users
            // 
            this.lb_Users.FormattingEnabled = true;
            this.lb_Users.Location = new System.Drawing.Point(13, 13);
            this.lb_Users.Name = "lb_Users";
            this.lb_Users.Size = new System.Drawing.Size(276, 186);
            this.lb_Users.TabIndex = 0;
            // 
            // butOpen
            // 
            this.butOpen.Location = new System.Drawing.Point(296, 13);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(85, 23);
            this.butOpen.TabIndex = 1;
            this.butOpen.Text = "Open User";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(296, 43);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(85, 23);
            this.butDelete.TabIndex = 2;
            this.butDelete.Text = "Delete User";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butNew
            // 
            this.butNew.Location = new System.Drawing.Point(296, 73);
            this.butNew.Name = "butNew";
            this.butNew.Size = new System.Drawing.Size(85, 23);
            this.butNew.TabIndex = 3;
            this.butNew.Text = "New User";
            this.butNew.UseVisualStyleBackColor = true;
            this.butNew.Click += new System.EventHandler(this.butNew_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(296, 103);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(85, 23);
            this.butEdit.TabIndex = 4;
            this.butEdit.Text = "Edit User";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "By Nicolas Spits";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butNew);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butOpen);
            this.Controls.Add(this.lb_Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fUserList";
            this.Text = "MYP Grade List";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Users;
        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butNew;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}

