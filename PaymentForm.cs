using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class PaymentForm : Form
    {
        public int cardID;
        public double cardAmount;
        public PaymentForm()
        {
            InitializeComponent();
        }

        public void MyExecuteNonQuery(string SqlText)
        {
            SqlConnection connnection; // экземпляр класса типа SqlConnection
            SqlCommand command;

            mainForm form = new mainForm();
            // выделение памяти с инициализацией строки соединения с базой данных
            connnection = new SqlConnection(form.ConnectionString);
            connnection.Open(); // открыть источник данных
            command = connnection.CreateCommand(); // задать SQL-команду
            command.CommandText = SqlText; // задать командную строку
            command.ExecuteNonQuery(); // выполнить SQL-команду
            connnection.Close(); // закрыть источник данных
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            double paymentAmount;
            if (AmountTextBox.Text == "") 
                paymentAmount = 0;
            else 
                paymentAmount = Convert.ToDouble(AmountTextBox.Text);
            if (paymentAmount > cardAmount)
                MessageBox.Show("Недостатньо коштiв для виконання переказу!", "Помилка списання коштiв", MessageBoxButtons.OK);
            else
            {
                cardAmount -= paymentAmount;
                string paymentDate = (DateTime.Now).ToString("yyyy.MM.dd"); 
                string paymentType = "списання";
                string SqlText = "INSERT INTO operation (data,cardId,amount,type) VALUES ";
                SqlText += "(\'"+ paymentDate + "\'," + Convert.ToString(cardID) + "," + Convert.ToString(paymentAmount).Replace(",",".") + ",N\'"+paymentType+"\')";
                MyExecuteNonQuery(SqlText);
                AmountLabel.Text = Convert.ToString(cardAmount);
                SqlText = "UPDATE card SET balance = \'" + Convert.ToString(cardAmount).Replace(",", ".") + "\' WHERE Id =" + Convert.ToString(cardID);
                MyExecuteNonQuery(SqlText);
                MessageBox.Show("Переказ успiшно проведено.", "операцiя списання коштiв", MessageBoxButtons.OK);
                AmountTextBox.Clear();
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            AmountLabel.Text = Convert.ToString(cardAmount);
        }
    }
}
