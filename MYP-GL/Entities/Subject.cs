using System;
using System.Collections.Generic;
using MYP_GL.Entities.Subjects;

namespace MYP_GL.Entities
{
    public abstract class Subject
    {
        public Grade A;
        public Grade B;
        public Grade C;
        public Grade D;
        public Grade E;
        public Grade F;
        public Grade Overall;

        public List<string> boundaries = new List<string>();

        public abstract void init();

        public abstract string name();

        public void recalculateFinal()
        {
            Grade A1 = A;
            Grade B1 = B;
            Grade C1 = C;
            Grade D1 = D;
            Grade E1 = E;
            Grade F1 = F;
            Overall = null;
            if (A1 == null)
            {
                A1 = new Grade(0, 10);
            }
            int score = A1.value + B1.value + C1.value + D1.value + E1.value + F1.value;
            foreach (string boundary in boundaries.ToArray())
            {
                int a = Convert.ToInt32(boundary.Split('-')[0]);
                int b = Convert.ToInt32(boundary.Split('-')[1]);
                int c = Convert.ToInt32(boundary.Split('-')[2]);
                if (score >= a && score <= b)
                {
                    Overall = new Grade(c, 7);
                }
            }
            if (Overall == null)
            {
                Overall = new Grade(0, 7);
            }
        }

        public override string ToString()
        {
            return name();
        }
    }
}