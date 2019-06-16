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
    public partial class FormPrihod : Form
    {
        public FormPrihod()
        {
            InitializeComponent();
           // Refresh_DB();
            Balance_PKO();
        }

        string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
        "Data Source=C:\\Users\\Marisha_ChV\\Desktop\\DIPLOM\\CashOption\\Cash.mdb";


        public void My_Execute_Non_Query(string CommandText)// выполнение SQL-запроса для команд INSERT, UPDATE, DELETE
        {

            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();
            OleDbCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = CommandText;
            myCommand.ExecuteNonQuery();
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashDataSet.ПриходныйКассовыйОрдер". При необходимости она может быть перемещена или удалена.
            this.приходныйКассовыйОрдерTableAdapter.Fill(this.cashDataSet.ПриходныйКассовыйОрдер);

        }

        private void button1_Click(object sender, EventArgs e)// фильтр по имени сотрудника (плательщик/получатель)
        {
            if (dataGridViewPK0.DataSource == приходныйКассовыйОрдерBindingSource)
            {
                приходныйКассовыйОрдерBindingSource.Filter = " [Принято от] LIKE'" + textBox1.Text + "%'";
            }
        }

        private void button2_Click(object sender, EventArgs e)// фильтр по основанию
        {
            if (dataGridViewPK0.DataSource == приходныйКассовыйОрдерBindingSource)
            {
                приходныйКассовыйОрдерBindingSource.Filter = " [Основание] LIKE'" + textBox1.Text + "%'";
            }
        }

        private void button3_Click(object sender, EventArgs e)//фильтр по приложению
        {
            if (dataGridViewPK0.DataSource == приходныйКассовыйОрдерBindingSource)
            {
                приходныйКассовыйОрдерBindingSource.Filter = " [Приложение] LIKE'" + textBox1.Text + "%'";
            }
        }

        private void button4_Click(object sender, EventArgs e)// фильтр по корреспондирующему счету
        {
            if (dataGridViewPK0.DataSource == приходныйКассовыйОрдерBindingSource)
            {
                приходныйКассовыйОрдерBindingSource.Filter = " [Корресп/счет] LIKE'" + textBox1.Text + "%'";
            }
        }

        private void button5_Click(object sender, EventArgs e)// по номеру документа
        {
            if (dataGridViewPK0.DataSource == приходныйКассовыйОрдерBindingSource)
            {
                приходныйКассовыйОрдерBindingSource.Filter = "Convert ([Номер документа],'System.String') LIKE '"+ textBox1.Text + "%'";
            }
        }

        private void button6_Click(object sender, EventArgs e)// по сумме документа
        {
            if (dataGridViewPK0.DataSource == приходныйКассовыйОрдерBindingSource)
            {
                приходныйКассовыйОрдерBindingSource.Filter = "Convert ([Сумма],'System.String') LIKE '" + textBox1.Text + "%'";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
             
        }

        private void приходныйКассовыйОрдерBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void Insert()// функция добавления КО
        {
            FormPrihodAdd FormPrihodAdd = new FormPrihodAdd();
            FormPrihodAdd.statusrun = "insert";
            FormPrihodAdd.Show();
            this.Hide();
        }
        private void buttonInsert_Click(object sender, EventArgs e)// добавить новый ПКО (команда)
        {
            Insert();
        }

        private void Copy_insert()//функция добавить копированием
        {
            int index;
            string ID;

            index = dataGridViewPK0.CurrentRow.Index; // № по порядку в таблице представления
            ID = Convert.ToString(dataGridViewPK0[0, index].Value); // ID подаем в запрос как строку


            FormPrihodAdd FormPrihodAdd = new FormPrihodAdd();
            FormPrihodAdd.num_doc = ID;
            FormPrihodAdd.statusrun = "copyinsert";
            FormPrihodAdd.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)//добавить копированием ПКО (команда)
        {
            Copy_insert();
        }

        private void Redactor()// функция редактирования
        {
            int index;
            string ID;

            index = dataGridViewPK0.CurrentRow.Index; // № по порядку в таблице представления
            ID = Convert.ToString(dataGridViewPK0[0, index].Value); // ID подаем в запрос как строку


            FormPrihodAdd FormPrihodAdd = new FormPrihodAdd();
            FormPrihodAdd.num_doc = ID;
            FormPrihodAdd.statusrun = "update";
            FormPrihodAdd.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)// редактировать ПКО (команда)
        {
            Redactor();
        }

        private void Delete()// функция удаления
        {
            FormDelete f = new FormDelete();

            if (f.ShowDialog() == DialogResult.OK)
            {
                int index;
                string ID;
                string CommandText = "DELETE FROM ";

                index = dataGridViewPK0.CurrentRow.Index; // № по порядку в таблице представления

                ID = Convert.ToString(dataGridViewPK0[0, index].Value); // ID подаем в запрос как строку

                // Формируем строку CommandText
                CommandText = "DELETE* FROM [ПриходныйКассовыйОрдер] WHERE [ПриходныйКассовыйОрдер].[Номер документа] = " + ID + ";";

                // выполняем SQL-запрос
                My_Execute_Non_Query(CommandText);

                Refresh_DB();
            }
            
        }

            private void buttonDelete_Click(object sender, EventArgs e)// удалить ПКО (команда)
        {
            Delete();
        }

        private void buttonBack_Click(object sender, EventArgs e)//вернуться в главное меню
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
        }
        public void Refresh_DB()// функция обновления базы данных
        {
            string CommandText = "SELECT * FROM [ПриходныйКассовыйОрдер]";
            My_Execute_Non_Query(CommandText);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "ПриходныйКассовыйОрдер");
            dataGridViewPK0.DataSource = ds.Tables[0].DefaultView;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)//кнопка обновления таблицы базы данных КО
        {
            Refresh_DB();
        }
        private void Balance_PKO()// функция расчета суммы
        {
            double sum = 0;

            for (int i = 0; i < dataGridViewPK0.RowCount - 1; i++)
            {
                if (dataGridViewPK0.Rows[i].Visible)
                    sum += Convert.ToDouble(dataGridViewPK0[4, i].Value);
            }
            textBoxSum.Text = sum.ToString();
        }

        private void buttonSearchDate_Click(object sender, EventArgs e)// фильтр по дате
        {
            for (int i = 0; i < dataGridViewPK0.Rows.Count - 1; i++)
            {
                if (Convert.ToDateTime(dataGridViewPK0.Rows[i].Cells[1].Value) >= dateTimePicker1.Value && Convert.ToDateTime(dataGridViewPK0.Rows[i].Cells[1].Value) <= dateTimePicker2.Value)
                {
                    dataGridViewPK0.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)// кнопка рассчета суммы прихода
        {
            double sum = 0;

            for (int i = 0; i < dataGridViewPK0.RowCount - 1; i++)
            {
                if (dataGridViewPK0.Rows[i].Visible)
                    sum += Convert.ToDouble(dataGridViewPK0[4, i].Value);
            }
            textBoxSum.Text = sum.ToString();
        }

        private void buttonAdd1_Click(object sender, EventArgs e)// кнопка добавить (панель инструментов) 
        {
            Insert();
        }

        private void button10_Click(object sender, EventArgs e)// кнопка добавить копированием  (панель инструментов) 
        {
            Copy_insert();
        }

        private void buttonDelete1_Click(object sender, EventArgs e)// кнопка удалить (панель инструментов)
        {
            Delete();
        }

        private void button11_Click(object sender, EventArgs e)// кнопка редактировать (панель инструментов)
        {
            Redactor();
        }

        private void dataGridViewPK0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)//функция двойного щелчка (редактирование)
        {
            Redactor();
        }

    }
}
