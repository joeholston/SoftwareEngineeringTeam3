﻿using System;
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
    }
}
