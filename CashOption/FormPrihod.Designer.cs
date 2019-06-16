namespace CashOption
{
    partial class FormPrihod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrihod));
            this.dataGridViewPK0 = new System.Windows.Forms.DataGridView();
            this.номерДокументаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.принятоОтDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.корреспсчетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.основаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приложениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приходныйКассовыйОрдерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashDataSet = new CashOption.CashDataSet();
            this.приходныйКассовыйОрдерTableAdapter = new CashOption.CashDataSetTableAdapters.ПриходныйКассовыйОрдерTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSearchDate = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonAdd1 = new System.Windows.Forms.Button();
            this.buttonDelete1 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPK0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходныйКассовыйОрдерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPK0
            // 
            this.dataGridViewPK0.AutoGenerateColumns = false;
            this.dataGridViewPK0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPK0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДокументаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.принятоОтDataGridViewTextBoxColumn,
            this.корреспсчетDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.основаниеDataGridViewTextBoxColumn,
            this.приложениеDataGridViewTextBoxColumn});
            this.dataGridViewPK0.DataSource = this.приходныйКассовыйОрдерBindingSource;
            this.dataGridViewPK0.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewPK0.Name = "dataGridViewPK0";
            this.dataGridViewPK0.Size = new System.Drawing.Size(969, 281);
            this.dataGridViewPK0.TabIndex = 0;
            this.dataGridViewPK0.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPK0_CellMouseDoubleClick);
            // 
            // номерДокументаDataGridViewTextBoxColumn
            // 
            this.номерДокументаDataGridViewTextBoxColumn.DataPropertyName = "Номер документа";
            this.номерДокументаDataGridViewTextBoxColumn.HeaderText = "Номер документа";
            this.номерДокументаDataGridViewTextBoxColumn.Name = "номерДокументаDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // принятоОтDataGridViewTextBoxColumn
            // 
            this.принятоОтDataGridViewTextBoxColumn.DataPropertyName = "Принято от";
            this.принятоОтDataGridViewTextBoxColumn.HeaderText = "Принято от";
            this.принятоОтDataGridViewTextBoxColumn.Name = "принятоОтDataGridViewTextBoxColumn";
            this.принятоОтDataGridViewTextBoxColumn.Width = 225;
            // 
            // корреспсчетDataGridViewTextBoxColumn
            // 
            this.корреспсчетDataGridViewTextBoxColumn.DataPropertyName = "Корресп/счет";
            this.корреспсчетDataGridViewTextBoxColumn.HeaderText = "Корресп/счет";
            this.корреспсчетDataGridViewTextBoxColumn.Name = "корреспсчетDataGridViewTextBoxColumn";
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            // 
            // основаниеDataGridViewTextBoxColumn
            // 
            this.основаниеDataGridViewTextBoxColumn.DataPropertyName = "Основание";
            this.основаниеDataGridViewTextBoxColumn.HeaderText = "Основание";
            this.основаниеDataGridViewTextBoxColumn.Name = "основаниеDataGridViewTextBoxColumn";
            this.основаниеDataGridViewTextBoxColumn.Width = 150;
            // 
            // приложениеDataGridViewTextBoxColumn
            // 
            this.приложениеDataGridViewTextBoxColumn.DataPropertyName = "Приложение";
            this.приложениеDataGridViewTextBoxColumn.HeaderText = "Приложение";
            this.приложениеDataGridViewTextBoxColumn.Name = "приложениеDataGridViewTextBoxColumn";
            this.приложениеDataGridViewTextBoxColumn.Width = 150;
            // 
            // приходныйКассовыйОрдерBindingSource
            // 
            this.приходныйКассовыйОрдерBindingSource.DataMember = "ПриходныйКассовыйОрдер";
            this.приходныйКассовыйОрдерBindingSource.DataSource = this.cashDataSet;
            this.приходныйКассовыйОрдерBindingSource.CurrentChanged += new System.EventHandler(this.приходныйКассовыйОрдерBindingSource_CurrentChanged);
            // 
            // cashDataSet
            // 
            this.cashDataSet.DataSetName = "CashDataSet";
            this.cashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // приходныйКассовыйОрдерTableAdapter
            // 
            this.приходныйКассовыйОрдерTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(469, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "по имени сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(808, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "по основанию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(808, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "по приложению";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(692, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "по счету";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(509, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 37);
            this.button5.TabIndex = 6;
            this.button5.Text = "по номеру документа";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(692, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 35);
            this.button6.TabIndex = 7;
            this.button6.Text = "по сумме";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 511);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 107);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.buttonSearchDate);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 624);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 80);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "с \r\n(не вкл.)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSearchDate
            // 
            this.buttonSearchDate.Location = new System.Drawing.Point(0, 19);
            this.buttonSearchDate.Name = "buttonSearchDate";
            this.buttonSearchDate.Size = new System.Drawing.Size(75, 55);
            this.buttonSearchDate.TabIndex = 1;
            this.buttonSearchDate.Text = "Поиск по дате";
            this.buttonSearchDate.UseVisualStyleBackColor = true;
            this.buttonSearchDate.Click += new System.EventHandler(this.buttonSearchDate_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(285, 31);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(106, 26);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "по";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сумма прихода, грн\r\n";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.buttonAdd1);
            this.groupBox4.Controls.Add(this.buttonDelete1);
            this.groupBox4.Controls.Add(this.buttonBack);
            this.groupBox4.Controls.Add(this.buttonRefresh);
            this.groupBox4.Location = new System.Drawing.Point(12, -4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(969, 50);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // button11
            // 
            this.button11.Image = global::CashOption.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.button11.Location = new System.Drawing.Point(237, 8);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(42, 38);
            this.button11.TabIndex = 11;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Image = global::CashOption.Properties.Resources.Open_folder_add_36742;
            this.button10.Location = new System.Drawing.Point(139, 7);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(44, 38);
            this.button10.TabIndex = 10;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.Image = global::CashOption.Properties.Resources.add_12966;
            this.buttonAdd1.Location = new System.Drawing.Point(94, 7);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(39, 38);
            this.buttonAdd1.TabIndex = 9;
            this.buttonAdd1.UseVisualStyleBackColor = true;
            this.buttonAdd1.Click += new System.EventHandler(this.buttonAdd1_Click);
            // 
            // buttonDelete1
            // 
            this.buttonDelete1.Image = global::CashOption.Properties.Resources.delete_delete_exit_1577;
            this.buttonDelete1.Location = new System.Drawing.Point(189, 7);
            this.buttonDelete1.Name = "buttonDelete1";
            this.buttonDelete1.Size = new System.Drawing.Size(42, 38);
            this.buttonDelete1.TabIndex = 5;
            this.buttonDelete1.UseVisualStyleBackColor = true;
            this.buttonDelete1.Click += new System.EventHandler(this.buttonDelete1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Image = global::CashOption.Properties.Resources.arrow_left_15605__1_1;
            this.buttonBack.Location = new System.Drawing.Point(6, 8);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(37, 37);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::CashOption.Properties.Resources.refresh_arrow_1546__1_;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefresh.Location = new System.Drawing.Point(49, 7);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(39, 38);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(193, 19);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(132, 25);
            this.textBoxSum.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonInsert);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 111);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Команды";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(193, 36);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(145, 55);
            this.button9.TabIndex = 5;
            this.button9.Text = "Добавить копированием";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(357, 36);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 55);
            this.button7.TabIndex = 4;
            this.button7.Text = "Редактировать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(540, 36);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(141, 55);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(17, 36);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(158, 55);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Добавить";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(331, 19);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(75, 23);
            this.buttonSum.TabIndex = 13;
            this.buttonSum.Text = "Расчет";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.buttonSum);
            this.groupBox5.Controls.Add(this.textBoxSum);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(12, 335);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(424, 53);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // FormPrihod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 715);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewPK0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrihod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приходный кассовый ордер";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPK0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходныйКассовыйОрдерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPK0;
        private CashDataSet cashDataSet;
        private System.Windows.Forms.BindingSource приходныйКассовыйОрдерBindingSource;
        private CashDataSetTableAdapters.ПриходныйКассовыйОрдерTableAdapter приходныйКассовыйОрдерTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonAdd1;
        private System.Windows.Forms.Button buttonDelete1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSearchDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДокументаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn принятоОтDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn корреспсчетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn основаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn приложениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
    }
}