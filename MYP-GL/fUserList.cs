using System;
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
    public partial class fUserList : Form
    {
        public fUserList()
        {
            InitializeComponent();
            
            if (!Directory.Exists(Environment.CurrentDirectory +"/data"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "/data");
            }

            if (!File.Exists(Environment.CurrentDirectory + "/data/Users.txt"))
            {
                File.Create(Environment.CurrentDirectory + "/data/Users.txt").Close();
            }
            
            foreach (String line in File.ReadAllLines(Environment.CurrentDirectory + "/data/Users.txt"))
            {
                //FN$LN$SID$CID$ID
                new Entities.User(line.Split('$')[0], line.Split('$')[1], line.Split('$')[2], line.Split('$')[3], line.Split('$')[4]);
            }

            foreach (Entities.User usr in Entities.User.UserList)
            {
                lb_Users.Items.Add(usr);
            }
            GeneralVariables.userlist = this;
        }

        public void refreshlistbox()
        {
            lb_Users.Items.Clear();
            foreach (Entities.User usr in Entities.User.UserList)
            {
                lb_Users.Items.Add(usr.firstname + " " + usr.lastname + " (" + usr.studentid + ", " + usr.classid + ")");
            }
        }

        private void butOpen_Click(object sender, EventArgs e)
        {

        }

        private void butNew_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GeneralVariables.adduserwindow = new fAddUser();
            GeneralVariables.adduserwindow.ShowDialog();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            Entities.User usr = (Entities.User)lb_Users.SelectedItem;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete '"+usr.firstname + " " +usr.lastname + "'?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Entities.User.UserList.Remove(usr);
                Entities.User.SaveAllUsers();
                refreshlistbox();
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            GeneralVariables.editingusr = (Entities.User)lb_Users.SelectedItem;
            this.Visible = false;
            GeneralVariables.edituserwindow = new fEditUser();
            GeneralVariables.edituserwindow.ShowDialog();
        }
    }
}
