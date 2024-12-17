using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata;
using iTextSharp.text.pdf;
using ClosedXML.Excel;
using OfficeOpenXml;

namespace LatestCMS.User_Control
{
    public partial class ReportUserControl : UserControl
    {
        private string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;";
        public ReportUserControl()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT ComplaintID, ComplaintTitle, ComplaintType, ContactName, Status, DateFiled " +
                               "FROM Complaints WHERE DateFiled BETWEEN @StartDate AND @EndDate";
                if (!string.IsNullOrEmpty(cboStatusFilter.Text))
                {
                    query += " AND Status = @Status";
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);

                    if (!string.IsNullOrEmpty(cboStatusFilter.Text))
                    {
                        cmd.Parameters.AddWithValue("@Status", cboStatusFilter.Text);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvReportData.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void LoadReportOptions()
        //{
        //    cboReportType.Items.Clear();
        //    cboReportType.Items.Add("Complaints by Date Range");
        //    cboReportType.Items.Add("Complaints by Type");
        //    cboReportType.Items.Add("Complaints by Status");
        //}

        //private void btnExportPDF_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Create a new PDF document
        //        Document doc = new Document();
        //        PdfWriter.GetInstance(doc, new FileStream("ComplaintReport.pdf", FileMode.Create));
        //        doc.Open();

        //        // Add a title
        //        doc.Add(new Paragraph("Complaint Report"));
        //        doc.Add(new Paragraph("Generated on: " + DateTime.Now.ToString()));

        //        // Add table with data from DataGridView
        //        PdfPTable table = new PdfPTable(dgvReportData.Columns.Count);
        //        foreach (DataGridViewColumn column in dgvReportData.Columns)
        //        {
        //            table.AddCell(column.HeaderText);  // Add column headers
        //        }

        //        foreach (DataGridViewRow row in dgvReportData.Rows)
        //        {
        //            foreach (DataGridViewCell cell in row.Cells)
        //            {
        //                table.AddCell(cell.Value.ToString());
        //            }
        //        }

        //        doc.Add(table);
        //        doc.Close();

        //        MessageBox.Show("Report exported to PDF successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvReportData.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Complaints Report");

                    // Add column headers
                    for (int col = 0; col < dgvReportData.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dgvReportData.Columns[col].HeaderText;
                    }

                    // Add row data
                    for (int row = 0; row < dgvReportData.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgvReportData.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dgvReportData.Rows[row].Cells[col].Value?.ToString();
                        }
                    }

                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ComplaintReport.xlsx");
                    File.WriteAllBytes(filePath, package.GetAsByteArray());

                    MessageBox.Show($"Report exported successfully to: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReportUserControl_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;
            cboStatusFilter.Items.AddRange(new string[] { "Pending", "Resolved", "In Progress" });
        }
    }
}
