using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MYP_GL.Entities
{
    public class User
    {
        //STATIC SHIT
        public List<Subject> subjects = new List<Subject>();
        public static List<Entities.User> UserList = new List<Entities.User>();
        public static void SaveAllUsers()
        {
            if (File.Exists(Environment.CurrentDirectory + "/data/Users.txt"))
            {
                File.Delete(Environment.CurrentDirectory + "/data/Users.txt");
            }
            File.Create(Environment.CurrentDirectory + "/data/Users.txt").Close();
            List<String> linelist = new List<String>();
            foreach (Entities.User usr in Entities.User.UserList)
            {
                linelist.Add(usr.firstname + "$" + usr.lastname + "$" + usr.studentid + "$" + usr.classid + "$" + usr.id);
            }
            File.WriteAllLines(Environment.CurrentDirectory + "/data/Users.txt", linelist.ToArray());

        }
        public static bool idExists(int id)
        {
            foreach (Entities.User usr in Entities.User.UserList)
            {
                if (usr.id == id.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        //ENTITIY STUFF
        public String firstname;
        public String lastname;
        public String studentid;
        public String classid;
        public String id;
        

        public User(String fn, String ln, String sid, String cid)
        {
            firstname = fn;
            lastname = ln;
            studentid = sid;
            classid = cid;
            int i = 0;
            while (idExists(i))
            {
                i++;
            }
            this.id = i.ToString();
            UserList.Add(this);
        }
        public User(String fn, String ln, String sid, String cid, String id)
        {
            firstname = fn;
            lastname = ln;
            studentid = sid;
            classid = cid;
            this.id = id;
            UserList.Add(this);
        }
        public override string ToString()
        {
            return firstname + " " + lastname + " (" + studentid + ", " + classid + ")";
        }
    }
}
