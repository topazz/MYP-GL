using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace MYP_GL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Form_UserList userlistwindow;
        public static List<Entities.User> Users = new List<Entities.User>();
        public static Form_AddUser adduser;
        [STAThread]        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            userlistwindow = new Form_UserList();
            Application.Run(userlistwindow);
            Program.loadusers();
        }

        public static void refreshlistbox()
        {
            userlistwindow.lb_users.Items.Clear();
            foreach (Entities.User who in Program.Users.ToArray())
            {
                if (who.StudentID != "")
                {
                    userlistwindow.lb_users.Items.Add(who.FirstName + " " + who.LastName + " (" + who.StudentID + ")");
                }
                else
                {
                    userlistwindow.lb_users.Items.Add(who.FirstName + " " + who.LastName);
                }
            }
        }

        public static void loadusers()
        {
            if (!File.Exists(Environment.CurrentDirectory + "/users.txt"))
            {
                File.Create(Environment.CurrentDirectory + "/users.txt").Dispose();
            }
            string[] lines = File.ReadAllLines(Environment.CurrentDirectory + "/users.txt");
            Program.Users.Clear();
            foreach (String line in lines)
            {
                Program.Users.Add(new Entities.User(line.Split('$')[0], line.Split('$')[1], line.Split('$')[2], line.Split('$')[3]));                
            }
            refreshlistbox();
        }
    }
}
