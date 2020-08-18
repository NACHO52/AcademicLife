using BusinessLogic;
using Entity;
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
    public partial class CRUDSubjectForm : Form
    {
        public CRUDSubjectForm()
        {
            InitializeComponent();
        }

        private void btnSubjectSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            Subject obj = new Subject();
            obj.Code = txtSubjectCode.Text;
            obj.Name = txtSubjectName.Text;
            SubjectBL.InsertSubject(obj);
            MessageBox.Show("Guardado exitoso", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            ClearFields();
        }

        private bool ValidateFields()
        {
            string name = txtSubjectName.Text;
            string code = txtSubjectCode.Text;
            string message = string.Empty;

            if(string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                message += "El campo Nombre es requerido. \n";
            }
            if(string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                message += "El campo Código es requerido. \n";
            }

            if(message.Length != 0)
            {
                MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        private void ClearFields()
        {
            txtSubjectName.Clear();
            txtSubjectCode.Clear();
        }
    }
}
