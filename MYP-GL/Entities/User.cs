using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities
{
    class User
    {
        public string FirstName, LastName, Class, StudentID;
        public User(string FirstName, string LastName, string Class, string StudentID)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Class = Class;
            this.StudentID = StudentID;
        }

    }
}
