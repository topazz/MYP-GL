using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities.Subjects
{
    class Wiskunde : Subject
    {
 

        public override void init()
        {
            A = new Grade(0, 0);
            B = new Grade(0, 0);
            C = new Grade(0, 0);
            D = new Grade(0, 0);
            E = new Grade(0, 0);
            F = new Grade(0, 0);
            boundaries.Add("0-4-1");
            boundaries.Add("5-8-2");
            boundaries.Add("9-12-3");
            boundaries.Add("13-17-4");
            boundaries.Add("18-21-5");
            boundaries.Add("22-25-6");
            boundaries.Add("26-28-7");
        }

        public override string name()
        {
            return "Wiskunde";
        }
    }
}
