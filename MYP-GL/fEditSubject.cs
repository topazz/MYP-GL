using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MYP_GL.Entities;

namespace MYP_GL
{
    public partial class fEditSubject : Form
    {
        public fEditSubject()
        {
            InitializeComponent();
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fEditSubject_FormClosing(object sender, FormClosingEventArgs e)
        {
            GeneralVariables.subjectlistwindow.Visible = true;
            GeneralVariables.selectedsubject = null;
        }

        private void fEditSubject_Load(object sender, EventArgs e)
        {
            l_Subject.Text = GeneralVariables.selectedsubject.name();
            if (GeneralVariables.selectedsubject.A != null)
            {
                a_Value.Text = GeneralVariables.selectedsubject.A.value.ToString();
                a_Scale.Text = GeneralVariables.selectedsubject.A.scale.ToString();
            }
            if (GeneralVariables.selectedsubject.B != null)
            {
                b_Value.Text = GeneralVariables.selectedsubject.B.value.ToString();
                b_Scale.Text = GeneralVariables.selectedsubject.B.scale.ToString();
            }
            if (GeneralVariables.selectedsubject.C != null)
            {
                c_Value.Text = GeneralVariables.selectedsubject.C.value.ToString();
                c_Scale.Text = GeneralVariables.selectedsubject.C.scale.ToString();
            }
            if (GeneralVariables.selectedsubject.D != null)
            {
                d_Value.Text = GeneralVariables.selectedsubject.D.value.ToString();
                d_Scale.Text = GeneralVariables.selectedsubject.D.scale.ToString();
            }
            if (GeneralVariables.selectedsubject.E != null)
            {
                e_Value.Text = GeneralVariables.selectedsubject.E.value.ToString();
                e_Scale.Text = GeneralVariables.selectedsubject.E.scale.ToString();
            }
            if (GeneralVariables.selectedsubject.F != null)
            {
                f_Value.Text = GeneralVariables.selectedsubject.F.value.ToString();
                f_Scale.Text = GeneralVariables.selectedsubject.F.scale.ToString();
            }
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            if (IsDigitsOnly(a_Value.Text) && IsDigitsOnly(b_Value.Text) && IsDigitsOnly(c_Value.Text) && IsDigitsOnly(d_Value.Text) && IsDigitsOnly(e_Value.Text) && IsDigitsOnly(f_Value.Text) && IsDigitsOnly(a_Scale.Text) && IsDigitsOnly(b_Scale.Text) && IsDigitsOnly(c_Scale.Text) && IsDigitsOnly(d_Scale.Text) && IsDigitsOnly(e_Scale.Text) && IsDigitsOnly(f_Scale.Text))
            {
                if (a_Value.Text == "")
                {
                    a_Value.Text = "0";
                }
                if (b_Value.Text == "")
                {
                    b_Value.Text = "0";
                }
                if (c_Value.Text == "")
                {
                    c_Value.Text = "0";
                }
                if (d_Value.Text == "")
                {
                    d_Value.Text = "0";
                }
                if (e_Value.Text == "")
                {
                    e_Value.Text = "0";
                }
                if (f_Value.Text == "")
                {
                    f_Value.Text = "0";
                }
                if (a_Scale.Text == "")
                {
                    a_Scale.Text = "0";
                }
                if (b_Scale.Text == "")
                {
                    b_Scale.Text = "0";
                }
                if (c_Scale.Text == "")
                {
                    c_Scale.Text = "0";
                }
                if (d_Scale.Text == "")
                {
                    d_Scale.Text = "0";
                }
                if (e_Scale.Text == "")
                {
                    e_Scale.Text = "0";
                }
                if (f_Scale.Text == "")
                {
                    f_Scale.Text = "0";
                }

                if (Convert.ToInt32(a_Value.Text) > Convert.ToInt32(a_Scale.Text) || Convert.ToInt32(b_Value.Text) > Convert.ToInt32(b_Scale.Text) || Convert.ToInt32(c_Value.Text) > Convert.ToInt32(c_Scale.Text) || Convert.ToInt32(d_Value.Text) > Convert.ToInt32(d_Scale.Text) || Convert.ToInt32(e_Value.Text) > Convert.ToInt32(e_Scale.Text) || Convert.ToInt32(f_Value.Text) > Convert.ToInt32(f_Scale.Text))
                {
                    MessageBox.Show("Please make sure all grades are valid.");
                    return;
                }
                if (Convert.ToInt32(b_Value.Text) > 100)
                {
                    MessageBox.Show("Please make sure all grades are valid.");
                    return; 
                }
                if (Convert.ToInt32(c_Value.Text) > 100)
                {
                    MessageBox.Show("Please make sure all grades are valid.");
                    return;
                }
                if (Convert.ToInt32(d_Value.Text) > 100)
                {
                    MessageBox.Show("Please make sure all grades are valid.");
                    return;
                }
                if (Convert.ToInt32(e_Value.Text) > 100)
                {
                    MessageBox.Show("Please make sure all grades are valid.");
                    return;
                }
                if (Convert.ToInt32(f_Value.Text) > 100)
                {
                    MessageBox.Show("Please make sure all grades are valid.");
                    return;
                }
                if (Convert.ToInt32(b_Scale.Text) > 100)
                {
                    MessageBox.Show("Please make sure all grades are valid.");
                    return;
                }
                if (Convert.ToInt32(c_Scale.Text) > 100)
                {
                    MessageBox.Show("Please make sure all grades are valid.");
                    return;
                }
                if (Convert.ToInt32(d_Scale.Text) > 100)
                {
                    MessageBox.Show("Please make sure all grades are valid.");
                    return;
                }
                if (Convert.ToInt32(e_Scale.Text) > 100)
                {
                    MessageBox.Show("Please make sure all grades are valid.");
                    return;
                }
                if (Convert.ToInt32(f_Scale.Text) > 100)
                {
                    MessageBox.Show("Please make sure all grades are valid.");
                    return;
                }

                GeneralVariables.selectedsubject.A = new Grade(a_Value.Text, a_Scale.Text);
                GeneralVariables.selectedsubject.B = new Grade(b_Value.Text, b_Scale.Text);
                GeneralVariables.selectedsubject.C = new Grade(c_Value.Text, c_Scale.Text);
                GeneralVariables.selectedsubject.D = new Grade(d_Value.Text, d_Scale.Text);
                GeneralVariables.selectedsubject.E = new Grade(e_Value.Text, e_Scale.Text);
                GeneralVariables.selectedsubject.F = new Grade(f_Value.Text, f_Scale.Text);
                GeneralVariables.subjectlistwindow.reload_Subjects();
                Entities.User.SaveAllUsers();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please make sure all grades are numbers.");
                return;
            }
            
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
