using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities.Subjects
{
    class PerformingArts : Subject
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
            boundaries.Add("4-8-2");
            boundaries.Add("9-13-3");
            boundaries.Add("14-20-4");
            boundaries.Add("21-25-5");
            boundaries.Add("26-30-6");
            boundaries.Add("31-34-7");
        }

        public override string name()
        {
            return "Performing Arts";
        }
    }
}