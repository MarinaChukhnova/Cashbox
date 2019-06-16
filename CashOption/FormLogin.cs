using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CashOption
{
   
    public partial class FormLogin : Form

    {
        public DataTable table_tmp;
    
        private OleDbConnection connection = new OleDbConnection();

        string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
              "Data Source=C:\\Users\\Marisha_ChV\\Desktop\\DIPLOM\\CashOption\\Cash.mdb";
        public FormLogin()
        {
            InitializeComponent();
        }

        public string My_Execute_Non_Query_Select(string CommandText)// выполнение SQL-запроса для (РЕДАКТИРОВАНИЯ ФОРМЫ) команд INSERT, UPDATE, DELETE
        {

            table_tmp = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            dataAdapter.Fill(table_tmp);
            if (table_tmp.Rows.Count == 0)
            {
                return "false";
            }
            else
            {
                return table_tmp.Rows[0][0].ToString();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashDataSet.Login". При необходимости она может быть перемещена или удалена.
            this.loginTableAdapter.Fill(this.cashDataSet.Login);
   
        }

       

        private void buttonLogin_Click(object sender, EventArgs e)// кнопка войти
        {
            string CommandText = "SELECT Class FROM Login WHERE Username = '" + txt_Username.Text +
                     "'AND Password= '" + txt_Password.Text + "'";
            string Status = My_Execute_Non_Query_Select(CommandText);
            // проверка на пустоту полей Имя пользователя, Пароль
            if (txt_Username.Text == "")
            {
                MessageBox.Show("Введите имя пользователя!");
            }
            if (txt_Password.Text == "")
            {
                MessageBox.Show("Введите пароль!");
            }
            // определение статуса пользователя (user или admin),
            //доступ к формам в зависимости от статуса пользователя
            switch (Status)
            {
                case "admin":
                    {
                        FormAdmin FormAdmin = new FormAdmin();
                        FormAdmin.Show();
                        this.Hide();
                    }
                    break;
                case "user":
                    {
                        FormMain FormMain = new FormMain();
                        FormMain.Show();
                        this.Hide();
                    }
                    break;
                case "false":
                    {
                        MessageBox.Show("Имя пользователя или пароль введены не верно!");
                    }
                    break;
            }
           
        }

        private void txt_Username_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLog_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
