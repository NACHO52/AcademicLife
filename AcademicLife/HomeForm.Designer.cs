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
            this.components = new System.ComponentModel.Container();
            this.pnlSideMenuContainer = new System.Windows.Forms.Panel();
            this.pnlSubMenuSubjects = new System.Windows.Forms.Panel();
            this.btnSearchSubjects = new System.Windows.Forms.Button();
            this.btnCreateSubject = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.pnlLogoData = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.pnlSideMenuContainer.SuspendLayout();
            this.pnlSubMenuSubjects.SuspendLayout();
            this.pnlLogoData.SuspendLayout();
            this.pnlChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenuContainer
            // 
            this.pnlSideMenuContainer.AutoScroll = true;
            this.pnlSideMenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlSideMenuContainer.Controls.Add(this.pnlSubMenuSubjects);
            this.pnlSideMenuContainer.Controls.Add(this.btnSubjects);
            this.pnlSideMenuContainer.Controls.Add(this.btnProfile);
            this.pnlSideMenuContainer.Controls.Add(this.btnHome);
            this.pnlSideMenuContainer.Controls.Add(this.btnExitApplication);
            this.pnlSideMenuContainer.Controls.Add(this.pnlLogoData);
            this.pnlSideMenuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenuContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenuContainer.Name = "pnlSideMenuContainer";
            this.pnlSideMenuContainer.Size = new System.Drawing.Size(250, 671);
            this.pnlSideMenuContainer.TabIndex = 0;
            // 
            // pnlSubMenuSubjects
            // 
            this.pnlSubMenuSubjects.Controls.Add(this.btnSearchSubjects);
            this.pnlSubMenuSubjects.Controls.Add(this.btnCreateSubject);
            this.pnlSubMenuSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuSubjects.Location = new System.Drawing.Point(0, 268);
            this.pnlSubMenuSubjects.Name = "pnlSubMenuSubjects";
            this.pnlSubMenuSubjects.Size = new System.Drawing.Size(250, 80);
            this.pnlSubMenuSubjects.TabIndex = 3;
            // 
            // btnSearchSubjects
            // 
            this.btnSearchSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnSearchSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchSubjects.FlatAppearance.BorderSize = 0;
            this.btnSearchSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSubjects.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSearchSubjects.Location = new System.Drawing.Point(0, 40);
            this.btnSearchSubjects.Name = "btnSearchSubjects";
            this.btnSearchSubjects.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSearchSubjects.Size = new System.Drawing.Size(250, 40);
            this.btnSearchSubjects.TabIndex = 4;
            this.btnSearchSubjects.Text = "BUSCAR";
            this.btnSearchSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchSubjects.UseVisualStyleBackColor = false;
            this.btnSearchSubjects.Click += new System.EventHandler(this.btnSearchSubjects_Click);
            // 
            // btnCreateSubject
            // 
            this.btnCreateSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnCreateSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateSubject.FlatAppearance.BorderSize = 0;
            this.btnCreateSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSubject.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnCreateSubject.Location = new System.Drawing.Point(0, 0);
            this.btnCreateSubject.Name = "btnCreateSubject";
            this.btnCreateSubject.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnCreateSubject.Size = new System.Drawing.Size(250, 40);
            this.btnCreateSubject.TabIndex = 3;
            this.btnCreateSubject.Text = "CREAR";
            this.btnCreateSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateSubject.UseVisualStyleBackColor = false;
            this.btnCreateSubject.Click += new System.EventHandler(this.btnCreateSubject_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjects.FlatAppearance.BorderSize = 0;
            this.btnSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjects.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSubjects.Location = new System.Drawing.Point(0, 228);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnSubjects.Size = new System.Drawing.Size(250, 40);
            this.btnSubjects.TabIndex = 2;
            this.btnSubjects.Text = "MATERIAS";
            this.btnSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnProfile.Location = new System.Drawing.Point(0, 188);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(250, 40);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "PERFIL";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnHome.Location = new System.Drawing.Point(0, 148);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(250, 40);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApplication.FlatAppearance.BorderSize = 0;
            this.btnExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApplication.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnExitApplication.Location = new System.Drawing.Point(0, 561);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnExitApplication.Size = new System.Drawing.Size(250, 40);
            this.btnExitApplication.TabIndex = 4;
            this.btnExitApplication.Text = "SALIR";
            this.btnExitApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // pnlLogoData
            // 
            this.pnlLogoData.Controls.Add(this.lblDate);
            this.pnlLogoData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoData.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoData.Name = "pnlLogoData";
            this.pnlLogoData.Size = new System.Drawing.Size(250, 148);
            this.pnlLogoData.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 24);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label1";
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Controls.Add(this.lblTime);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(250, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1024, 671);
            this.pnlChildForm.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Roboto", 30.25F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(126)))));
            this.lblTime.Location = new System.Drawing.Point(434, 590);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(132, 49);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Enabled = true;
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1274, 671);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlSideMenuContainer);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Academic Life";
            this.pnlSideMenuContainer.ResumeLayout(false);
            this.pnlSubMenuSubjects.ResumeLayout(false);
            this.pnlLogoData.ResumeLayout(false);
            this.pnlLogoData.PerformLayout();
            this.pnlChildForm.ResumeLayout(false);
            this.pnlChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenuContainer;
        private System.Windows.Forms.Panel pnlLogoData;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.Panel pnlSubMenuSubjects;
        private System.Windows.Forms.Button btnSearchSubjects;
        private System.Windows.Forms.Button btnCreateSubject;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
    }
}

