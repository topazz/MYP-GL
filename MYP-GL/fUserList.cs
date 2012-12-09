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
using MYP_GL.Entities;


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
            if (!Directory.Exists(Environment.CurrentDirectory + "/data/grades"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "/data/grades");
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
                usr.InitSubjects();
            }
            DirectoryInfo downloadedMessageInfo = new DirectoryInfo(Environment.CurrentDirectory + "/data/grades");
            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                Console.WriteLine("fname: " + file.Name);
                Console.WriteLine("ffname: " + file.FullName);
                foreach (Entities.User usr in Entities.User.UserList)
                {
                    if (usr.id == file.Name.Replace(".txt", ""))
                    {
                        Console.WriteLine("usrid: " + usr.id);
                        foreach(String line in File.ReadAllLines(file.FullName))
                        {

                            foreach(Entities.Subject s in usr.subjects)
                            {
                                Console.WriteLine("Checking if '" + s.name() + "' is '" + line.Split('|')[0] + "'");
                                if (s.name() == line.Split('|')[0])
                                {
                                    Console.WriteLine("it be true lol wat...");
                                    s.A = new Grade(line.Split('|')[1].Split('/')[0], line.Split('|')[1].Split('/')[1]);
                                    s.B = new Grade(line.Split('|')[2].Split('/')[0], line.Split('|')[2].Split('/')[1]);
                                    s.C = new Grade(line.Split('|')[3].Split('/')[0], line.Split('|')[3].Split('/')[1]);
                                    s.D = new Grade(line.Split('|')[4].Split('/')[0], line.Split('|')[4].Split('/')[1]);
                                    s.E = new Grade(line.Split('|')[5].Split('/')[0], line.Split('|')[5].Split('/')[1]);
                                    s.F = new Grade(line.Split('|')[6].Split('/')[0], line.Split('|')[6].Split('/')[1]);
                                }
                            }
                        }
                    }
                }
            }
            GeneralVariables.userlist = this;
            
        }

        public void refreshlistbox()
        {
            lb_Users.Items.Clear();
            foreach (Entities.User usr in Entities.User.UserList)
            {
                lb_Users.Items.Add(usr);
            }
        }

        private void butOpen_Click(object sender, EventArgs e)
        {
            
                GeneralVariables.selectedusr = (Entities.User)lb_Users.SelectedItem;
           
            if (GeneralVariables.selectedusr == null)
            {
                return;
            }
            this.Visible = false;
            GeneralVariables.subjectlistwindow = new fSubjectList();
            GeneralVariables.subjectlistwindow.ShowDialog();
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
