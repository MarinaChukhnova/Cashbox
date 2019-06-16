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
    public partial class FormLimit : Form
    {
        string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
        "Data Source=C:\\Users\\Marisha_ChV\\Desktop\\DIPLOM\\CashOption\\Cash.mdb";

        public FormLimit()
        {
            InitializeComponent();
            Refresh_tbl();
           
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
        private void Add_Limit(string year, string sum)
        {
            string CommandText;

            CommandText = "INSERT INTO [Лимит] ([Год], [Сумма]) VALUES ('" + year + "', '" + sum + "')";
            My_Execute_Non_Query(CommandText);

            Clear_Limit();

        }
        
        private void Refresh_tbl()
        {
            string CommandText = "SELECT * FROM Лимит";
            My_Execute_Non_Query(CommandText);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Лимит");
            лимитDataGridView.DataSource = ds.Tables[0].DefaultView;

        }

        private void Delete()
        {
            int index;
            string ID;
            string CommandText = "DELETE FROM ";

            index = лимитDataGridView.CurrentRow.Index; // № по порядку в таблице представления

            ID = Convert.ToString(лимитDataGridView[0, index].Value); // ID подаем в запрос как строку

            // Формируем строку CommandText
            CommandText = "DELETE* FROM [Лимит] WHERE [Лимит].[ID] = " + ID + ";";

            // выполняем SQL-запрос
            My_Execute_Non_Query(CommandText);

            Refresh_tbl();
        }

        private void Clear_Limit()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
        }
       

        private void лимитBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.лимитBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cashDataSet);

        }

        private void FormLimit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashDataSet.Лимит". При необходимости она может быть перемещена или удалена.
            this.лимитTableAdapter.Fill(this.cashDataSet.Лимит);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Limit(this.textBox1.Text, this.textBox2.Text);
            Clear_Limit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete();
        }

    }
}
