using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class mainForm : Form
    {
        public int clientId;
        public string clientName = "";
        static string pathToDb = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "banking.mdf");
        //public string ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = " + pathToDb+";Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + pathToDb + ";Integrated Security=True;Connect Timeout=30";
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (loginForm.DialogResult == DialogResult.OK)
            {
                string clientAddress, clientPhone;
                clientId = loginForm.clientID;
                string SqlText = "SELECT FIO,address,phone FROM client WHERE Id=" + clientId;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = SqlText;
                DbDataReader reader = command.ExecuteReader();
                reader.Read();
                clientName = Convert.ToString(reader["FIO"]);
                clientAddress = Convert.ToString(reader["address"]);
                clientPhone = Convert.ToString(reader["phone"]);
                ClientNameLabel.Text = "Ласкаво просимо, " + clientName;
                AddressLabel.Text = clientAddress + "   " + clientPhone;

                SqlText = "SELECT Id,cardnumber,balance,active FROM card WHERE ownerId =" + clientId;
                ShowCards(SqlText);
            }
        }

        private void CardsDataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (CardsDataGrid.CurrentCell != null)
            {
                int index = CardsDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                double amount = Convert.ToDouble(CardsDataGrid[2, index].Value);
                int active = Convert.ToInt32(CardsDataGrid[3, index].Value);
                UahLabel.Text = Convert.ToString(amount);
                UsdLabel.Text = (amount / 26.8).ToString("0.00");
                EurLabel.Text = (amount / 29).ToString("0.00");
                CardStateLabel.Text = active == 0 ? "заблокована" : "активна";
                CardStateLabel.ForeColor = active == 0 ? Color.Red : Color.Green;
            }
        }

        private void ChatPicture_MouseClick(object sender, MouseEventArgs e)
        {
            ChatPanel.Top -= 357;
            ChatPanel.Height += 357;
            ChatPicture.Visible = false;
            CloseChatPictureBox.Visible = true;
        }

        private void CloseChatPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            ChatPanel.Top += 357;
            ChatPanel.Height -= 357;
            ChatPicture.Visible = true;
            CloseChatPictureBox.Visible = false;
        }

        private void ChatButton_Click(object sender, EventArgs e)
        {
            ChatListBox.Items.Add("...............");
            ChatListBox.Items.Add("Ви:");
            ChatListBox.Items.Add(MessageTextBox.Text);
            MessageTextBox.Clear();
            ChatListBox.Items.Add("...............");
            ChatListBox.Items.Add("Оператор:");
            ChatListBox.Items.Add("Залиште Ваш номер, i оператор передзвонить Вам");

        }

        public void MyExecuteNonQuery(string SqlText)
        {
            SqlConnection connnection; // экземпляр класса типа SqlConnection
            SqlCommand command;

            // выделение памяти с инициализацией строки соединения с базой данных
            connnection = new SqlConnection(ConnectionString);
            connnection.Open(); // открыть источник данных
            command = connnection.CreateCommand(); // задать SQL-команду
            command.CommandText = SqlText; // задать командную строку
            command.ExecuteNonQuery(); // выполнить SQL-команду
            connnection.Close(); // закрыть источник данных
        }

        public void ShowCards(string SqlText)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(SqlText, ConnectionString);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Card");
            CardsDataGrid.DataSource = dataSet.Tables["Card"].DefaultView;
            CardsDataGrid.Columns["Id"].Visible = false;
            CardsDataGrid.Columns["cardnumber"].HeaderText = "Номер картки";
            CardsDataGrid.Columns["cardnumber"].Width = 240;
            CardsDataGrid.Columns["balance"].Visible = false;
            CardsDataGrid.Columns["active"].Visible = false;
        }

        private void BlockCardButton_Click(object sender, EventArgs e)
        {
            if (CardsDataGrid.CurrentCell != null)
            {
                int index = CardsDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int cardStatus, newStatus;
                string requestStatus = "Ви дiйсно бажаєте ";
                int ID = (int)CardsDataGrid[0, index].Value;
                string SqlText = "SELECT active FROM card WHERE Id =" + Convert.ToString(ID);
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = SqlText;
                DbDataReader reader = command.ExecuteReader();
                reader.Read();
                cardStatus = Convert.ToInt32(reader["active"]);
                requestStatus += cardStatus == 1 ? "заблокувати " : "разблокувати ";
                requestStatus += "обрану картку?";
                RequestForm form = new RequestForm();
                form.RequestLabel.Text = requestStatus;
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    newStatus = cardStatus == 1 ? 0 : 1;
                    SqlText = "UPDATE card SET active = \'" + Convert.ToString(newStatus) + "\' WHERE Id =" + Convert.ToString(ID);
                    MyExecuteNonQuery(SqlText);
                    SqlText = "SELECT Id,cardnumber,balance,active FROM card WHERE ownerId =" + clientId;
                    ShowCards(SqlText);
                    CardsDataGrid.CurrentCell = CardsDataGrid.Rows[index].Cells.OfType<DataGridViewCell>().First(c => c.Visible);
                }
            }
            else MessageBox.Show("Не обрана картка!", "Оберiть картку", MessageBoxButtons.OK);
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (CardsDataGrid.CurrentCell != null)
            {
                int index = CardsDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int ID = (int)CardsDataGrid[0, index].Value;
                StatementForm stForm = new StatementForm();
                stForm.cardID = ID;
                stForm.CardNameLabel.Text = Convert.ToString(CardsDataGrid[1, index].Value);
                stForm.ClientNameLabel.Text = clientName;
                stForm.ShowDialog();
            }
            else MessageBox.Show("Не обрана картка для проведення операцiї!", "Оберiть картку", MessageBoxButtons.OK);
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            if (CardsDataGrid.CurrentCell != null)
            {
                int index = CardsDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int cardId = Convert.ToInt32(CardsDataGrid[0, index].Value);
                bool status = Convert.ToBoolean(CardsDataGrid[3, index].Value);
                string cardname = Convert.ToString(CardsDataGrid[1, index].Value);
                double balance = Convert.ToDouble(CardsDataGrid[2, index].Value);

                if (status == false)
                    MessageBox.Show("Картку заблоковано! Операцiї iз заблокованою карткою неможливi!", "Помилка операцiї", MessageBoxButtons.OK);
                else
                    if (balance <= 0)
                    MessageBox.Show("На картцi недостатньо коштiв !", "Помилка операцiї", MessageBoxButtons.OK);
                else
                {
                    PaymentForm payForm = new PaymentForm();
                    payForm.CardNameLabel.Text = cardname;
                    payForm.cardID = cardId;
                    payForm.cardAmount = balance;
                    payForm.ShowDialog();
                    string SqlText = "SELECT Id,cardnumber,balance,active FROM card WHERE ownerId =" + clientId;
                    ShowCards(SqlText);
                }
            }
            else MessageBox.Show("Не обрана картка!", "Оберiть картку", MessageBoxButtons.OK);
        }
    }
}

