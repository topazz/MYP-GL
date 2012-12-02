using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities
{
    class Grade
    {
        public int value;
        public int scale;
        public Grade(int value, int scale)
        {
            this.value = value;
            this.scale = scale;
        }
        public override string ToString()
        {
            return value.ToString() + "/" + scale.ToString();
        }
    }
}
