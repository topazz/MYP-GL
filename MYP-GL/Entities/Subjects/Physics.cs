using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities.Subjects
{
    class Physics : Subject
    {
        public override List<string> boundaries = new List<string>();

        public override void init()
        {
            boundaries.Add("0-5-1");
            boundaries.Add("6-11-2");
            boundaries.Add("12-18-3");
            boundaries.Add("19-24-4");
            boundaries.Add("25-28-5");
            boundaries.Add("29-32-6");
            boundaries.Add("33-36-7");
        }

        public override string name()
        {
            return "Physics";
        }
    }
}