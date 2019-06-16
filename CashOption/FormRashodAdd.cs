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
using Word = Microsoft.Office.Interop.Word;


namespace CashOption
{
    public partial class FormRashodAdd : Form
    {

        public string statusrun;
        public string num_doc;
        public DataTable table_tmp;
        private String format = "d.MM.yyyy";

        private DataTable dtRKO = new DataTable();

        private readonly string TemplateFileName = @"C:\\Users\\Marisha_ChV\\Desktop\\Rashod.docx";
        
        string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
           "Data Source=C:\\Users\\Marisha_ChV\\Desktop\\DIPLOM\\CashOption\\Cash.mdb";
       

        public FormRashodAdd()
        {
            InitializeComponent();
            SetValueToTextBoxes();
            Clear_Rashod();
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

        // выполнение SQL-запроса для (РЕДАКТИРОВАНИЯ ФОРМЫ) команд INSERT, UPDATE, DELETE
        public string My_Execute_Non_Query_Select(string CommandText)
        {

            table_tmp = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            dataAdapter.Fill(table_tmp);
            return table_tmp.Rows[0][0].ToString();
        }

        private void Add_Rashod(string num_doc, DateTime date_doc, string poluchatel,
             double sum, string schet, string osnovanie, string prilojenie) // функция добавления ПКО
        {
            string CommandText;
            string s_sum;
            string date_str = date_doc.ToString(format);

            s_sum = Convert.ToString(sum); // переводим сумму из double в строку
            s_sum = s_sum.Replace(',', '.'); // меняем запятую на точку согласно синтаксису SQL
            CommandText = "";

            switch (statusrun)
            {
                case "insert":
                    CommandText = "INSERT INTO [РасходныйКассовыйОрдер] ([Номер документа], [Дата], [Получатель],[Сумма], [Корресп/счет],  [Основание], [Приложение])"
                  + " VALUES ('" + num_doc + "', '" + date_str + "', '" + poluchatel + "', " + s_sum + ", '" + schet + "', '" + osnovanie + "', '" + prilojenie + "')";
                    
                    break;

                case "update":
                    CommandText = "UPDATE [РасходныйКассовыйОрдер] set [Дата]='" + date_str + "', [Получатель]='" + poluchatel + "',[Сумма]='" + s_sum + "', [Корресп/счет]='" + schet + "',  [Основание]='" + osnovanie + "', [Приложение] ='" + prilojenie + "'"
                      + " WHERE [Номер документа]=" + num_doc;
                   
                    break;

                case "copyinsert":
                    CommandText = "INSERT INTO [РасходныйКассовыйОрдер] ([Номер документа], [Дата], [Получатель],[Сумма], [Корресп/счет],  [Основание], [Приложение])"
               + " VALUES ('" + num_doc + "', '" + date_str + "', '" + poluchatel + "', " + s_sum + ", '" + schet + "', '" + osnovanie + "', '" + prilojenie + "')";

                
                    break;
            }

             My_Execute_Non_Query(CommandText);

        }

      
        


        private void FormRashodAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashDataSet.Счета". При необходимости она может быть перемещена или удалена.
            this.счетаTableAdapter.Fill(this.cashDataSet.Счета);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashDataSet.ОснованиеРасхода". При необходимости она может быть перемещена или удалена.
            this.основаниеРасходаTableAdapter.Fill(this.cashDataSet.ОснованиеРасхода);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
           // this.сотрудникиTableAdapter.Fill(this.cashDataSet.Сотрудники);
           
            // редактирование данных
            if (statusrun == "update")
            {

                string CommandText = "SELECT [Номер документа] FROM [РасходныйКассовыйОрдер] WHERE [РасходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                textBoxNum.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "update")
            {

                string CommandText = "SELECT [Получатель] FROM [РасходныйКассовыйОрдер] WHERE [РасходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                comboBoxPoluchatel.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "update")
            {

                string CommandText = "SELECT [Сумма] FROM [РасходныйКассовыйОрдер] WHERE [РасходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                textBoxSum.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "update")
            {

                string CommandText = "SELECT [Корресп/счет] FROM [РасходныйКассовыйОрдер] WHERE [РасходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                comboBoxSchet.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "update")
            {

                string CommandText = "SELECT [Основание] FROM [РасходныйКассовыйОрдер] WHERE [РасходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                comboBoxOsnovanie.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "update")
            {

                string CommandText = "SELECT [Приложение] FROM [РасходныйКассовыйОрдер] WHERE [РасходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                textBoxPrilojenie.Text = My_Execute_Non_Query_Select(CommandText);
            }


            //добавить копированием
            if (statusrun == "copyinsert")
            {

                string CommandText = "SELECT [Номер документа] FROM [РасходныйКассовыйОрдер] WHERE [РасходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                textBoxNum.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "copyinsert")
            {

                string CommandText = "SELECT [Получатель] FROM [РасходныйКассовыйОрдер] WHERE [РасходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                comboBoxPoluchatel.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "copyinsert")
            {

                string CommandText = "SELECT [Сумма] FROM [РасходныйКассовыйОрдер] WHERE [РасходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                textBoxSum.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "copyinsert")
            {

                string CommandText = "SELECT [Корресп/счет] FROM [РасходныйКассовыйОрдер] WHERE [РасходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                comboBoxSchet.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "copyinsert")
            {

                string CommandText = "SELECT [Основание] FROM [РасходныйКассовыйОрдер] WHERE [РасходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                comboBoxOsnovanie.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "copyinsert")
            {

                string CommandText = "SELECT [Приложение] FROM [РасходныйКассовыйОрдер] WHERE [РасходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                textBoxPrilojenie.Text = My_Execute_Non_Query_Select(CommandText);
            }


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormRashod FormRashod = new FormRashod();
            FormRashod.Show();
            this.Hide();
        }

        private void Clear_Rashod()// очистить форму
        {
            this.textBoxNum.Text = "";
            this.comboBoxPoluchatel.Text = "";
            this.comboBoxSchet.Text = "";
            this.textBoxSum.Text = "";
            this.comboBoxOsnovanie.Text = "";
            this.textBoxPrilojenie.Text = "";

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear_Rashod(); 
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);


        }
        private void Export_word ()// функция экспорта в Word 
        {
            var num = textBoxNum.Text;
            var data = dateTimePicker1.Value.ToShortDateString();
            var poluchatel = comboBoxPoluchatel.Text;
            var schet = comboBoxSchet.Text;
            var sum = textBoxSum.Text;
            var osnovanie = comboBoxOsnovanie.Text;
            var prilojenie = textBoxPrilojenie.Text;
            var director = textBox1.Text;
            var glavbuh = textBox2.Text;
            var cassir = textBox3.Text;


            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{num}", num, wordDocument);
                ReplaceWordStub("{data}", data, wordDocument);
                ReplaceWordStub("{data/}", data, wordDocument);
                ReplaceWordStub("{poluchatel}", poluchatel, wordDocument);
                ReplaceWordStub("{schet}", schet, wordDocument);
                ReplaceWordStub("{sum}", sum, wordDocument);
                ReplaceWordStub("{osnovanie}", osnovanie, wordDocument);
                ReplaceWordStub("{prilojenie}", prilojenie, wordDocument);
                ReplaceWordStub("{director}", director, wordDocument);
                ReplaceWordStub("{glavbuh}", glavbuh, wordDocument);
                ReplaceWordStub("{cassir}", cassir, wordDocument);


                wordDocument.SaveAs(@"C:\\Users\\Marisha_ChV\\Desktop\\RashodNew.docx");
                wordApp.Visible = true;
            }

            catch
            {
                MessageBox.Show("Произошла ошибка!");
            }
        }

        private void buttonExport_Click_1(object sender, EventArgs e)// экспорт в Word (команда)
        {
            Export_word();
        }

        private void SetValueToTextBoxes() //установка значений по умолчанию
        {
            //default dimensions
            textBox1.Text = "Кузьменко С.Н.";
            textBox2.Text = "Лобунцова В.И.";
            textBox3.Text = "Пархоменко Т.А.";
        }

        private void textBoxSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44) e.Handled = true;
        }

     
        private void buttonAdd_Click(object sender, EventArgs e)// сохранить (команда)
        {
            Add_Rashod(this.textBoxNum.Text, this.dateTimePicker1.Value, this.comboBoxPoluchatel.Text,
                             Convert.ToDouble(this.textBoxSum.Text), this.comboBoxSchet.Text,
                             this.comboBoxOsnovanie.Text, this.textBoxPrilojenie.Text);
            Clear_Rashod(); 
        }

        private void button1_Click(object sender, EventArgs e)// вернуться в предыдущее меню
        {
            FormRashod FormRashod = new FormRashod();
            FormRashod.Show();
            this.Hide();
        }

        private void buttonFormMain_Click(object sender, EventArgs e)//вернуться в главное меню
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)// сохранить (панель инструментов)
        {
            Add_Rashod(this.textBoxNum.Text, this.dateTimePicker1.Value, this.comboBoxPoluchatel.Text,
                             Convert.ToDouble(this.textBoxSum.Text), this.comboBoxSchet.Text,
                             this.comboBoxOsnovanie.Text, this.textBoxPrilojenie.Text);
            Clear_Rashod(); 
        }

        private void button3_Click(object sender, EventArgs e)// экспорт в Word  (панель инструментов)
        {
            Export_word();
        }

        private void button2_Click(object sender, EventArgs e)// очистить форму (панель инструментов)
        {
            Clear_Rashod(); 
        }

    }
}
  