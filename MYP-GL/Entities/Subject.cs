using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYP_GL.Entities
{
    public class Subject
    {
        public Dictionary<string, Grade> criteria = new Dictionary<string, Grade>();
        public string name;
        public List<string> boundaries = new List<string>();
        public Subject(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
           return name;
        }
        public Grade getOverall()
        {
            int score = 0;
            List<string> list = new List<string>(criteria.Keys);
            foreach (string key in list)
            {
                score += criteria[key].value;
            }
            int finalvalue = 0;
            foreach (string boundary in boundaries)
            {
                int a = Convert.ToInt32(boundary.Split('|')[0]);
                int b = Convert.ToInt32(boundary.Split('|')[1]);
                if (score >= a && score <= b)
                {
                    finalvalue = Convert.ToInt32(boundary.Split('|')[2]);
                    break;
                }
            }
            return new Grade(finalvalue, 7);
        }

    }
}
