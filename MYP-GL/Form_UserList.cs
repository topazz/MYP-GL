using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace MYP_GL
{
    public partial class Form_UserList : Form
    {
        public Form_UserList()
        {
            InitializeComponent();
        }
        

        private void but_AddUser_Click(object sender, EventArgs e)
        {
            Program.userlistwindow.Visible = false;
            Program.adduser = new Form_AddUser();
            Program.adduser.Show();
        }

        private void but_EditUser_Click(object sender, EventArgs e)
        {
            
        }
    }
}
