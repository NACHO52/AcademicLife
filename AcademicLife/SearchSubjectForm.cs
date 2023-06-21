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
    public partial class SearchSubjectForm : Form
    {
        int objId = 0;
        public SearchSubjectForm()
        {
            InitializeComponent();
            FillComboPeriod();
            FillComboStatus();
        }

        private void FillComboStatus()
        {
            cmbSubjectStatus.ValueMember = "Id";
            cmbSubjectStatus.DisplayMember = "Name";
            cmbSubjectStatus.Items.Add(new ComboItem(Convert.ToInt32(SubjectStatus.Pending), "Pendiente"));
            cmbSubjectStatus.Items.Add(new ComboItem(Convert.ToInt32(SubjectStatus.InProgress), "En curso"));
            cmbSubjectStatus.Items.Add(new ComboItem(Convert.ToInt32(SubjectStatus.Approved), "Aprobado"));
        }

        public void FillComboPeriod()
        {
            cmbSubjectPeriod.ValueMember = "Id";
            cmbSubjectPeriod.DisplayMember = "Name";

            cmbSubjectPeriod.Items.Add(new ComboItem(Convert.ToInt32(SubjectPeriod.FirstQuarter), "Primer Cuatrimestre"));
            cmbSubjectPeriod.Items.Add(new ComboItem(Convert.ToInt32(SubjectPeriod.SecondQuarter), "Segundo Cuatrimestre"));
            cmbSubjectPeriod.Items.Add(new ComboItem(Convert.ToInt32(SubjectPeriod.ThirdQuarter), "Tercer Cuatrimestre"));
            cmbSubjectPeriod.Items.Add(new ComboItem(Convert.ToInt32(SubjectPeriod.FourthQuarter), "Cuarto Cuatrimestre"));
            cmbSubjectPeriod.Items.Add(new ComboItem(Convert.ToInt32(SubjectPeriod.FifthQuarter), "Quinto Cuatrimestre"));
            cmbSubjectPeriod.Items.Add(new ComboItem(Convert.ToInt32(SubjectPeriod.SixyhQuarter), "Sexto Cuatrimestre"));
            cmbSubjectPeriod.Items.Add(new ComboItem(Convert.ToInt32(SubjectPeriod.SeventhQuarter), "Séptimo Cuatrimestre"));
            cmbSubjectPeriod.Items.Add(new ComboItem(Convert.ToInt32(SubjectPeriod.EighthQuarter), "Octavo Cuatrimestre"));
            cmbSubjectPeriod.Items.Add(new ComboItem(Convert.ToInt32(SubjectPeriod.NinethQuarter), "Noveno Cuatrimestre"));
            cmbSubjectPeriod.Items.Add(new ComboItem(Convert.ToInt32(SubjectPeriod.TenthQuarter), "Décimo Cuatrimestre"));
            cmbSubjectPeriod.Items.Add(new ComboItem(Convert.ToInt32(SubjectPeriod.EleventhQuarter), "Undécimo Cuatrimestre"));
            cmbSubjectPeriod.Items.Add(new ComboItem(Convert.ToInt32(SubjectPeriod.TwelfthQuarter), "Duodécimo Cuatrimestre"));
        }

        private void SearchSubjectForm_Load(object sender, EventArgs e)
        {

        }

        private void BindSubjects()
        {
            //grdSubjects.DataSource = new DataTable();
            grdSubjects.AutoGenerateColumns = false;
            if(grdSubjects.Columns.Count == 0) grdSubjects.ColumnCount = 9;

            grdSubjects.Columns[0].HeaderText = "Id";
            grdSubjects.Columns[0].DataPropertyName = "Id";
            grdSubjects.Columns[0].Name = "Id";
            grdSubjects.Columns[0].Visible = false;

            grdSubjects.Columns[1].HeaderText = "Nombre";
            grdSubjects.Columns[1].DataPropertyName = "Name";
            grdSubjects.Columns[1].Name = "Name";
            grdSubjects.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            grdSubjects.Columns[2].HeaderText = "Código";
            grdSubjects.Columns[2].DataPropertyName = "Code";
            grdSubjects.Columns[2].Name = "Code";
            grdSubjects.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            grdSubjects.Columns[3].HeaderText = "Creditos";
            grdSubjects.Columns[3].DataPropertyName = "Credits";
            grdSubjects.Columns[3].Name = "Credits";
            grdSubjects.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grdSubjects.Columns[4].HeaderText = "Horas";
            grdSubjects.Columns[4].DataPropertyName = "Hours";
            grdSubjects.Columns[4].Name = "Hours";
            grdSubjects.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grdSubjects.Columns[5].HeaderText = "Periodo";
            grdSubjects.Columns[5].DataPropertyName = "PeriodValue";
            grdSubjects.Columns[5].Name = "PeriodValue";
            grdSubjects.Columns[5].Visible = false;

            grdSubjects.Columns[6].HeaderText = "Periodo";
            grdSubjects.Columns[6].DataPropertyName = "PeriodName";
            grdSubjects.Columns[6].Name = "PeriodName";
            grdSubjects.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            grdSubjects.Columns[7].HeaderText = "Estado";
            grdSubjects.Columns[7].DataPropertyName = "StatusValue";
            grdSubjects.Columns[7].Name = "StatusValue";
            grdSubjects.Columns[7].Visible = false;

            grdSubjects.Columns[8].HeaderText = "Estado";
            grdSubjects.Columns[8].DataPropertyName = "StatusName";
            grdSubjects.Columns[8].Name = "StatusName";
            grdSubjects.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            grdSubjects.DataSource = SubjectBL.SubjectGetByStore(string.Empty, string.Empty, null,null,null,null);
        }

        private void btnSubjectSearch_Click(object sender, EventArgs e)
        {
            BindSubjects();
        }

        private void btnSubjectEdit_Click(object sender, EventArgs e)
        {
            if (grdSubjects.SelectedRows.Count == 1)
            {
                objId = Convert.ToInt32(grdSubjects.CurrentRow.Cells["Id"].Value.ToString());
                txtSubjectName.Text = grdSubjects.CurrentRow.Cells["Name"].Value.ToString();
                txtSubjectCode.Text = grdSubjects.CurrentRow.Cells["Code"].Value.ToString();
                txtSubjectCredits.Text = grdSubjects.CurrentRow.Cells["Credits"].Value.ToString();
                txtSubjectHours.Text = grdSubjects.CurrentRow.Cells["Hours"].Value.ToString();
                cmbSubjectPeriod.SelectedIndex = cmbSubjectPeriod.FindStringExact(grdSubjects.CurrentRow.Cells["PeriodName"].Value.ToString());
                cmbSubjectStatus.SelectedIndex = cmbSubjectStatus.FindStringExact(grdSubjects.CurrentRow.Cells["StatusName"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (grdSubjects.SelectedRows.Count == 1)
            {
                string subject = grdSubjects.CurrentRow.Cells["Name"].Value.ToString();
                if (MessageBox.Show("¿Desea eliminar la materia \"" + subject + "\"?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(grdSubjects.CurrentRow.Cells["Id"].Value.ToString());
                    SubjectBL.DeleteSubject(id);
                    BindSubjects();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool ValidateFields()
        {
            string name = txtSubjectName.Text;
            string code = txtSubjectCode.Text;
            string credits = txtSubjectCredits.Text;
            string hour = txtSubjectHours.Text;
            string message = string.Empty;

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                message += "El campo \"Nombre\" es requerido. \n";
            }
            if (string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                message += "El campo \"Código\" es requerido. \n";
            }
            if (string.IsNullOrEmpty(credits) || string.IsNullOrWhiteSpace(credits))
            {
                message += "El campo \"Horas\" es requerido. \n";
            }
            if (string.IsNullOrEmpty(hour) || string.IsNullOrWhiteSpace(hour))
            {
                message += "El campo \"Creditos\" es requerido. \n";
            }
            if (cmbSubjectPeriod.SelectedItem == null)
            {
                message += "El campo \"Periodo\" es requerido. \n";
            }
            if (cmbSubjectStatus.SelectedItem == null)
            {
                message += "El campo \"Estado\" es requerido. \n";
            }

            if (message.Length != 0)
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
            txtSubjectCredits.Clear();
            txtSubjectHours.Clear();
            cmbSubjectPeriod.SelectedItem = null;
            cmbSubjectStatus.SelectedItem = null;
            objId = 0;
        }

        private void btnSubjectSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            Subject obj = new Subject();
            obj.Id = objId;
            obj.Code = txtSubjectCode.Text;
            obj.Name = txtSubjectName.Text;
            obj.Credits = Convert.ToInt32(txtSubjectCredits.Text);
            obj.Hours = Convert.ToInt32(txtSubjectHours.Text);
            obj.Period = (SubjectPeriod)((ComboItem)(cmbSubjectPeriod.SelectedItem)).Id;
            obj.Status = (SubjectStatus)((ComboItem)(cmbSubjectStatus.SelectedItem)).Id;
            SubjectBL.SaveSubject(obj);
            MessageBox.Show("Guardado exitoso", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            ClearFields();
            BindSubjects();
        }

        private void btnSubjectCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnNewSubject_Click(object sender, EventArgs e)
        {

        }
    }
}
