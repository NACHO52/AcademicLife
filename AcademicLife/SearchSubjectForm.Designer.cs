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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSubjectSearch = new System.Windows.Forms.Button();
            this.grdSubjects = new System.Windows.Forms.DataGridView();
            this.btnSubjectEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubjectSearch
            // 
            this.btnSubjectSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubjectSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            this.btnSubjectSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectSearch.FlatAppearance.BorderSize = 0;
            this.btnSubjectSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectSearch.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectSearch.Location = new System.Drawing.Point(12, 531);
            this.btnSubjectSearch.Name = "btnSubjectSearch";
            this.btnSubjectSearch.Size = new System.Drawing.Size(250, 38);
            this.btnSubjectSearch.TabIndex = 7;
            this.btnSubjectSearch.Text = "BUSCAR";
            this.btnSubjectSearch.UseVisualStyleBackColor = false;
            this.btnSubjectSearch.Click += new System.EventHandler(this.btnSubjectSearch_Click);
            // 
            // grdSubjects
            // 
            this.grdSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSubjects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.grdSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdSubjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSubjects.ColumnHeadersHeight = 30;
            this.grdSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdSubjects.EnableHeadersVisualStyles = false;
            this.grdSubjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.grdSubjects.Location = new System.Drawing.Point(12, 131);
            this.grdSubjects.Name = "grdSubjects";
            this.grdSubjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSubjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdSubjects.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            this.grdSubjects.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSubjects.Size = new System.Drawing.Size(773, 370);
            this.grdSubjects.TabIndex = 8;
            // 
            // btnSubjectEdit
            // 
            this.btnSubjectEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubjectEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            this.btnSubjectEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectEdit.FlatAppearance.BorderSize = 0;
            this.btnSubjectEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectEdit.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectEdit.Location = new System.Drawing.Point(12, 64);
            this.btnSubjectEdit.Name = "btnSubjectEdit";
            this.btnSubjectEdit.Size = new System.Drawing.Size(250, 38);
            this.btnSubjectEdit.TabIndex = 9;
            this.btnSubjectEdit.Text = "EDITAR";
            this.btnSubjectEdit.UseVisualStyleBackColor = false;
            this.btnSubjectEdit.Click += new System.EventHandler(this.btnSubjectEdit_Click);
            // 
            // SearchSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.btnSubjectEdit);
            this.Controls.Add(this.grdSubjects);
            this.Controls.Add(this.btnSubjectSearch);
            this.Name = "SearchSubjectForm";
            this.Text = "SearchSubjectForm";
            this.Load += new System.EventHandler(this.SearchSubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSubjectSearch;
        private System.Windows.Forms.DataGridView grdSubjects;
        private System.Windows.Forms.Button btnSubjectEdit;
    }
}