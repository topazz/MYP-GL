using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities.Subjects
{
    class SocialStudies : Subject
    {
 

        public override void init()
        {
            A = new Grade(0, 0);
            B = new Grade(0, 0);
            C = new Grade(0, 0);
            D = new Grade(0, 0);
            E = new Grade(0, 0);
            F = new Grade(0, 0);
            boundaries.Add("0-3-1");
            boundaries.Add("4-7-2");
            boundaries.Add("8-12-3");
            boundaries.Add("13-17-4");
            boundaries.Add("18-22-5");
            boundaries.Add("23-27-6");
            boundaries.Add("28-32-7");
        }

        public override string name()
        {
            return "Social Studies";
        }
    }
}