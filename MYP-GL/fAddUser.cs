using System;
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
    public partial class fAddUser : Form
    {
        public fAddUser()
        {
            InitializeComponent();
        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "" || txtLastname.Text == "" || txtClass.Text == "" || txtStudentID.Text == "")
            {
                MessageBox.Show("Please make sure you enter all the fields.");
                return;
            }
            Entities.User usr = new Entities.User(txtFirstname.Text, txtLastname.Text, txtStudentID.Text, txtClass.Text);
            GeneralVariables.userlist.refreshlistbox();
            GeneralVariables.userlist.Visible = true;
            GeneralVariables.adduserwindow = null;
            Entities.User.SaveAllUsers();
            usr.InitSubjects();
            this.Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            GeneralVariables.userlist.Visible = true;
            GeneralVariables.adduserwindow = null;
            this.Close();
        }

        private void fAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            GeneralVariables.userlist.Visible = true;
            GeneralVariables.adduserwindow = null;
        }
    }
}
