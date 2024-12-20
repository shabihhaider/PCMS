namespace LatestCMS.User_Control
{
    partial class ReportUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblComplaintType = new Label();
            lblComplaintTitle = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label1 = new Label();
            cboStatusFilter = new ComboBox();
            label2 = new Label();
            btnGenerateReport = new Button();
            btnExportExcel = new Button();
            dgvReportData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReportData).BeginInit();
            SuspendLayout();
            // 
            // lblComplaintType
            // 
            lblComplaintType.AutoSize = true;
            lblComplaintType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblComplaintType.Location = new Point(184, 88);
            lblComplaintType.Name = "lblComplaintType";
            lblComplaintType.Size = new Size(87, 23);
            lblComplaintType.TabIndex = 65;
            lblComplaintType.Text = "Start Date";
            // 
            // lblComplaintTitle
            // 
            lblComplaintTitle.AutoSize = true;
            lblComplaintTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplaintTitle.ForeColor = Color.DarkCyan;
            lblComplaintTitle.Location = new Point(280, 23);
            lblComplaintTitle.Name = "lblComplaintTitle";
            lblComplaintTitle.Size = new Size(178, 24);
            lblComplaintTitle.TabIndex = 52;
            lblComplaintTitle.Text = "Generate Reports";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 10F);
            dtpStartDate.Location = new Point(319, 88);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(269, 30);
            dtpStartDate.TabIndex = 68;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 10F);
            dtpEndDate.Location = new Point(319, 133);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(269, 30);
            dtpEndDate.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(184, 133);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 69;
            label1.Text = "End Date";
            // 
            // cboStatusFilter
            // 
            cboStatusFilter.Font = new Font("Segoe UI", 10F);
            cboStatusFilter.FormattingEnabled = true;
            cboStatusFilter.Items.AddRange(new object[] { "Pending", "In Progress", "Resolved " });
            cboStatusFilter.Location = new Point(319, 180);
            cboStatusFilter.Name = "cboStatusFilter";
            cboStatusFilter.Size = new Size(151, 31);
            cboStatusFilter.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(184, 183);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 71;
            label2.Text = "Status Filter";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGenerateReport.Location = new Point(208, 247);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(135, 29);
            btnGenerateReport.TabIndex = 73;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            btnGenerateReport.MouseEnter += btnGenerateReport_MouseEnter;
            btnGenerateReport.MouseLeave += btnGenerateReport_MouseLeave;
            // 
            // btnExportExcel
            // 
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnExportExcel.Location = new Point(410, 247);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(135, 29);
            btnExportExcel.TabIndex = 75;
            btnExportExcel.Text = "Export to Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            btnExportExcel.MouseEnter += btnGenerateReport_MouseEnter;
            btnExportExcel.MouseLeave += btnGenerateReport_MouseLeave;
            // 
            // dgvReportData
            // 
            dgvReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportData.Location = new Point(15, 304);
            dgvReportData.Name = "dgvReportData";
            dgvReportData.ReadOnly = true;
            dgvReportData.RowHeadersWidth = 51;
            dgvReportData.Size = new Size(744, 278);
            dgvReportData.TabIndex = 76;
            // 
            // ReportUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvReportData);
            Controls.Add(btnExportExcel);
            Controls.Add(btnGenerateReport);
            Controls.Add(cboStatusFilter);
            Controls.Add(label2);
            Controls.Add(dtpEndDate);
            Controls.Add(label1);
            Controls.Add(dtpStartDate);
            Controls.Add(lblComplaintType);
            Controls.Add(lblComplaintTitle);
            Name = "ReportUserControl";
            Size = new Size(777, 610);
            Load += ReportUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReportData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblComplaintType;
        private Label lblComplaintTitle;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label1;
        private ComboBox cboStatusFilter;
        private Label label2;
        private Button btnGenerateReport;
        private Button btnExportExcel;
        private DataGridView dgvReportData;
    }
}
