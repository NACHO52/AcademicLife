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
            pnlSubMenuSubjects.Visible = false;
        }

        #region ShowAndHideEvents
        private void ShowSubMenu(Panel subMenu)
        {
            subMenu.Visible = true;
        }
        private void HideSubMenu(Panel subMenu)
        {
            subMenu.Visible = false;
        }
        #endregion

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

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            pnlSubMenuSubjects.Visible = !pnlSubMenuSubjects.Visible;
        }

        private void btnCreateSubject_Click(object sender, EventArgs e)
        {
            HideSubMenu(pnlSubMenuSubjects);
            OpenChildForm(new CRUDSubjectForm());
        }

        private void btnSearchSubjects_Click(object sender, EventArgs e)
        {
            HideSubMenu(pnlSubMenuSubjects);
            OpenChildForm(new SearchSubjectForm());
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            string dayName = DateTime.Today.ToString("dddd");
            string dayNumber = DateTime.Today.ToString("dd");
            string monthName = DateTime.Today.ToString("MMMM");

            lblDate.Text = dayName + " " + dayNumber + " de " + monthName;
            //lblDate.Text = DateTime.Today.ToString("dddd dd MMMM del yyy");
        }
    }
}
