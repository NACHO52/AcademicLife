namespace AcademicLife
{
    partial class CRUDSubjectForm
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
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.btnSubjectSave = new System.Windows.Forms.Button();
            this.lblSubjectTitle = new System.Windows.Forms.Label();
            this.lblSubjectCode = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSubjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtSubjectName.Location = new System.Drawing.Point(151, 134);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(385, 30);
            this.txtSubjectName.TabIndex = 0;
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSubjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lblSubjectName.Location = new System.Drawing.Point(58, 132);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(87, 25);
            this.lblSubjectName.TabIndex = 3;
            this.lblSubjectName.Text = "Nombre:";
            // 
            // btnSubjectSave
            // 
            this.btnSubjectSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubjectSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            this.btnSubjectSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectSave.FlatAppearance.BorderSize = 0;
            this.btnSubjectSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectSave.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjectSave.Location = new System.Drawing.Point(63, 527);
            this.btnSubjectSave.Name = "btnSubjectSave";
            this.btnSubjectSave.Size = new System.Drawing.Size(203, 38);
            this.btnSubjectSave.TabIndex = 6;
            this.btnSubjectSave.Text = "GUARDAR";
            this.btnSubjectSave.UseVisualStyleBackColor = false;
            this.btnSubjectSave.Click += new System.EventHandler(this.btnSubjectSave_Click);
            // 
            // lblSubjectTitle
            // 
            this.lblSubjectTitle.AutoSize = true;
            this.lblSubjectTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblSubjectTitle.Font = new System.Drawing.Font("Roboto Black", 25F, System.Drawing.FontStyle.Bold);
            this.lblSubjectTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lblSubjectTitle.Location = new System.Drawing.Point(56, 39);
            this.lblSubjectTitle.Name = "lblSubjectTitle";
            this.lblSubjectTitle.Size = new System.Drawing.Size(137, 41);
            this.lblSubjectTitle.TabIndex = 8;
            this.lblSubjectTitle.Text = "Materia";
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSubjectCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lblSubjectCode.Location = new System.Drawing.Point(58, 192);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(81, 25);
            this.lblSubjectCode.TabIndex = 10;
            this.lblSubjectCode.Text = "Código:";
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtSubjectCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSubjectCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtSubjectCode.Location = new System.Drawing.Point(151, 190);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(385, 30);
            this.txtSubjectCode.TabIndex = 9;
            // 
            // CRUDSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.lblSubjectCode);
            this.Controls.Add(this.txtSubjectCode);
            this.Controls.Add(this.lblSubjectTitle);
            this.Controls.Add(this.btnSubjectSave);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.txtSubjectName);
            this.Name = "CRUDSubjectForm";
            this.Text = "CRUDSubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Button btnSubjectSave;
        private System.Windows.Forms.Label lblSubjectTitle;
        private System.Windows.Forms.Label lblSubjectCode;
        private System.Windows.Forms.TextBox txtSubjectCode;
    }
}