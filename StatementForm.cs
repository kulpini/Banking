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
        public StatementForm()
        {
            InitializeComponent();
        }

        private void StatementForm_Load(object sender, EventArgs e)
        {
            string SqlText = "SELECT * FROM operation WHERE cardId=" + Convert.ToString(cardID)+"ORDER BY data DESC";
            mainForm form = new mainForm();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(SqlText, form.ConnectionString);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "operation");
            StatementDataGrid.DataSource = dataSet.Tables["operation"].DefaultView;
            StatementDataGrid.Columns["Id"].Visible = false;
            StatementDataGrid.Columns["data"].HeaderText = "Дата";
            StatementDataGrid.Columns["data"].Width = 80;
            StatementDataGrid.Columns["cardID"].Visible = false;
            StatementDataGrid.Columns["amount"].HeaderText = "Сума";
            StatementDataGrid.Columns["amount"].Width = 140;
            StatementDataGrid.Columns["type"].HeaderText = "Операцiя";
            StatementDataGrid.Columns["type"].Width = 200;
        }

        private void SaveResultsButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.DisplayAlerts = false;
            xlApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet workSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlApp.ActiveSheet;
            workSheet.Cells[2, 2] = "Витяг операцiй по картцi клiєнта "+ClientNameLabel.Text;
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
            string pathToFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Витяг по картцi.xlsx");
            workSheet.SaveAs(pathToFile);
            xlApp.Quit();
            MessageBox.Show("Витяг збережено!", "Повiдомлення", MessageBoxButtons.OK);
        }
    }
}
