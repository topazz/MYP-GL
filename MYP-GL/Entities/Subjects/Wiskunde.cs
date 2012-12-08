using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities.Subjects
{
    class Wiskunde : Subject
    {
        public override List<string> boundaries = new List<string>();

        public override void init()
        {
            boundaries.Add("a-b-c");
        }

        public override string name()
        {
            return "Wiskunde";
        }
    }
}
