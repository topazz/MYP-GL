﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MYP_GL
{
    public partial class Form_UserList : Form
    {
        public List<string> Users = new List<string>();
        public Form_AddUser adduser;
        public Form_UserList()
        {
            InitializeComponent();
            if (!File.Exists(Environment.CurrentDirectory + "/users.txt"))
            {
                File.Create(Environment.CurrentDirectory + "/users.txt").Dispose();
            }
            string[] lines = File.ReadAllLines(Environment.CurrentDirectory + "/users.txt");
            foreach (String line in lines)
            {
                Users.Add(line);
            }
        }

        private void but_AddUser_Click(object sender, EventArgs e)
        {
            Program.userlistwindow.Visible = false;
            adduser = new Form_AddUser();
            adduser.Show();
        }
    }
}
