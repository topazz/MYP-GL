using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities.Subjects
{
    class PhysicalEducation : Subject
    {
        public override List<string> boundaries = new List<string>();

        public override void init()
        {
            boundaries.Add("0-5-1");
            boundaries.Add("6-10-2");
            boundaries.Add("11-15-3");
            boundaries.Add("16-20-4");
            boundaries.Add("21-24-5");
            boundaries.Add("25-28-6");
            boundaries.Add("29-32-7");
        }

        public override string name()
        {
            return "Physical Education";
        }
    }
}