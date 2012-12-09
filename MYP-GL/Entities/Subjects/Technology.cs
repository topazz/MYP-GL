using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities.Subjects
{
    class Technology : Subject
    {
 

        public override void init()
        {
            boundaries.Add("0-5-1");
            boundaries.Add("6-9-2");
            boundaries.Add("10-15-3");
            boundaries.Add("16-21-4");
            boundaries.Add("22-28-5");
            boundaries.Add("29-32-6");
            boundaries.Add("33-36-7");
        }

        public override string name()
        {
            return "Technology";
        }
    }
}