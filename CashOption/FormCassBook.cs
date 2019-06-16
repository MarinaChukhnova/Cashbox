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
    public partial class FormCassBook : Form
    {
        string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
         "Data Source=C:\\Users\\Marisha_ChV\\Desktop\\DIPLOM\\CashOption\\Cash.mdb";

        private readonly string TemplateFileName = @"C:\\Users\\Marisha_ChV\\Desktop\\CassBook.docx";
      

        public FormCassBook()
        {
            InitializeComponent();
            SetValueToTextBoxes();
        }

        // выполнение SQL-запроса для команд INSERT, UPDATE, DELETE
        public void My_Execute_Non_Query(string CommandText)
        {
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();
            OleDbCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = CommandText;
            myCommand.ExecuteNonQuery();
            conn.Close();
        }
        private void SetValueToTextBoxes() // установка значений по умолчанию
        {
            //default dimensions
            textBox1.Text = "Лобунцова В.И.";
            textBox2.Text = "Пархоменко Т.А.";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void Add_PrihodRashod()// функция добавления
        {
            string CommandText;
            String format = "#MM/dd/yyyy#";
            DateTime date_doc = dateTimePicker1.Value;
            string date_str = date_doc.ToString(format);
            date_str = date_str.Replace('.', '/');// меняем точку на слеш "/" согласно синтаксису SQL

            CommandText = "SELECT * FROM (SELECT * FROM  [ПриходныйКассовыйОрдер] UNION SELECT * FROM "
                         +" [РасходныйКассовыйОрдер]) WHERE [Дата] = " + date_str + "";
            DataSet dataset = new DataSet();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            dataAdapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            dataAdapter.Update(dataset);
        }

        private void Add_Ostatok_na_nachalo() // функция добавления остатка на начало дня 
        {
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();
            string CommandText;

            String format = "#MM/dd/yyyy#";
            DateTime date_doc = dateTimePicker1.Value;
            string date_str = date_doc.ToString(format);
            date_str = date_str.Replace('.', '/');// меняем точку на слеш "/" согласно синтаксису SQL

            CommandText = "SELECT Sum(Разница) AS Выражение1 FROM"

                            + " (select ИтоговаяДата, СуммаПрихода, СуммаРасхода, Разница from"
                            + " (select *,  switch((СуммаПрихода is null) and(СуммаРасхода is null),0, (СуммаПрихода is null)"
                            + " and(СуммаРасхода is not null), -СуммаРасхода, (СуммаПрихода is not null) and(СуммаРасхода is null),"
                            + " СуммаПрихода, true, СуммаПрихода-СуммаРасхода) as Разница, iif(xz.Дата is null,yz.Дата,xz.Дата)"
                            + " as ИтоговаяДата from (select * from (select x.[Дата], sum(x.[Сумма]) as СуммаПрихода from"
                            + " ПриходныйКассовыйОрдер as x group by x.[Дата] order by x.[Дата]) as xz"

                            + " left outer join"
                            + " (select y.[Дата], sum(y.[Сумма]) as СуммаРасхода from"
                            + " РасходныйКассовыйОрдер as y group by y.[Дата] order by y.[Дата]) as yz on (xz.[Дата]=yz.[Дата])"

                            + " union"

                            + " select * from"

                            + " (select x.[Дата], sum(x.[Сумма]) as СуммаПрихода  from"
                            + " ПриходныйКассовыйОрдер as x group by x.[Дата] order by x.[Дата]) as xz"
                            + " right outer join"
                            + " (select y.[Дата], sum(y.[Сумма]) as СуммаРасхода"
                            + "  from РасходныйКассовыйОрдер as y group by y.[Дата] order by y.[Дата]) as yz on (xz.[Дата]=yz.[Дата])"
                            + " )"
                            + " )"
                            + " order by ИтоговаяДата)"
                            + " AS [%$##@_Alias] WHERE ((([%$##@_Alias].[ИтоговаяДата])<" + date_str + "))";
           

           OleDbCommand comm = conn.CreateCommand();
           comm.CommandText = CommandText;
           OleDbDataReader reader = comm.ExecuteReader();
         
            if (reader.Read())
            {
                textBoxOstatok_N.Text = reader[0].ToString();
            }
            conn.Close();

        }

        private void Add_Ostatok_na_konets()// функция добавления остатка на конец дня
        {
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();
            string CommandText;

            String format = "#MM/dd/yyyy#";

            DateTime date_doc = dateTimePicker1.Value;
            
            DateTime date_doc1 = date_doc.AddDays(+1); // плюс один день
            
            string date_str= date_doc1.ToString(format);
            date_str = date_str.Replace('.', '/');// меняем точку на слеш "/" согласно синтаксису SQL



            CommandText = "SELECT Sum(Разница) AS Выражение1 FROM"

                            +" (select ИтоговаяДата, СуммаПрихода, СуммаРасхода, Разница from"
                            +" (select *,  switch((СуммаПрихода is null) and(СуммаРасхода is null),0, (СуммаПрихода is null)"
                            +" and(СуммаРасхода is not null), -СуммаРасхода, (СуммаПрихода is not null) and(СуммаРасхода is null),"
                            +" СуммаПрихода, true, СуммаПрихода-СуммаРасхода) as Разница, iif(xz.Дата is null,yz.Дата,xz.Дата)"
                            +" as ИтоговаяДата from (select * from (select x.[Дата], sum(x.[Сумма]) as СуммаПрихода from"
                            +" ПриходныйКассовыйОрдер as x group by x.[Дата] order by x.[Дата]) as xz"

                            +" left outer join"
                            +" (select y.[Дата], sum(y.[Сумма]) as СуммаРасхода from"
                            +" РасходныйКассовыйОрдер as y group by y.[Дата] order by y.[Дата]) as yz on (xz.[Дата]=yz.[Дата])"

                            +" union"

                            +" select * from"

                            +" (select x.[Дата], sum(x.[Сумма]) as СуммаПрихода  from"
                            +" ПриходныйКассовыйОрдер as x group by x.[Дата] order by x.[Дата]) as xz"
                            +" right outer join"
                            +" (select y.[Дата], sum(y.[Сумма]) as СуммаРасхода"
                            +"  from РасходныйКассовыйОрдер as y group by y.[Дата] order by y.[Дата]) as yz on (xz.[Дата]=yz.[Дата])"
                            +" )"
                            +" )"
                            +" order by ИтоговаяДата)"
                            +" AS [%$##@_Alias] WHERE ((([%$##@_Alias].[ИтоговаяДата])<" + date_str + "))";
           
                
             

            

            OleDbCommand comm = conn.CreateCommand();
            comm.CommandText = CommandText;
             OleDbDataReader reader = comm.ExecuteReader();

            if (reader.Read())
            {
                textBoxОstatok_K.Text = reader[0].ToString();
            }
            conn.Close();

        }

        private void Sum_PKO ()// сумма приходных ордеров
        {
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();
            string CommandText;

            String format = "#MM/dd/yyyy#";
            DateTime date_doc = dateTimePicker1.Value;
            string date_str = date_doc.ToString(format);
            date_str = date_str.Replace('.', '/');// меняем точку на слеш "/" согласно синтаксису SQL

            CommandText = "SELECT СуммаПрихода FROM"

                            + "(SELECT switch((СуммаПрихода Is Null) And (СуммаРасхода Is Null),0,(СуммаПрихода Is Null)"
                            + "And (СуммаРасхода Is Not Null),-СуммаРасхода,(СуммаПрихода Is Not Null) And (СуммаРасхода Is Null),"
                            + "СуммаПрихода,True,СуммаПрихода-СуммаРасхода) AS Разница, iif(xz.Дата is null,yz.Дата,xz.Дата) AS ИтоговаяДата,"
                            + " * FROM"
                            + " (select * from (select x.[Дата], sum(x.[Сумма]) as СуммаПрихода"
                            + " from ПриходныйКассовыйОрдер as x group by x.[Дата] order by x.[Дата]) as xz left outer join"
                            + " (select y.[Дата], sum(y.[Сумма]) as СуммаРасхода"
                            + " from РасходныйКассовыйОрдер as y group by y.[Дата] order by y.[Дата]) as yz on (xz.[Дата]=yz.[Дата])"
                            + " union"
                            + " select * from"
                            + " (select x.[Дата], sum(x.[Сумма]) as СуммаПрихода"
                            + " from ПриходныйКассовыйОрдер as x group by x.[Дата] order by x.[Дата])"
                            + " as xz right outer join (select y.[Дата], sum(y.[Сумма]) as СуммаРасхода"
                            + " from РасходныйКассовыйОрдер as y group by y.[Дата] order by y.[Дата]) as yz on (xz.[Дата]=yz.[Дата])"
                            + " )"
                            + "  AS [%$##@_Alias])"
                            + "  AS [%$##@_Alias]"
                            + " WHERE ИтоговаяДата=" + date_str + ""
                            + " ORDER BY ИтоговаяДата";

            OleDbCommand comm = conn.CreateCommand();
            comm.CommandText = CommandText;
            OleDbDataReader reader = comm.ExecuteReader();

            if (reader.Read())
            {
                textBoxPrihodSum.Text = reader[0].ToString();
            }
            conn.Close();

        }
        private void Sum_RKO()// сумма расходных ордеров
        {
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();
            string CommandText;

            String format = "#MM/dd/yyyy#";
            DateTime date_doc = dateTimePicker1.Value;
            string date_str = date_doc.ToString(format);
            date_str = date_str.Replace('.', '/');// меняем точку на слеш "/" согласно синтаксису SQL

            CommandText = "SELECT СуммаРасхода FROM"

                            + "(SELECT switch((СуммаПрихода Is Null) And (СуммаРасхода Is Null),0,(СуммаПрихода Is Null)"
                            + "And (СуммаРасхода Is Not Null),-СуммаРасхода,(СуммаПрихода Is Not Null) And (СуммаРасхода Is Null),"
                            + "СуммаПрихода,True,СуммаПрихода-СуммаРасхода) AS Разница, iif(xz.Дата is null,yz.Дата,xz.Дата) AS ИтоговаяДата,"
                            + " * FROM"
                            + " (select * from (select x.[Дата], sum(x.[Сумма]) as СуммаПрихода"
                            + " from ПриходныйКассовыйОрдер as x group by x.[Дата] order by x.[Дата]) as xz left outer join"
                            + " (select y.[Дата], sum(y.[Сумма]) as СуммаРасхода"
                            + " from РасходныйКассовыйОрдер as y group by y.[Дата] order by y.[Дата]) as yz on (xz.[Дата]=yz.[Дата])"
                            + " union"
                            + " select * from"
                            + " (select x.[Дата], sum(x.[Сумма]) as СуммаПрихода"
                            + " from ПриходныйКассовыйОрдер as x group by x.[Дата] order by x.[Дата])"
                            + " as xz right outer join (select y.[Дата], sum(y.[Сумма]) as СуммаРасхода"
                            + " from РасходныйКассовыйОрдер as y group by y.[Дата] order by y.[Дата]) as yz on (xz.[Дата]=yz.[Дата])"
                            + " )"
                            + "  AS [%$##@_Alias])"
                            + "  AS [%$##@_Alias]"
                            + " WHERE ИтоговаяДата=" + date_str + ""
                            + " ORDER BY ИтоговаяДата";

            OleDbCommand comm = conn.CreateCommand();
            comm.CommandText = CommandText;
            OleDbDataReader reader = comm.ExecuteReader();

            if (reader.Read())
            {
                textBoxRashodSum.Text = reader[0].ToString();
            }
            conn.Close();

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            Add_PrihodRashod();
            Add_Ostatok_na_konets();
            Add_Ostatok_na_nachalo();
            Sum_PKO();
            Sum_RKO();
        }

        private void button2_Click(object sender, EventArgs e)// возврат на главную форму
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
        }

        private void Export_Cass() // экспорт в Word (лист кассовой книги)
        {
            var data = dateTimePicker1.Value.ToShortDateString();
            var ostatok_N = textBoxOstatok_N.Text;
            var ostatok_K = textBoxОstatok_K.Text;
            var prihod = textBoxPrihodSum.Text;
            var rashod = textBoxRashodSum.Text;
            var cassir = textBox1.Text;
            var glavbuh = textBox2.Text;

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{data}", data, wordDocument);
                ReplaceWordStub("{cassir}", cassir, wordDocument);
                ReplaceWordStub("{glavbuh}", glavbuh, wordDocument);
                ReplaceWordStub("{rashod}", rashod, wordDocument);
                ReplaceWordStub("{prihod}", prihod, wordDocument);
                ReplaceWordStub("{ostatok_N}", ostatok_N, wordDocument);
                ReplaceWordStub("{ostatok_K}", ostatok_K, wordDocument);
                

                wordDocument.SaveAs(@"C:\\Users\\Marisha_ChV\\Desktop\\CassBookNew.docx");
                wordApp.Visible = true;
            }

            catch
            {
                MessageBox.Show("Произошла ошибка");
            }

        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)// замена текста
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }


        public void Export_Data_To_Word(DataGridView DGV, string filename)// функция экспорта в Word dataGridView (список кассовіх ордеров)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 12;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                //oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Лист из кассовой книги (список кассовых ордеров)";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);

            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Export_Cass();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.doc)| *.doc";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }
        }


    }
}
