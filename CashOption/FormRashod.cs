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
    public partial class FormRashod : Form
    {
        public FormRashod()
        {
            InitializeComponent();
           
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

        private void расходныйКассовыйОрдерBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.расходныйКассовыйОрдерBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cashDataSet);

        }

        private void расходныйКассовыйОрдерBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.расходныйКассовыйОрдерBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cashDataSet);

        }

        private void FormRashod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashDataSet.РасходныйКассовыйОрдер". При необходимости она может быть перемещена или удалена.
            this.расходныйКассовыйОрдерTableAdapter.Fill(this.cashDataSet.РасходныйКассовыйОрдер);

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
          
        }

        private void Insert()// функция добавления
        {
            FormRashodAdd FormRashodAdd = new FormRashodAdd();
            FormRashodAdd.statusrun = "insert";
            FormRashodAdd.Show();
            this.Hide();
        }

        private void buttonInsert_Click_1(object sender, EventArgs e)// кнопка добавить (команда)
        {
            Insert();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)// фильтр по номеру документа
        {
            if (DataGridViewRKO.DataSource == расходныйКассовыйОрдерBindingSource)
            {
                расходныйКассовыйОрдерBindingSource.Filter = "Convert ([Номер документа],'System.String') LIKE '" + textBox1.Text + "%'";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)//фильтр по имени сотрудника
        {
            if (DataGridViewRKO.DataSource == расходныйКассовыйОрдерBindingSource)
            {
                расходныйКассовыйОрдерBindingSource.Filter = " [Получатель] LIKE'" + textBox1.Text + "%'";
            }
        }

        private void button4_Click(object sender, EventArgs e)// фильтр по счету
        {
            if (DataGridViewRKO.DataSource == расходныйКассовыйОрдерBindingSource)
            {
                расходныйКассовыйОрдерBindingSource.Filter = " [Корресп/счет] LIKE'" + textBox1.Text + "%'";
            }
        }

        private void button6_Click(object sender, EventArgs e)// фильтр по сумме документа
        {
            if (DataGridViewRKO.DataSource == расходныйКассовыйОрдерBindingSource)
            {
               расходныйКассовыйОрдерBindingSource.Filter = "Convert ([Сумма],'System.String') LIKE '" + textBox1.Text + "%'";
            }
        }

        private void button2_Click(object sender, EventArgs e)// фильтр по основанию документа
        {
            if (DataGridViewRKO.DataSource == расходныйКассовыйОрдерBindingSource)
            {
                расходныйКассовыйОрдерBindingSource.Filter = " [Основание] LIKE'" + textBox1.Text + "%'";
            }
        }

        private void button7_Click(object sender, EventArgs e)// фильтр по приложению
        {
            if (DataGridViewRKO.DataSource == расходныйКассовыйОрдерBindingSource)
            {
                расходныйКассовыйОрдерBindingSource.Filter = " [Приложение] LIKE'" + textBox1.Text + "%'";
            }
        }

        private void buttonSearchDate_Click(object sender, EventArgs e)// поиск по диапазону дат
        {
            for (int i = 0; i < DataGridViewRKO.Rows.Count - 1; i++)
            {
                if (Convert.ToDateTime(DataGridViewRKO.Rows[i].Cells[1].Value) >= dateTimePicker1.Value && Convert.ToDateTime(DataGridViewRKO.Rows[i].Cells[1].Value) <= dateTimePicker2.Value)
                {
                    DataGridViewRKO.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }


        private void Copy_insert()// функция добавить копированием
        {
            int index;
            string ID;

            index = DataGridViewRKO.CurrentRow.Index; // № по порядку в таблице представления
            ID = Convert.ToString(DataGridViewRKO[0, index].Value); // ID подаем в запрос как строку


            FormRashodAdd FormRashodAdd = new FormRashodAdd();
            FormRashodAdd.num_doc = ID;
            FormRashodAdd.statusrun = "copyinsert";
            FormRashodAdd.Show();
            this.Hide();
        }
        private void button9_Click(object sender, EventArgs e)// кнопка добавить копированием (команда)
        {
            Copy_insert();
        }

        private void Redactor()// функция редактирования
        {
            int index;
            string ID;

            index = DataGridViewRKO.CurrentRow.Index; // № по порядку в таблице представления
            ID = Convert.ToString(DataGridViewRKO[0, index].Value); // ID подаем в запрос как строку


            FormRashodAdd FormRashodAdd = new FormRashodAdd();
            FormRashodAdd.num_doc = ID;
            FormRashodAdd.statusrun = "update";
            FormRashodAdd.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
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

                 index = DataGridViewRKO.CurrentRow.Index; // № по порядку в таблице представления

                 ID = Convert.ToString(DataGridViewRKO[0, index].Value); // ID подаем в запрос как строку

                 // Формируем строку CommandText
                 CommandText = "DELETE* FROM [РасходныйКассовыйОрдер] WHERE [РасходныйКассовыйОрдер].[Номер документа] = " + ID + ";";

                 // выполняем SQL-запрос
                 My_Execute_Non_Query(CommandText);

                 Refresh_DB();
             }
           
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void buttonSum_Click(object sender, EventArgs e)// функция расчета суммы
        {
            
                double sum = 0;

                for (int i = 0; i < DataGridViewRKO.RowCount - 1; i++)
                {
                    if (DataGridViewRKO.Rows[i].Visible)
                        sum += Convert.ToDouble(DataGridViewRKO[4, i].Value);
                }
                textBoxSum.Text = sum.ToString();
            
        }
        public void Refresh_DB()// функция обновления базы данных
        {
            string CommandText = "SELECT * FROM [РасходныйКассовыйОрдер]";
            My_Execute_Non_Query(CommandText);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "РасходныйКассовыйОрдер");
            DataGridViewRKO.DataSource = ds.Tables[0].DefaultView;
        }

        private void buttonBack_Click(object sender, EventArgs e)//вернуться в главное меню
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)// кнопка обновления таблицы базы данных (панель инструментов)
        {
            Refresh_DB();
        }

        private void buttonAdd1_Click(object sender, EventArgs e)// кнопка добавить (панель инструментов)
        {
            Insert();
        }

        private void button10_Click(object sender, EventArgs e)// кнопка добавить копированием (панель инструментов)
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

        private void DataGridViewRKO_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)//функция двойного щелчка (редактирование)
        {
            Redactor();
        }

    }
}
