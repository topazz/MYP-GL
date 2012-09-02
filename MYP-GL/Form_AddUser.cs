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
    public partial class Form_AddUser : Form
    {
        public Form_AddUser()
        {
            InitializeComponent();
        }

        private void Form_AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.userlistwindow.Visible = true;
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            Program.adduser.Close();
        }

        private void but_AddUser_Click(object sender, EventArgs e)
        {
            tb_FirstName.Text = tb_FirstName.Text.TrimEnd(' ');
            tb_FirstName.Text = tb_FirstName.Text.TrimStart(' ');
            tb_LastName.Text = tb_LastName.Text.TrimEnd(' ');
            tb_LastName.Text = tb_LastName.Text.TrimStart(' ');
            tb_Class.Text = tb_Class.Text.TrimEnd(' ');
            tb_Class.Text = tb_Class.Text.TrimStart(' ');
            tb_StudentID.Text = tb_StudentID.Text.TrimEnd(' ');
            tb_StudentID.Text = tb_StudentID.Text.TrimStart(' ');
            if (tb_FirstName.Text == "" || tb_LastName.Text == "" || tb_Class.Text == "")
            {
                MessageBox.Show("Please make sure all textboxes marked with * are filled in correctly!");
                return;
            }
            bool containsillegalchars = false;
            foreach (char c in tb_FirstName.Text.ToCharArray())
            {
                if (!char.IsLetter(c))
                {
                    containsillegalchars = true;
                }
            }
            if (tb_FirstName.Text.Contains(' ') || containsillegalchars)
            {
                MessageBox.Show("The first name can't contain any whitespaces, numbers, or symbols!");
                return;
            }
            containsillegalchars = false;
            foreach (char c in tb_LastName.Text.ToCharArray())
            {
                if (!char.IsLetter(c))
                {
                    containsillegalchars = true;
                }
            }
            if (tb_LastName.Text.Contains(' ') || containsillegalchars)
            {
                MessageBox.Show("The last name can't contain any whitespaces, numbers, or symbols!");
                return;
            }
            if (tb_Class.Text.Contains('$'))
            {
                MessageBox.Show("The Class name may not contain the '$' character!");
                return;
            }
            if (tb_StudentID.Text != "")
            {
                try
                {
                    int resultint = Convert.ToInt32(tb_StudentID.Text);
                }
                catch
                {
                    MessageBox.Show("The student number needs to be a valid number!");
                    return;
                }
            }
            Program.Users.Add(new Entities.User(tb_FirstName.Text, tb_LastName.Text, tb_Class.Text, tb_StudentID.Text));
            File.Delete(Environment.CurrentDirectory + "/users.txt");
            File.Create(Environment.CurrentDirectory + "/users.txt").Close();
            string writelines = "";
            foreach (Entities.User who in Program.Users.ToArray())
            {
                writelines = writelines + who.FirstName + "$" + who.LastName + "$" + who.Class + "$" + who.StudentID + "|";
            }
            writelines = writelines.TrimEnd('|');
            File.WriteAllLines(Environment.CurrentDirectory + "/users.txt", writelines.Split('|'));
            Program.userlistwindow.Visible = true;
            Program.refreshlistbox();
            Program.adduser.Close();
        }
    }
}
