using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace rrhh2
{
    public partial class AgregaCargo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=10.10.231.70;Initial Catalog=rrhh;Persist Security Info=True;User ID=sa;Password=Sa2011");
        public AgregaCargo()
        {
            InitializeComponent();
        }

        private void btnAgregaNewCargo_Click(object sender, EventArgs e)
        {

        }
    }
}
