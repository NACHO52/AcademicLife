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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            SetData();
        }

        private void SetData()
        {
            SystemUser obj = SystemUserBL.SystemUserGetMainUser();
            txtFirstName.Text = obj.FirstName;
            txtLastName.Text = obj.LastName;
        }
    }
}
