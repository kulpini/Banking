using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class LoginForm : Form
    {
        public int clientID;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login;
            string password;
            if ((LoginTextBox.Text == "") || (PasswordTextBox.Text == ""))
                MessageBox.Show("Не задан логин или пароль !", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                login = LoginTextBox.Text;
                password = PasswordTextBox.Text;
                mainForm form = new mainForm();
                string SqlText = "SELECT Id FROM client WHERE login ='" + login + "' AND pass = '" + password + "'";

                SqlConnection connection = new SqlConnection(form.ConnectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                    command.CommandText = SqlText;
                DbDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                        clientID = (int)reader[0];
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Введено некоректний логiн або пароль. \n Повторiть спробу.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
