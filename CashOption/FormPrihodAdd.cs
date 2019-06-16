﻿using System;
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
    public partial class FormPrihodAdd : Form
    {

        public string statusrun;
        public string num_doc;
        public DataTable table_tmp;
        private String format = "d.MM.yyyy";

        private DataTable dtPKO = new DataTable();

        private readonly string TemplateFileName = @"C:\\Users\\Marisha_ChV\\Desktop\\Prihod.docx";
        
        string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
           "Data Source=C:\\Users\\Marisha_ChV\\Desktop\\DIPLOM\\CashOption\\Cash.mdb";
       
        public FormPrihodAdd()
        {
            InitializeComponent();
            SetValueToTextBoxes();
            Clear_Prihod();
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

        private void Add_Prihod(string num_doc, DateTime date_doc, string prinayt_ot,
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
            case  "insert":
                  CommandText = "INSERT INTO [ПриходныйКассовыйОрдер] ([Номер документа], [Дата], [Принято от],[Сумма], [Корресп/счет],  [Основание], [Приложение])"
                + " VALUES ('" + num_doc + "', '" + date_str  + "', '" + prinayt_ot + "', " + s_sum + ", '" + schet + "', '" + osnovanie + "', '" + prilojenie + "')";
              
                break;

            case  "update":
                CommandText = "UPDATE [ПриходныйКассовыйОрдер] set [Дата]='" + date_str + "', [Принято от]='" + prinayt_ot + "',[Сумма]='" + s_sum + "', [Корресп/счет]='" + schet + "',  [Основание]='" + osnovanie + "', [Приложение] ='" + prilojenie + "'"
                  +" WHERE [Номер документа]=" + num_doc ;

                break;

            case "copyinsert":
                     CommandText = "INSERT INTO [ПриходныйКассовыйОрдер] ([Номер документа], [Дата], [Принято от],[Сумма], [Корресп/счет],  [Основание], [Приложение])"
                + " VALUES ('" + num_doc + "', '" + date_str + "', '" + prinayt_ot + "', " + s_sum + ", '" + schet + "', '" + osnovanie + "', '" + prilojenie + "')";
           

                break;
          }

          My_Execute_Non_Query(CommandText);

        }

        private void Clear_Prihod()// очистить форму

        {
                this.textBoxNum.Text = "";
                this.comboBoxPrinyatOt.Text = "";
                this.comboBoxSchet.Text = "";
                this.textBoxSum.Text = "";
                this.comboBoxOsnovanie.Text = "";
                this.textBoxPrilojenie.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)// добавление новой формы
        {

                Add_Prihod(this.textBoxNum.Text, this.dateTimePicker1.Value, this.comboBoxPrinyatOt.Text,
                           Convert.ToDouble(this.textBoxSum.Text), this.comboBoxSchet.Text, 
                           this.comboBoxOsnovanie.Text, this.textBoxPrilojenie.Text);
                Clear_Prihod();  
            
           
        }

        private void buttonBack_Click(object sender, EventArgs e)//возврат к предыдущей форме
        {
            FormPrihod FormPrihod = new FormPrihod();
            FormPrihod.Show();
            this.Hide();
        }

        private void FormPrihodAdd_Load(object sender, EventArgs e) // редактирование формы
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashDataSet.ОснованиеПрихода". При необходимости она может быть перемещена или удалена.
            this.основаниеПриходаTableAdapter.Fill(this.cashDataSet.ОснованиеПрихода);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashDataSet.Счета". При необходимости она может быть перемещена или удалена.
            this.счетаTableAdapter.Fill(this.cashDataSet.Счета);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            //this.сотрудникиTableAdapter.Fill(this.cashDataSet.Сотрудники);


            // редактирование данных
            if (statusrun == "update")
            {

                string CommandText = "SELECT [Номер документа] FROM [ПриходныйКассовыйОрдер] WHERE [ПриходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                textBoxNum.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "update")
            {
             
                string CommandText = "SELECT [Принято от] FROM [ПриходныйКассовыйОрдер] WHERE [ПриходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                comboBoxPrinyatOt.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "update")
            {
                   
                string CommandText = "SELECT [Сумма] FROM [ПриходныйКассовыйОрдер] WHERE [ПриходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                textBoxSum.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "update")
            {

                string CommandText = "SELECT [Корресп/счет] FROM [ПриходныйКассовыйОрдер] WHERE [ПриходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                comboBoxSchet.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "update")
            {

                string CommandText = "SELECT [Основание] FROM [ПриходныйКассовыйОрдер] WHERE [ПриходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                comboBoxOsnovanie.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "update")
            {

                string CommandText = "SELECT [Приложение] FROM [ПриходныйКассовыйОрдер] WHERE [ПриходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                textBoxPrilojenie.Text = My_Execute_Non_Query_Select(CommandText);
            }
           
            
            //добавить копированием
            if (statusrun == "copyinsert")
            {

                string CommandText = "SELECT [Номер документа] FROM [ПриходныйКассовыйОрдер] WHERE [ПриходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                textBoxNum.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "copyinsert")
            {

                string CommandText = "SELECT [Принято от] FROM [ПриходныйКассовыйОрдер] WHERE [ПриходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                comboBoxPrinyatOt.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "copyinsert")
            {

                string CommandText = "SELECT [Сумма] FROM [ПриходныйКассовыйОрдер] WHERE [ПриходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                textBoxSum.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "copyinsert")
            {

                string CommandText = "SELECT [Корресп/счет] FROM [ПриходныйКассовыйОрдер] WHERE [ПриходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                comboBoxSchet.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "copyinsert")
            {

                string CommandText = "SELECT [Основание] FROM [ПриходныйКассовыйОрдер] WHERE [ПриходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                comboBoxOsnovanie.Text = My_Execute_Non_Query_Select(CommandText);
            }
            if (statusrun == "copyinsert")
            {

                string CommandText = "SELECT [Приложение] FROM [ПриходныйКассовыйОрдер] WHERE [ПриходныйКассовыйОрдер].[Номер документа] = " + num_doc + ";";
                textBoxPrilojenie.Text = My_Execute_Non_Query_Select(CommandText);
            }
        
        }

        private void buttonExport_Click(object sender, EventArgs e) // экспорт в Word
        {
            var num = textBoxNum.Text;
            var data = dateTimePicker1.Value.ToShortDateString();
            var prinyatOt = comboBoxPrinyatOt.Text;
            var schet = comboBoxSchet.Text;
            var sum = textBoxSum.Text;
            var osnovanie = comboBoxOsnovanie.Text;
            var prilojenie = textBoxPrilojenie.Text;
            var cassir = textBox1.Text;
            var glavbuh = textBox2.Text;

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{num}", num, wordDocument);
                ReplaceWordStub("{data}", data, wordDocument);
                ReplaceWordStub("{prinyatOt}", prinyatOt, wordDocument);
                ReplaceWordStub("{schet}", schet, wordDocument);
                ReplaceWordStub("{sum}", sum, wordDocument);
                ReplaceWordStub("{osnovanie}", osnovanie, wordDocument);
                ReplaceWordStub("{prilojenie}", prilojenie, wordDocument);
                ReplaceWordStub("{cassir}", cassir, wordDocument);
                ReplaceWordStub("{glavbuh}", glavbuh, wordDocument);
                ReplaceWordStub("{num/}", num, wordDocument);
                ReplaceWordStub("{data/}", data, wordDocument);
                ReplaceWordStub("{prinyatOt/}", prinyatOt, wordDocument);
                ReplaceWordStub("{osnovanie/}", osnovanie, wordDocument);
                ReplaceWordStub("{cassir/}", cassir, wordDocument);
                ReplaceWordStub("{glavbuh/}", glavbuh, wordDocument);


                wordDocument.SaveAs(@"C:\\Users\\Marisha_ChV\\Desktop\\PrihodNew.docx");
                wordApp.Visible = true;
            }

            catch
            {
                MessageBox.Show("Произошла ошибка");
            }

        }

        private void ReplaceWordStub (string stubToReplace, string text, Word.Document wordDocument)// замена текста
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void buttonOtmena_Click(object sender, EventArgs e)// очистить форму
        {
            Clear_Prihod();  
        }
        private void SetValueToTextBoxes() // установка значений по умолчанию
        {
            //default dimensions
            textBox1.Text = "Лобунцова В.И.";
            textBox2.Text = "Пархоменко Т.А.";

        }

        private void textBoxSum_KeyPress(object sender, KeyPressEventArgs e)// ограничения ввода только цифр
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44) e.Handled = true;
        }

        private void comboBoxPrinyatOt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.сотрудникиTableAdapter.FillBy(this.cashDataSet.Сотрудники);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonFormMain_Click(object sender, EventArgs e)//вернуться в главное меню
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)// Функция добавления ПКО
        {
            Add_Prihod(this.textBoxNum.Text, this.dateTimePicker1.Value, this.comboBoxPrinyatOt.Text,
                       Convert.ToDouble(this.textBoxSum.Text), this.comboBoxSchet.Text,
                       this.comboBoxOsnovanie.Text, this.textBoxPrilojenie.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var num = textBoxNum.Text;
            var data = dateTimePicker1.Value.ToShortDateString();
            var prinyatOt = comboBoxPrinyatOt.Text;
            var schet = comboBoxSchet.Text;
            var sum = textBoxSum.Text;
            var osnovanie = comboBoxOsnovanie.Text;
            var prilojenie = textBoxPrilojenie.Text;
            var cassir = textBox1.Text;
            var glavbuh = textBox2.Text;

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{num}", num, wordDocument);
                ReplaceWordStub("{data}", data, wordDocument);
                ReplaceWordStub("{prinyatOt}", prinyatOt, wordDocument);
                ReplaceWordStub("{schet}", schet, wordDocument);
                ReplaceWordStub("{sum}", sum, wordDocument);
                ReplaceWordStub("{osnovanie}", osnovanie, wordDocument);
                ReplaceWordStub("{prilojenie}", prilojenie, wordDocument);
                ReplaceWordStub("{cassir}", cassir, wordDocument);
                ReplaceWordStub("{glavbuh}", glavbuh, wordDocument);
                ReplaceWordStub("{num/}", num, wordDocument);
                ReplaceWordStub("{data/}", data, wordDocument);
                ReplaceWordStub("{prinyatOt/}", prinyatOt, wordDocument);
                ReplaceWordStub("{osnovanie/}", osnovanie, wordDocument);
                ReplaceWordStub("{cassir/}", cassir, wordDocument);
                ReplaceWordStub("{glavbuh/}", glavbuh, wordDocument);


                wordDocument.SaveAs(@"C:\\Users\\Marisha_ChV\\Desktop\\PrihodNew.docx");
                wordApp.Visible = true;
            }

            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)//очистить форму
        {
            Clear_Prihod();
        }

    }
}
