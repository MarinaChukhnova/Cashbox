namespace CashOption
{
    partial class FormRashodAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRashodAdd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOsnovanie = new System.Windows.Forms.ComboBox();
            this.основаниеРасходаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashDataSet = new CashOption.CashDataSet();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPrilojenie = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxSchet = new System.Windows.Forms.ComboBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.comboBoxPoluchatel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.счетаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new CashOption.CashDataSetTableAdapters.СотрудникиTableAdapter();
            this.основаниеРасходаTableAdapter = new CashOption.CashDataSetTableAdapters.ОснованиеРасходаTableAdapter();
            this.счетаTableAdapter = new CashOption.CashDataSetTableAdapters.СчетаTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonFormMain = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.основаниеРасходаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.основаниеРасходаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетаBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.основаниеРасходаBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBoxOsnovanie);
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxPrilojenie);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.comboBoxSchet);
            this.groupBox1.Controls.Add(this.textBoxSum);
            this.groupBox1.Controls.Add(this.comboBoxPoluchatel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxNum);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 467);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // comboBoxOsnovanie
            // 
            this.comboBoxOsnovanie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.основаниеРасходаBindingSource, "Основание", true));
            this.comboBoxOsnovanie.DataSource = this.основаниеРасходаBindingSource;
            this.comboBoxOsnovanie.DisplayMember = "Основание";
            this.comboBoxOsnovanie.FormattingEnabled = true;
            this.comboBoxOsnovanie.Location = new System.Drawing.Point(116, 252);
            this.comboBoxOsnovanie.Name = "comboBoxOsnovanie";
            this.comboBoxOsnovanie.Size = new System.Drawing.Size(593, 21);
            this.comboBoxOsnovanie.TabIndex = 30;
            this.comboBoxOsnovanie.ValueMember = "Основание";
            // 
            // основаниеРасходаBindingSource
            // 
            this.основаниеРасходаBindingSource.DataMember = "ОснованиеРасхода";
            this.основаниеРасходаBindingSource.DataSource = this.cashDataSet;
            // 
            // cashDataSet
            // 
            this.cashDataSet.DataSetName = "CashDataSet";
            this.cashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExport.Location = new System.Drawing.Point(846, 394);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(132, 67);
            this.buttonExport.TabIndex = 27;
            this.buttonExport.Text = "Экспорт в Word";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click_1);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(846, 269);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(132, 57);
            this.buttonClear.TabIndex = 26;
            this.buttonClear.Text = "Очистить ";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(846, 158);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 62);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Сохранить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPrilojenie
            // 
            this.textBoxPrilojenie.Location = new System.Drawing.Point(116, 306);
            this.textBoxPrilojenie.Name = "textBoxPrilojenie";
            this.textBoxPrilojenie.Size = new System.Drawing.Size(593, 20);
            this.textBoxPrilojenie.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(6, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(734, 62);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Подписи";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(579, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 24);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(355, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 24);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 24);
            this.textBox1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Директор";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(264, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Гл. бухгалтер";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(516, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "Кассир";
            // 
            // comboBoxSchet
            // 
            this.comboBoxSchet.FormattingEnabled = true;
            this.comboBoxSchet.Items.AddRange(new object[] {
            "33",
            "65",
            "301",
            "302",
            "311",
            "312",
            "361",
            "371",
            "372",
            "375",
            "377",
            "661",
            "662",
            "685",
            "719"});
            this.comboBoxSchet.Location = new System.Drawing.Point(116, 199);
            this.comboBoxSchet.Name = "comboBoxSchet";
            this.comboBoxSchet.Size = new System.Drawing.Size(80, 21);
            this.comboBoxSchet.TabIndex = 20;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(116, 144);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSum.TabIndex = 18;
            this.textBoxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSum_KeyPress);
            // 
            // comboBoxPoluchatel
            // 
            this.comboBoxPoluchatel.FormattingEnabled = true;
            this.comboBoxPoluchatel.Items.AddRange(new object[] {
            "Иванова Ирина Игоревна (100)",
            "Кузьменко Сергей Николаевич (101)",
            "Сидоров Антон Владимирович (102)",
            "Николаев Николай Васильевич (103)",
            "Пархоменко Татьяна Александровна (104)",
            "Павленко Василий Викторович (105)",
            "Антонова Елена Ивановна (106)",
            "Юдина Елена Петровна (107)",
            "Толчинский Валерий Леонидович (108)",
            "Петренко Леонид Валерьевич (109)",
            "Владимирова Виктория Владимировна (110)",
            "Бычковкий Иван Александрович (111)",
            "Шевцов Дмитрий Никитович (112)",
            "Васильева Валентина Николаевна (113)",
            "Лобунцова Виктория Игоревна (114)",
            "Геращенко Валерий Леонидович (115)",
            "Валуев Николай Николаевич (116)",
            "Романов Василий  Викторович (117)"});
            this.comboBoxPoluchatel.Location = new System.Drawing.Point(116, 96);
            this.comboBoxPoluchatel.Name = "comboBoxPoluchatel";
            this.comboBoxPoluchatel.Size = new System.Drawing.Size(593, 21);
            this.comboBoxPoluchatel.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сумма";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(116, 24);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Приложение";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(25, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Основание";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Корресп/счет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Получатель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ документа";
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.cashDataSet;
            // 
            // счетаBindingSource
            // 
            this.счетаBindingSource.DataMember = "Счета";
            this.счетаBindingSource.DataSource = this.cashDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // основаниеРасходаTableAdapter
            // 
            this.основаниеРасходаTableAdapter.ClearBeforeFill = true;
            // 
            // счетаTableAdapter
            // 
            this.счетаTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.buttonFormMain);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(2, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 46);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Image = global::CashOption.Properties.Resources.word_16076;
            this.button3.Location = new System.Drawing.Point(127, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 41);
            this.button3.TabIndex = 28;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonFormMain
            // 
            this.buttonFormMain.Image = global::CashOption.Properties.Resources.arrow_double_up_1_15737__1_;
            this.buttonFormMain.Location = new System.Drawing.Point(0, 5);
            this.buttonFormMain.Name = "buttonFormMain";
            this.buttonFormMain.Size = new System.Drawing.Size(30, 41);
            this.buttonFormMain.TabIndex = 25;
            this.buttonFormMain.UseVisualStyleBackColor = true;
            this.buttonFormMain.Click += new System.EventHandler(this.buttonFormMain_Click);
            // 
            // button2
            // 
            this.button2.Image = global::CashOption.Properties.Resources.EmptyRecycleBinrecycleempty_VaciarPapeleradereciclaje_reciclar_1890__1_;
            this.button2.Location = new System.Drawing.Point(172, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 41);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::CashOption.Properties.Resources.arrow_left_15605__1_1;
            this.button1.Location = new System.Drawing.Point(36, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 41);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Image = global::CashOption.Properties.Resources.check_ok_accept_apply_1582;
            this.button4.Location = new System.Drawing.Point(81, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 26;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // основаниеРасходаBindingSource1
            // 
            this.основаниеРасходаBindingSource1.DataMember = "ОснованиеРасхода";
            this.основаниеРасходаBindingSource1.DataSource = this.cashDataSet;
            // 
            // FormRashodAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRashodAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расходный кассовый ордер / ввод данных";
            this.Load += new System.EventHandler(this.FormRashodAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.основаниеРасходаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетаBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.основаниеРасходаBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPrilojenie;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxSchet;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.ComboBox comboBoxPoluchatel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExport;
        private CashDataSet cashDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private CashDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource основаниеРасходаBindingSource;
        private CashDataSetTableAdapters.ОснованиеРасходаTableAdapter основаниеРасходаTableAdapter;
        private System.Windows.Forms.BindingSource счетаBindingSource;
        private CashDataSetTableAdapters.СчетаTableAdapter счетаTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxOsnovanie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonFormMain;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource основаниеРасходаBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}