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
            this.grdSubjects = new System.Windows.Forms.DataGridView();
            this.btnSubjectSave = new System.Windows.Forms.Button();
            this.cnSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnSubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSubjects
            // 
            this.grdSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnSubjectName,
            this.cnSubjectCode});
            this.grdSubjects.Location = new System.Drawing.Point(12, 225);
            this.grdSubjects.Name = "grdSubjects";
            this.grdSubjects.Size = new System.Drawing.Size(604, 253);
            this.grdSubjects.TabIndex = 0;
            // 
            // btnSubjectSave
            // 
            this.btnSubjectSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubjectSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            this.btnSubjectSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectSave.FlatAppearance.BorderSize = 0;
            this.btnSubjectSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectSave.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectSave.Location = new System.Drawing.Point(408, 512);
            this.btnSubjectSave.Name = "btnSubjectSave";
            this.btnSubjectSave.Size = new System.Drawing.Size(208, 38);
            this.btnSubjectSave.TabIndex = 7;
            this.btnSubjectSave.Text = "BUSCAR";
            this.btnSubjectSave.UseVisualStyleBackColor = false;
            this.btnSubjectSave.Click += new System.EventHandler(this.btnSubjectSave_Click);
            // 
            // cnSubjectName
            // 
            this.cnSubjectName.HeaderText = "Nombre";
            this.cnSubjectName.Name = "cnSubjectName";
            this.cnSubjectName.ReadOnly = true;
            // 
            // cnSubjectCode
            // 
            this.cnSubjectCode.HeaderText = "Código";
            this.cnSubjectCode.Name = "cnSubjectCode";
            this.cnSubjectCode.ReadOnly = true;
            // 
            // SearchSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(628, 577);
            this.Controls.Add(this.btnSubjectSave);
            this.Controls.Add(this.grdSubjects);
            this.Name = "SearchSubjectForm";
            this.Text = "SearchSubjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSubjects;
        private System.Windows.Forms.Button btnSubjectSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnSubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnSubjectCode;
    }
}