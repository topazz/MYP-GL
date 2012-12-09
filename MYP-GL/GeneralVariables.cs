using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYP_GL
{
    public class GeneralVariables
    {
        public static fUserList userlist = null;
        public static fAddUser adduserwindow = null;
        public static fEditUser edituserwindow = null;
        public static fSubjectList subjectlistwindow = null;
        public static Entities.User editingusr = null;
        public static Entities.User selectedusr = null;
        public static Entities.Subject selectedsubject = null;
        public static int ProcessCounter = 0;
    }
}
