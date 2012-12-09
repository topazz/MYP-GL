using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities
{
    public class Grade
    {
        public int value;
        public int scale;
        public Grade(int value, int scale)
        {
            this.value = value;
            this.scale = scale;
        }
        public Grade(string value, string scale)
        {
            this.value = Convert.ToInt32(value);
            this.scale = Convert.ToInt32(scale);
        }
        public override string ToString()
        {
            return value.ToString() + "/" + scale.ToString();
        }
    }
}
