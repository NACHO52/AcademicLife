using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicLife
{
    public partial class SearchSubjectForm : Form
    {
        public SearchSubjectForm()
        {
            InitializeComponent();
        }

        private void SearchSubjectForm_Load(object sender, EventArgs e)
        {
        }

        private void ShowSubjects()
        {
            grdSubjects.DataSource = SubjectBL.ShowSubjects();
        }

        private void btnSubjectSearch_Click(object sender, EventArgs e)
        {
            ShowSubjects();
        }

        private void btnSubjectEdit_Click(object sender, EventArgs e)
        {
            if(grdSubjects.SelectedRows.Count == 1)
            {
                this.Close();
                CRUDSubjectForm childForm = new CRUDSubjectForm();

                //activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                //pnlChildForm.Controls.Add(childForm);
                //pnlChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
    }
}
