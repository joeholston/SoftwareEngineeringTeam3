using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mwfAll(false);
        }
 
        private void richTextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void courseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Add/delete the newly checked/unchecked course to studentCourses

            if (courseCheckBox.Checked)
            {
                //Add course

            }
            else
            {
                //delete course
            }

        }

        private void mwfAll(bool show)
        {
            mwf8(show);
            mwf9(show);
            mwf10(show);
            mwf11(show);
            mwf12(show);
            mwf1(show);
            mwf2(show);
            mwf3(show);
        }

        private void mwf8(bool show)
        {
            if (show)
            {
                m8.Show();
                w8.Show();
                f8.Show();
            }
            else
            {
                m8.Hide();
                w8.Hide();
                f8.Hide();
            }
        }

        private void mwf9(bool show)
        {
            if (show)
            {
                m9.Show();
                w9.Show();
                f9.Show();
            }
            else
            {
                m9.Hide();
                w9.Hide();
                f9.Hide();
            }
        }

        private void mwf10(bool show)
        {
            if (show)
            {
                m10.Show();
                w10.Show();
                f10.Show();
            }
            else
            {
                m10.Hide();
                w10.Hide();
                f10.Hide();
            }
        }

        private void mwf11(bool show)
        {
            if (show)
            {
                m11.Show();
                w11.Show();
                f11.Show();
            }
            else
            {
                m11.Hide();
                w11.Hide();
                f11.Hide();
            }
        }

        private void mwf12(bool show)
        {
            if (show)
            {
                m12.Show();
                w12.Show();
                f12.Show();
            }
            else
            {
                m12.Hide();
                w12.Hide();
                f12.Hide();
            }
        }

        private void mwf1(bool show)
        {
            if (show)
            {
                m1.Show();
                w1.Show();
                f1.Show();
            }
            else
            {
                m1.Hide();
                w1.Hide();
                f1.Hide();
            }
        }

        private void mwf2(bool show)
        {
            if (show)
            {
                m2.Show();
                w2.Show();
                f2.Show();
            }
            else
            {
                m2.Hide();
                w2.Hide();
                f2.Hide();
            }
        }

        private void mwf3(bool show)
        {
            if (show)
            {
                m3.Show();
                w3.Show();
                f3.Show();
            }
            else
            {
                m3.Hide();
                w3.Hide();
                f3.Hide();
            }
        }
    }
}
