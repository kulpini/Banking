using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Banking
{
    public partial class StatementForm : Form
    {
        public int cardID;
        public int client;
        private string reportStatus;
        public StatementForm()
        {
            InitializeComponent();
        }

        private void SaveResultsButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.DisplayAlerts = false;
            xlApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet workSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlApp.ActiveSheet;
            if (reportStatus == "operation")
            {
                workSheet.Cells[2, 2] = "Витяг операцiй по картцi клiєнта " + ClientNameLabel.Text;
                workSheet.Cells[3, 2] = "Номер картки - " + CardNameLabel.Text;
                workSheet.Cells[4, 2] = "Дата";
                workSheet.Cells[4, 3] = "Сума";
                workSheet.Cells[4, 4] = "Операцiя";
                int rowExcel = 5; //начать со второй строки.
                workSheet.Columns[2].ColumnWidth = 12;
                workSheet.Columns[3].ColumnWidth = 15;
                workSheet.Columns[4].ColumnWidth = 25;
                for (int i = 0; i < StatementDataGrid.Rows.Count; i++)
                {
                    //заполняем строку
                    workSheet.Cells[rowExcel, "B"] = StatementDataGrid.Rows[i].Cells["data"].Value;
                    workSheet.Cells[rowExcel, "C"] = StatementDataGrid.Rows[i].Cells["amount"].Value;
                    workSheet.Cells[rowExcel, "D"] = StatementDataGrid.Rows[i].Cells["type"].Value;
                    ++rowExcel;
                }
            }
            else if (reportStatus == "status")
            {
                workSheet.Cells[2, 2] = "Звiт по карткам клiєнта " + ClientNameLabel.Text;
                workSheet.Cells[4, 2] = "Номер картки";
                workSheet.Cells[4, 3] = "Статус картки";
                int rowExcel = 5; //начать со второй строки.
                workSheet.Columns[2].ColumnWidth = 15;
                workSheet.Columns[3].ColumnWidth = 15;
                for (int i = 0; i < StatementDataGrid.Rows.Count; i++)
                {
                    //заполняем строку
                    workSheet.Cells[rowExcel, "B"] = StatementDataGrid.Rows[i].Cells["cardnumber"].Value;
                    workSheet.Cells[rowExcel, "C"] = StatementDataGrid.Rows[i].Cells["active"].Value;
                    ++rowExcel;
                }
            }
            string pathToFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ReportLabel.Text+".xlsx");
            workSheet.SaveAs(pathToFile);
            xlApp.Quit();
            MessageBox.Show("Витяг збережено!", "Повiдомлення", MessageBoxButtons.OK);
        }

        private void DoQuery(string Command, string tableName)
        {
            mainForm form = new mainForm();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Command, form.ConnectionString);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, tableName);
            StatementDataGrid.DataSource = dataSet.Tables[0].DefaultView;
        }

        private void OperationReportButton_Click(object sender, EventArgs e)
        {
            reportStatus = "operation";
            SaveResultsButton.Enabled = true;
            ReportLabel.Text = "Звiт по операцiях по обранiй картцi";
            string SqlText = "SELECT data,amount,type FROM operation WHERE cardId=" + Convert.ToString(cardID) + "ORDER BY data DESC";
            DoQuery(SqlText, "operation");
            StatementDataGrid.Columns["data"].HeaderText = "Дата";
            StatementDataGrid.Columns["data"].Width = 80;
            StatementDataGrid.Columns["amount"].HeaderText = "Сума";
            StatementDataGrid.Columns["amount"].Width = 140;
            StatementDataGrid.Columns["type"].HeaderText = "Операцiя";
            StatementDataGrid.Columns["type"].Width = 200;
        }

        private void PaymentReportButton_Click(object sender, EventArgs e)
        {
            reportStatus = "operation";
            SaveResultsButton.Enabled = true;
            ReportLabel.Text = "Звiт по переказам з картки";
            string SqlText = "SELECT data,amount,type FROM operation WHERE cardId=" + Convert.ToString(cardID) + "AND type = N'списання' ORDER BY data DESC";
            DoQuery(SqlText, "operation");
            StatementDataGrid.Columns["data"].HeaderText = "Дата";
            StatementDataGrid.Columns["data"].Width = 80;
            StatementDataGrid.Columns["amount"].HeaderText = "Сума списання";
            StatementDataGrid.Columns["amount"].Width = 140;
            StatementDataGrid.Columns["type"].HeaderText = "Операцiя";
            StatementDataGrid.Columns["type"].Width = 200;
        }

        private void StatusReportButton_Click(object sender, EventArgs e)
        {
            reportStatus = "status";
            SaveResultsButton.Enabled = true;
            ReportLabel.Text = "Звiт по картках клiєнта";
            string SqlText = "SELECT cardnumber, case active when 1 then N'активна' else N'заблокована' end as active FROM card WHERE ownerId=" + Convert.ToString(client);
            DoQuery(SqlText, "card");
            StatementDataGrid.Columns["cardnumber"].HeaderText = "Номер картки";
            StatementDataGrid.Columns["cardnumber"].Width = 150;
            StatementDataGrid.Columns["active"].HeaderText = "Статус картки";
            StatementDataGrid.Columns["active"].Width = 100;
        }
    }
}
