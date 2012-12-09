using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities.Subjects
{
    class PersonalProject : Subject
    {
        public override List<string> boundaries = new List<string>();

        public override void init()
        {
            boundaries.Add("0-4-1");
            boundaries.Add("5-8-2");
            boundaries.Add("9-12-3");
            boundaries.Add("13-16-4");
            boundaries.Add("17-20-5");
            boundaries.Add("21-24-6");
            boundaries.Add("25-28-7");
        }

        public override string name()
        {
            return "Personal Projects";
        }
    }
}