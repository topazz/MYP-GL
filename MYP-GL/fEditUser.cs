﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYP_GL
{
    public partial class fEditUser : Form
    {
        public fEditUser()
        {
            InitializeComponent();
            txtFirstname.Text = GeneralVariables.editingusr.firstname;
            txtLastname.Text = GeneralVariables.editingusr.lastname;
            txtClass.Text = GeneralVariables.editingusr.classid;
            txtStudentID.Text = GeneralVariables.editingusr.studentid;
        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "" || txtLastname.Text == "" || txtClass.Text == "" || txtStudentID.Text == "")
            {
                MessageBox.Show("Please make sure you enter all the fields.");
                return;
            }
            String oldid = GeneralVariables.editingusr.id;
            Entities.User.UserList.Remove(GeneralVariables.editingusr);
            GeneralVariables.editingusr = null;
            new Entities.User(txtFirstname.Text, txtLastname.Text, txtStudentID.Text, txtClass.Text, oldid);
            GeneralVariables.userlist.refreshlistbox();
            GeneralVariables.userlist.Visible = true;
            GeneralVariables.edituserwindow = null;
            Entities.User.SaveAllUsers();
            this.Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            GeneralVariables.userlist.Visible = true;
            GeneralVariables.edituserwindow = null;
            this.Close();
        }

        private void fEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            GeneralVariables.userlist.Visible = true;
            GeneralVariables.edituserwindow = null;
        }
    }
}
