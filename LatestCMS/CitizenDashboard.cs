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
        public Session session1 = new Session();
        
        User_Control.TrackComplaintUserControl trackComplaint = new User_Control.TrackComplaintUserControl();


        public CitizenDashboard(Session session)
        {
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(trackComplaint);
            trackComplaint.Dock = DockStyle.Fill;

            session1 = session;
        }

        
        private void CitizenDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnFileComplaint_Click(object sender, EventArgs e)
        {
            User_Control.EnterComplaintUserControl enterComplaint = new User_Control.EnterComplaintUserControl(session1);
            panel1.Controls.Clear();
            panel1.Controls.Add(enterComplaint);
            enterComplaint.Dock = DockStyle.Fill;
        }

        private void btnViewComplaints_Click(object sender, EventArgs e)
        {
            User_Control.ViewUserOwnComplaintUserControl userOwnComplaint = new User_Control.ViewUserOwnComplaintUserControl(session1);
            panel1.Controls.Clear();
            panel1.Controls.Add(userOwnComplaint);
            userOwnComplaint.Dock = DockStyle.Fill;
        }

        private void btnTrackComplaint_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(trackComplaint);
            trackComplaint.Dock = DockStyle.Fill;
        }

        private void btnViewComplaints_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Teal;
        }

        private void btnFileComplaint_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.DarkCyan;
        }
    }
}
