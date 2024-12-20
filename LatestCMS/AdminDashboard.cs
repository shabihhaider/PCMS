using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatestCMS
{
    public partial class AdminDashboard : Form
    {
        User_Control.ManageUserControl manageUsers = new User_Control.ManageUserControl();
        User_Control.ReportUserControl reportGeneration = new User_Control.ReportUserControl();
        User_Control.ViewComplaintsUserControl viewComplaints = new User_Control.ViewComplaintsUserControl();
        User_Control.RegisterPoliceOfficerUserControl registerPoliceOfficer = new User_Control.RegisterPoliceOfficerUserControl();
        User_Control.ManagePoliceOfficerUserControl managePoliceOfficer = new User_Control.ManagePoliceOfficerUserControl();
        User_Control.AssignComplaintUserControl assignComplaint = new User_Control.AssignComplaintUserControl();
        public AdminDashboard()
        {
            InitializeComponent();
            panel2.Controls.Clear();
            panel2.Controls.Add(manageUsers);
            manageUsers.Dock = DockStyle.Fill;
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(manageUsers);
            manageUsers.Dock = DockStyle.Fill;
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(reportGeneration);
            reportGeneration.Dock = DockStyle.Fill;
        }

        private void btnViewComplaints_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(viewComplaints);
            viewComplaints.Dock = DockStyle.Fill;
        }

        private void btnRegisterPoliceOfficer_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(registerPoliceOfficer);
            registerPoliceOfficer.Dock = DockStyle.Fill;
        }

        private void btnManageOfficer_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(managePoliceOfficer);
            managePoliceOfficer.Dock = DockStyle.Fill;
        }

        private void btnAssignComplaint_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(assignComplaint);
            assignComplaint.Dock = DockStyle.Fill;
        }

        private void btnManageUsers_MouseEnter(object sender, EventArgs e)
        {
            hoverEffectEnter(sender);
        }

        private void btnManageUsers_MouseLeave(object sender, EventArgs e)
        {
            hoverEffectLeave(sender);
        }

        public void hoverEffectEnter(object sender)
        {
            Button button = sender as Button;
            button.BackColor = Color.Teal;
        }

        public void hoverEffectLeave(object sender)
        {
            Button button = sender as Button;
            button.BackColor = Color.DarkCyan;
        }

        private void btnViewComplaints_MouseEnter(object sender, EventArgs e)
        {
            hoverEffectEnter(sender);
        }

        private void btnViewComplaints_MouseLeave(object sender, EventArgs e)
        {
            hoverEffectLeave(sender);
        }

        private void btnGenerateReports_MouseLeave(object sender, EventArgs e)
        {
            hoverEffectLeave(sender);
        }
    }
}
