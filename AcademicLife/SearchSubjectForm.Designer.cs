namespace AcademicLife
{
    partial class SearchSubjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSubjectSearch = new System.Windows.Forms.Button();
            this.grdSubjects = new System.Windows.Forms.DataGridView();
            this.btnSubjectEdit = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.lblSubjectCode = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.lblSubjectCredits = new System.Windows.Forms.Label();
            this.lblSubjectPeriod = new System.Windows.Forms.Label();
            this.txtSubjectCredits = new System.Windows.Forms.TextBox();
            this.lblSubjectHours = new System.Windows.Forms.Label();
            this.txtSubjectHours = new System.Windows.Forms.TextBox();
            this.btnSubjectSave = new System.Windows.Forms.Button();
            this.cmbSubjectPeriod = new System.Windows.Forms.ComboBox();
            this.cmbSubjectStatus = new System.Windows.Forms.ComboBox();
            this.lblSubjectStatus = new System.Windows.Forms.Label();
            this.btnSubjectCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubjectSearch
            // 
            this.btnSubjectSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubjectSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            this.btnSubjectSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectSearch.FlatAppearance.BorderSize = 0;
            this.btnSubjectSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectSearch.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectSearch.Location = new System.Drawing.Point(12, 580);
            this.btnSubjectSearch.Name = "btnSubjectSearch";
            this.btnSubjectSearch.Size = new System.Drawing.Size(200, 40);
            this.btnSubjectSearch.TabIndex = 7;
            this.btnSubjectSearch.Text = "BUSCAR";
            this.btnSubjectSearch.UseVisualStyleBackColor = false;
            this.btnSubjectSearch.Click += new System.EventHandler(this.btnSubjectSearch_Click);
            // 
            // grdSubjects
            // 
            this.grdSubjects.AllowUserToAddRows = false;
            this.grdSubjects.AllowUserToDeleteRows = false;
            this.grdSubjects.AllowUserToOrderColumns = true;
            this.grdSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSubjects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.grdSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdSubjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.grdSubjects.ColumnHeadersHeight = 30;
            this.grdSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdSubjects.EnableHeadersVisualStyles = false;
            this.grdSubjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.grdSubjects.Location = new System.Drawing.Point(12, 398);
            this.grdSubjects.Name = "grdSubjects";
            this.grdSubjects.ReadOnly = true;
            this.grdSubjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSubjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.grdSubjects.RowHeadersVisible = false;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            this.grdSubjects.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.grdSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSubjects.Size = new System.Drawing.Size(778, 178);
            this.grdSubjects.TabIndex = 8;
            // 
            // btnSubjectEdit
            // 
            this.btnSubjectEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubjectEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            this.btnSubjectEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectEdit.FlatAppearance.BorderSize = 0;
            this.btnSubjectEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectEdit.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectEdit.Location = new System.Drawing.Point(796, 444);
            this.btnSubjectEdit.Name = "btnSubjectEdit";
            this.btnSubjectEdit.Size = new System.Drawing.Size(200, 40);
            this.btnSubjectEdit.TabIndex = 9;
            this.btnSubjectEdit.Text = "EDITAR";
            this.btnSubjectEdit.UseVisualStyleBackColor = false;
            this.btnSubjectEdit.Click += new System.EventHandler(this.btnSubjectEdit_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDeleteSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDeleteSubject.FlatAppearance.BorderSize = 0;
            this.btnDeleteSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSubject.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDeleteSubject.Location = new System.Drawing.Point(796, 580);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteSubject.TabIndex = 10;
            this.btnDeleteSubject.Text = "ELIMINAR";
            this.btnDeleteSubject.UseVisualStyleBackColor = false;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSubjectCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lblSubjectCode.Location = new System.Drawing.Point(62, 86);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(81, 25);
            this.lblSubjectCode.TabIndex = 14;
            this.lblSubjectCode.Text = "Código:";
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtSubjectCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSubjectCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtSubjectCode.Location = new System.Drawing.Point(180, 84);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(128, 30);
            this.txtSubjectCode.TabIndex = 13;
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSubjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lblSubjectName.Location = new System.Drawing.Point(62, 40);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(87, 25);
            this.lblSubjectName.TabIndex = 12;
            this.lblSubjectName.Text = "Nombre:";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSubjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtSubjectName.Location = new System.Drawing.Point(180, 38);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(385, 30);
            this.txtSubjectName.TabIndex = 11;
            // 
            // lblSubjectCredits
            // 
            this.lblSubjectCredits.AutoSize = true;
            this.lblSubjectCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSubjectCredits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lblSubjectCredits.Location = new System.Drawing.Point(62, 129);
            this.lblSubjectCredits.Name = "lblSubjectCredits";
            this.lblSubjectCredits.Size = new System.Drawing.Size(91, 25);
            this.lblSubjectCredits.TabIndex = 15;
            this.lblSubjectCredits.Text = "Créditos:";
            // 
            // lblSubjectPeriod
            // 
            this.lblSubjectPeriod.AutoSize = true;
            this.lblSubjectPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSubjectPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lblSubjectPeriod.Location = new System.Drawing.Point(62, 215);
            this.lblSubjectPeriod.Name = "lblSubjectPeriod";
            this.lblSubjectPeriod.Size = new System.Drawing.Size(85, 25);
            this.lblSubjectPeriod.TabIndex = 16;
            this.lblSubjectPeriod.Text = "Periodo:";
            // 
            // txtSubjectCredits
            // 
            this.txtSubjectCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtSubjectCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubjectCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSubjectCredits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtSubjectCredits.Location = new System.Drawing.Point(180, 127);
            this.txtSubjectCredits.Name = "txtSubjectCredits";
            this.txtSubjectCredits.Size = new System.Drawing.Size(128, 30);
            this.txtSubjectCredits.TabIndex = 17;
            // 
            // lblSubjectHours
            // 
            this.lblSubjectHours.AutoSize = true;
            this.lblSubjectHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSubjectHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lblSubjectHours.Location = new System.Drawing.Point(62, 170);
            this.lblSubjectHours.Name = "lblSubjectHours";
            this.lblSubjectHours.Size = new System.Drawing.Size(70, 25);
            this.lblSubjectHours.TabIndex = 19;
            this.lblSubjectHours.Text = "Horas:";
            // 
            // txtSubjectHours
            // 
            this.txtSubjectHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtSubjectHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubjectHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSubjectHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtSubjectHours.Location = new System.Drawing.Point(180, 168);
            this.txtSubjectHours.Name = "txtSubjectHours";
            this.txtSubjectHours.Size = new System.Drawing.Size(128, 30);
            this.txtSubjectHours.TabIndex = 20;
            // 
            // btnSubjectSave
            // 
            this.btnSubjectSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubjectSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            this.btnSubjectSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectSave.FlatAppearance.BorderSize = 0;
            this.btnSubjectSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectSave.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectSave.Location = new System.Drawing.Point(796, 398);
            this.btnSubjectSave.Name = "btnSubjectSave";
            this.btnSubjectSave.Size = new System.Drawing.Size(200, 40);
            this.btnSubjectSave.TabIndex = 21;
            this.btnSubjectSave.Text = "GUARDAR";
            this.btnSubjectSave.UseVisualStyleBackColor = false;
            this.btnSubjectSave.Click += new System.EventHandler(this.btnSubjectSave_Click);
            // 
            // cmbSubjectPeriod
            // 
            this.cmbSubjectPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cmbSubjectPeriod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSubjectPeriod.DisplayMember = "Name";
            this.cmbSubjectPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjectPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubjectPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbSubjectPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.cmbSubjectPeriod.FormattingEnabled = true;
            this.cmbSubjectPeriod.Location = new System.Drawing.Point(180, 212);
            this.cmbSubjectPeriod.Name = "cmbSubjectPeriod";
            this.cmbSubjectPeriod.Size = new System.Drawing.Size(303, 33);
            this.cmbSubjectPeriod.TabIndex = 22;
            this.cmbSubjectPeriod.ValueMember = "Id";
            // 
            // cmbSubjectStatus
            // 
            this.cmbSubjectStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cmbSubjectStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSubjectStatus.DisplayMember = "Name";
            this.cmbSubjectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjectStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubjectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbSubjectStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.cmbSubjectStatus.FormattingEnabled = true;
            this.cmbSubjectStatus.Location = new System.Drawing.Point(180, 262);
            this.cmbSubjectStatus.Name = "cmbSubjectStatus";
            this.cmbSubjectStatus.Size = new System.Drawing.Size(193, 33);
            this.cmbSubjectStatus.TabIndex = 23;
            this.cmbSubjectStatus.ValueMember = "Id";
            // 
            // lblSubjectStatus
            // 
            this.lblSubjectStatus.AutoSize = true;
            this.lblSubjectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSubjectStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lblSubjectStatus.Location = new System.Drawing.Point(62, 265);
            this.lblSubjectStatus.Name = "lblSubjectStatus";
            this.lblSubjectStatus.Size = new System.Drawing.Size(79, 25);
            this.lblSubjectStatus.TabIndex = 24;
            this.lblSubjectStatus.Text = "Estado:";
            // 
            // btnSubjectCancel
            // 
            this.btnSubjectCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubjectCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            this.btnSubjectCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectCancel.FlatAppearance.BorderSize = 0;
            this.btnSubjectCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectCancel.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectCancel.Location = new System.Drawing.Point(796, 490);
            this.btnSubjectCancel.Name = "btnSubjectCancel";
            this.btnSubjectCancel.Size = new System.Drawing.Size(200, 40);
            this.btnSubjectCancel.TabIndex = 25;
            this.btnSubjectCancel.Text = "CANCELAR";
            this.btnSubjectCancel.UseVisualStyleBackColor = false;
            this.btnSubjectCancel.Click += new System.EventHandler(this.btnSubjectCancel_Click);
            // 
            // SearchSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.btnSubjectCancel);
            this.Controls.Add(this.lblSubjectStatus);
            this.Controls.Add(this.cmbSubjectStatus);
            this.Controls.Add(this.cmbSubjectPeriod);
            this.Controls.Add(this.btnSubjectSave);
            this.Controls.Add(this.txtSubjectHours);
            this.Controls.Add(this.lblSubjectHours);
            this.Controls.Add(this.txtSubjectCredits);
            this.Controls.Add(this.lblSubjectPeriod);
            this.Controls.Add(this.lblSubjectCredits);
            this.Controls.Add(this.lblSubjectCode);
            this.Controls.Add(this.txtSubjectCode);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnSubjectEdit);
            this.Controls.Add(this.grdSubjects);
            this.Controls.Add(this.btnSubjectSearch);
            this.Name = "SearchSubjectForm";
            this.Text = "SearchSubjectForm";
            this.Load += new System.EventHandler(this.SearchSubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubjectSearch;
        private System.Windows.Forms.DataGridView grdSubjects;
        private System.Windows.Forms.Button btnSubjectEdit;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Label lblSubjectCode;
        private System.Windows.Forms.TextBox txtSubjectCode;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label lblSubjectCredits;
        private System.Windows.Forms.Label lblSubjectPeriod;
        private System.Windows.Forms.TextBox txtSubjectCredits;
        private System.Windows.Forms.Label lblSubjectHours;
        private System.Windows.Forms.TextBox txtSubjectHours;
        private System.Windows.Forms.Button btnSubjectSave;
        private System.Windows.Forms.ComboBox cmbSubjectPeriod;
        private System.Windows.Forms.ComboBox cmbSubjectStatus;
        private System.Windows.Forms.Label lblSubjectStatus;
        private System.Windows.Forms.Button btnSubjectCancel;
    }
}