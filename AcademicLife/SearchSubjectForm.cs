using AcademicLife.BusinessLogic;
using AcademicLife.Entity;
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

        private void btnSubjectSave_Click(object sender, EventArgs e)
        {
            IList<Subject> subjects = new List<Subject>();

            subjects.Add(new Subject() { Name = "Quimica", Code = "62.01" });
            subjects.Add(new Subject() { Name = "Fisica", Code = "86.41" });

            grdSubjects.DataSource = subjects;
        }
    }
}
