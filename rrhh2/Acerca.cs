using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace rrhh2
{
    partial class Acerca : Form
    {
        public Acerca()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
