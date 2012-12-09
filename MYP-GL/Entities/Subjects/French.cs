using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities.Subjects
{
    class French : Subject
    {
        public override List<string> boundaries = new List<string>();

        public override void init()
        {
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
            return "French";
        }
    }
}