using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatestCMS
{
    public partial class CitizenDashboard : Form
    {
        User_Control.EnterComplaintUserControl enterComplaint = new User_Control.EnterComplaintUserControl();
        User_Control.ViewComplaintsUserControl viewComplaints = new User_Control.ViewComplaintsUserControl();
        User_Control.TrackComplaintUserControl trackComplaint = new User_Control.TrackComplaintUserControl();
        public CitizenDashboard()
        {
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(enterComplaint);
            enterComplaint.Dock = DockStyle.Fill;
        }



        private void CitizenDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnFileComplaint_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(enterComplaint);
            enterComplaint.Dock = DockStyle.Fill;
        }

        private void btnViewComplaints_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(viewComplaints);
            viewComplaints.Dock = DockStyle.Fill;
        }

        private void btnTrackComplaint_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(trackComplaint);
            trackComplaint.Dock = DockStyle.Fill;
        }
    }
}
