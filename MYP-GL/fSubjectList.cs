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
                sub.recalculateFinal();
                lb_subjects.Items.Add(sub);
                if (sub.Overall == null)
                {
                    lb_grades.Items.Add("-");
                }
                else
                {
                    lb_grades.Items.Add(sub.Overall);
                }
            }
        }

        private void fSubjectList_Load(object sender, EventArgs e)
        {
            reload_Subjects();
            lUser.Text = GeneralVariables.selectedusr.studentid;
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            GeneralVariables.userlist.Visible = true;
            GeneralVariables.selectedusr = null;
            this.Close();
        }

        private void fSubjectList_FormClosing(object sender, FormClosingEventArgs e)
        {GeneralVariables.userlist.Visible = true;
            GeneralVariables.selectedusr = null;

        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            GeneralVariables.selectedsubject = (Entities.Subject)lb_subjects.SelectedItem;
            if (GeneralVariables.selectedsubject == null)
            {
                return;
            }
            this.Visible = false;
            (new fEditSubject()).ShowDialog();
        }
    }
}
