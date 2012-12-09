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
        public void InitSubjects()
        {
            subjects.Clear();
            //Creating Subjects
            subjects.Add(new Subjects.Chemistry());
            subjects.Add(new Subjects.Dutch());
            subjects.Add(new Subjects.Economics());
            subjects.Add(new Subjects.English12());
            subjects.Add(new Subjects.English34());
            subjects.Add(new Subjects.French());
            subjects.Add(new Subjects.Geography());
            subjects.Add(new Subjects.German());
            subjects.Add(new Subjects.History());
            subjects.Add(new Subjects.Humanities());
            subjects.Add(new Subjects.Music());
            subjects.Add(new Subjects.PerformingArts());
            subjects.Add(new Subjects.Physics());
            subjects.Add(new Subjects.Science());
            subjects.Add(new Subjects.SocialStudies());
            subjects.Add(new Subjects.Spanish());
            subjects.Add(new Subjects.Technology());
            subjects.Add(new Subjects.Visual_Arts());
            subjects.Add(new Subjects.Wiskunde());
            //Done Creating Subjects
            foreach (Subject su in subjects.ToArray())
            {
                su.init();
            }
        }
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
