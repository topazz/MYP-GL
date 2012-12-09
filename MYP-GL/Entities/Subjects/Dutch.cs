using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities.Subjects
{
    class Dutch : Subject
    {
 

        public override void init()
        {
            boundaries.Add("0-4-1");
            boundaries.Add("5-9-2");
            boundaries.Add("10-14-3");
            boundaries.Add("15-19-4");
            boundaries.Add("20-23-5");
            boundaries.Add("24-27-6");
            boundaries.Add("28-30-7");
        }

        public override string name()
        {
            return "Dutch";
        }
    }
}