namespace AcademicLife
{
    partial class Home
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
            this.pnlSideMenuContainer = new System.Windows.Forms.Panel();
            this.pnlLogoData = new System.Windows.Forms.Panel();
            this.btnSubjects = new AcademicLife.Style.MenuButton();
            this.btnProfile = new AcademicLife.Style.MenuButton();
            this.pnlSideMenuContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenuContainer
            // 
            this.pnlSideMenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlSideMenuContainer.Controls.Add(this.btnSubjects);
            this.pnlSideMenuContainer.Controls.Add(this.btnProfile);
            this.pnlSideMenuContainer.Controls.Add(this.pnlLogoData);
            this.pnlSideMenuContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenuContainer.Name = "pnlSideMenuContainer";
            this.pnlSideMenuContainer.Size = new System.Drawing.Size(250, 573);
            this.pnlSideMenuContainer.TabIndex = 0;
            // 
            // pnlLogoData
            // 
            this.pnlLogoData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoData.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoData.Name = "pnlLogoData";
            this.pnlLogoData.Size = new System.Drawing.Size(250, 148);
            this.pnlLogoData.TabIndex = 0;
            // 
            // btnSubjects
            // 
            this.btnSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjects.Location = new System.Drawing.Point(0, 188);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(250, 40);
            this.btnSubjects.TabIndex = 1;
            this.btnSubjects.Text = "MATERIAS";
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.Location = new System.Drawing.Point(0, 148);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(250, 40);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "PERFIL";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(808, 573);
            this.Controls.Add(this.pnlSideMenuContainer);
            this.Name = "Home";
            this.Text = "Academic Life";
            this.pnlSideMenuContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenuContainer;
        private Style.MenuButton btnProfile;
        private System.Windows.Forms.Panel pnlLogoData;
        private Style.MenuButton btnSubjects;
    }
}

