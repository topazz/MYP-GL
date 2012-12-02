using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYP_GL
{
    public partial class fSubjectList : Form
    {
        public fSubjectList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void reload_Subjects()
        {
            lb_subjects.Items.Clear();
            lb_grades.Items.Clear();
            foreach (Entities.Subject sub in GeneralVariables.selectedusr.subjects.ToArray())
            {
                lb_subjects.Items.Add(sub);
                lb_grades.Items.Add(sub.getOverall());
            }
        }

        private void fSubjectList_Load(object sender, EventArgs e)
        {

        }
    }
}
