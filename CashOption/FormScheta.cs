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
    public partial class FormScheta : Form
    {

        string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
        "Data Source=C:\\Users\\Marisha_ChV\\Desktop\\DIPLOM\\CashOption\\Cash.mdb";
        public FormScheta()
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
        private void Add_Schet (string schet, string imya)
        {
            string CommandText;

            CommandText = "INSERT INTO [Счета] ([Корресп/ счет], [Наименование])"
                    + " VALUES ('" + schet + "', '" + imya + "')";
            My_Execute_Non_Query(CommandText);

            Clear_Schet();

        }
        private void Clear_Schet()
        {
            this.textBoxImya.Text = "";
            this.textBoxSchet.Text = "";
        }

        private void счетаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.счетаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cashDataSet);

        }

        private void FormScheta_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashDataSet.Счета". При необходимости она может быть перемещена или удалена.
            this.счетаTableAdapter.Fill(this.cashDataSet.Счета);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add_Schet(this.textBoxImya.Text, this.textBoxSchet.Text);
            Clear_Schet();
            Refresh_tbl();
        }

        private void Refresh_tbl()
        {
            string CommandText = "SELECT * FROM Счета";
            My_Execute_Non_Query(CommandText);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Счета");
            счетаDataGridView.DataSource = ds.Tables[0].DefaultView;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int index;
            string ID;
            string CommandText = "DELETE FROM ";

            index = счетаDataGridView.CurrentRow.Index; // № по порядку в таблице представления

            ID = Convert.ToString(счетаDataGridView[0, index].Value); // ID подаем в запрос как строку

            // Формируем строку CommandText
            CommandText = "DELETE* FROM [Счета] WHERE [Счета].[ID] = " + ID + ";";

            // выполняем SQL-запрос
            My_Execute_Non_Query(CommandText);

            Refresh_tbl();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
        }

    }
}
