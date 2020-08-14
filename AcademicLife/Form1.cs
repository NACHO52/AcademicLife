using AcademicLife.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicLife
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            SetTheme();
        }

        private void SetTheme()
        {
            pnlSideMenuContainer.BackColor = ColorPalette.BlackCanary;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=NACHO\\SQLEXPRESS;Initial Catalog=AcademicLife;Persist Security Info=True;User ID=sa;Password=pacha");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into Subject values('" + textBox1.Text + "', '82.01')", con);
            //int i = cmd.ExecuteNonQuery();
            //if (i != 0)
            //{
            //    MessageBox.Show("Data saved");
            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //}
        }
    }
}
