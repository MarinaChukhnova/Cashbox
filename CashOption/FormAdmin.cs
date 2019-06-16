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
    public partial class FormAdmin : Form
    {

        string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
        "Data Source=C:\\Users\\Marisha_ChV\\Desktop\\DIPLOM\\CashOption\\Cash.mdb";
        public FormAdmin()
        {
            InitializeComponent();
        }
        public void My_Execute_Non_Query(string CommandText)// выполнение SQL-запроса для команд INSERT, UPDATE, DELETE
        {
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();
            OleDbCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = CommandText;
            myCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cashDataSet);

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashDataSet.Login". При необходимости она может быть перемещена или удалена.
            this.loginTableAdapter.Fill(this.cashDataSet.Login);
        }
        
          private void Add_Login(string username, string password, string class_use)
        {
            string CommandText;

            CommandText = "INSERT INTO [Login] ([Username], [Password], [Class])"
                    + " VALUES ('" + username + "', '" + password + "', '" + class_use + "')";
            My_Execute_Non_Query(CommandText);

            Clear_Login();
            
        }

       
        private void Clear_Login()
        {
            this.textBoxUsername.Text = "";
            this.textBoxPassword.Text = "";
            this.textBoxClass.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add_Login(this.textBoxUsername.Text, this.textBoxPassword.Text, this.textBoxClass.Text);
            Clear_Login();
            Refresh_tbl();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string CommandText = "SELECT * FROM Login";
            My_Execute_Non_Query(CommandText);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Login");
            loginDataGridView.DataSource = ds.Tables[0].DefaultView;
        }


        private void Refresh_tbl()
        {
            string CommandText = "SELECT * FROM Login";
            My_Execute_Non_Query(CommandText);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Login");
            loginDataGridView.DataSource = ds.Tables[0].DefaultView;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index;
            string ID;
            string CommandText = "DELETE FROM ";

            index = loginDataGridView.CurrentRow.Index; // № по порядку в таблице представления

            ID = Convert.ToString(loginDataGridView[0, index].Value); // ID подаем в запрос как строку

            // Формируем строку CommandText
            CommandText = "DELETE* FROM [Login] WHERE [Login].[ID] = " + ID + ";";

            // выполняем SQL-запрос
            My_Execute_Non_Query(CommandText);

            Refresh_tbl();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

            FormLogin FormLogin = new FormLogin();
            FormLogin.Show();
            this.Hide();
        }


    }
}
