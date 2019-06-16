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
    public partial class FormSotrudniki : Form
    {


        string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
        "Data Source=C:\\Users\\Marisha_ChV\\Desktop\\DIPLOM\\CashOption\\Cash.mdb";
        public FormSotrudniki()
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
        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cashDataSet);

        }

        private void FormSotrudniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.cashDataSet.Сотрудники);

        }

        private void Add_Sotrudniki(string imya, string passport)
        {
            string CommandText;

            CommandText = "INSERT INTO [Сотрудники] ([ФИО (табельный номер)], [Паспортные данные])"
                    + " VALUES ('" + imya + "', '" + passport + "')";
            My_Execute_Non_Query(CommandText);

            Clear_Sotrudniki();

        }
        private void Clear_Sotrudniki ()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
          
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)// вернуться в предыдущее меню
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add_Sotrudniki(this.textBox1.Text, this.textBox2.Text);
            Clear_Sotrudniki();
            Refresh_tbl();
        }

        private void Refresh_tbl()
        {
            string CommandText = "SELECT * FROM [Сотрудники]";
            My_Execute_Non_Query(CommandText);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Сотрудники");
            сотрудникиDataGridView.DataSource = ds.Tables[0].DefaultView;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index;
            string ID;
            string CommandText = "DELETE FROM ";

            index = сотрудникиDataGridView.CurrentRow.Index; // № по порядку в таблице представления

            ID = Convert.ToString(сотрудникиDataGridView[0, index].Value); // ID подаем в запрос как строку

            // Формируем строку CommandText
            CommandText = "DELETE* FROM [Сотрудники] WHERE [Сотрудники].[ID] = " + ID + ";";

            // выполняем SQL-запрос
            My_Execute_Non_Query(CommandText);

            Refresh_tbl();
        }

    }
}
