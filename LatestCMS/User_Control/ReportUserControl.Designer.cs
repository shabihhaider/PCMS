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
            btnExportPDF = new Button();
            btnExportExcel = new Button();
            dgvReportData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReportData).BeginInit();
            SuspendLayout();
            // 
            // lblComplaintType
            // 
            lblComplaintType.AutoSize = true;
            lblComplaintType.Location = new Point(176, 119);
            lblComplaintType.Name = "lblComplaintType";
            lblComplaintType.Size = new Size(76, 20);
            lblComplaintType.TabIndex = 65;
            lblComplaintType.Text = "Start Date";
            // 
            // lblComplaintTitle
            // 
            lblComplaintTitle.AutoSize = true;
            lblComplaintTitle.Location = new Point(266, 23);
            lblComplaintTitle.Name = "lblComplaintTitle";
            lblComplaintTitle.Size = new Size(124, 20);
            lblComplaintTitle.TabIndex = 52;
            lblComplaintTitle.Text = "Generate Reports";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(311, 119);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 68;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(311, 164);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 164);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 69;
            label1.Text = "End Date";
            // 
            // cboStatusFilter
            // 
            cboStatusFilter.FormattingEnabled = true;
            cboStatusFilter.Items.AddRange(new object[] { "Pending", "In Progress", "Resolved " });
            cboStatusFilter.Location = new Point(311, 211);
            cboStatusFilter.Name = "cboStatusFilter";
            cboStatusFilter.Size = new Size(151, 28);
            cboStatusFilter.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 214);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 71;
            label2.Text = "Status Filter";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(130, 293);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(135, 29);
            btnGenerateReport.TabIndex = 73;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Location = new Point(282, 293);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(135, 29);
            btnExportPDF.TabIndex = 74;
            btnExportPDF.Text = "Export to PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(432, 293);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(135, 29);
            btnExportExcel.TabIndex = 75;
            btnExportExcel.Text = "Export to Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // dgvReportData
            // 
            dgvReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportData.Location = new Point(14, 371);
            dgvReportData.Name = "dgvReportData";
            dgvReportData.ReadOnly = true;
            dgvReportData.RowHeadersWidth = 51;
            dgvReportData.Size = new Size(744, 166);
            dgvReportData.TabIndex = 76;
            // 
            // ReportUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvReportData);
            Controls.Add(btnExportExcel);
            Controls.Add(btnExportPDF);
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
        private Button btnExportPDF;
        private Button btnExportExcel;
        private DataGridView dgvReportData;
    }
}
