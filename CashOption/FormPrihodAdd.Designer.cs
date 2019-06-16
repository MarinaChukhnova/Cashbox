namespace CashOption
{
    partial class FormPrihodAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrihodAdd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSchet = new System.Windows.Forms.ComboBox();
            this.счетаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashDataSet = new CashOption.CashDataSet();
            this.comboBoxOsnovanie = new System.Windows.Forms.ComboBox();
            this.основаниеПриходаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textBoxPrilojenie = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.comboBoxPrinyatOt = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.сотрудникиBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new CashOption.CashDataSetTableAdapters.СотрудникиTableAdapter();
            this.счетаTableAdapter = new CashOption.CashDataSetTableAdapters.СчетаTableAdapter();
            this.основаниеПриходаTableAdapter = new CashOption.CashDataSetTableAdapters.ОснованиеПриходаTableAdapter();
            this.buttonFormMain = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.счетаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.основаниеПриходаBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxSchet);
            this.groupBox1.Controls.Add(this.comboBoxOsnovanie);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Controls.Add(this.textBoxPrilojenie);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.textBoxSum);
            this.groupBox1.Controls.Add(this.comboBoxPrinyatOt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBoxNum);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 499);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxSchet
            // 
            this.comboBoxSchet.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.счетаBindingSource, "Корресп/ счет", true));
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
            this.comboBoxSchet.Location = new System.Drawing.Point(116, 177);
            this.comboBoxSchet.Name = "comboBoxSchet";
            this.comboBoxSchet.Size = new System.Drawing.Size(131, 21);
            this.comboBoxSchet.TabIndex = 27;
            // 
            // счетаBindingSource
            // 
            this.счетаBindingSource.DataMember = "Счета";
            this.счетаBindingSource.DataSource = this.cashDataSet;
            // 
            // cashDataSet
            // 
            this.cashDataSet.DataSetName = "CashDataSet";
            this.cashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxOsnovanie
            // 
            this.comboBoxOsnovanie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOsnovanie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.основаниеПриходаBindingSource, "Основание", true));
            this.comboBoxOsnovanie.DataSource = this.основаниеПриходаBindingSource;
            this.comboBoxOsnovanie.DisplayMember = "Основание";
            this.comboBoxOsnovanie.FormattingEnabled = true;
            this.comboBoxOsnovanie.Location = new System.Drawing.Point(116, 219);
            this.comboBoxOsnovanie.Name = "comboBoxOsnovanie";
            this.comboBoxOsnovanie.Size = new System.Drawing.Size(577, 21);
            this.comboBoxOsnovanie.TabIndex = 26;
            this.comboBoxOsnovanie.ValueMember = "Основание";
            // 
            // основаниеПриходаBindingSource
            // 
            this.основаниеПриходаBindingSource.DataMember = "ОснованиеПрихода";
            this.основаниеПриходаBindingSource.DataSource = this.cashDataSet;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(867, 245);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 48);
            this.buttonClear.TabIndex = 25;
            this.buttonClear.Text = "Очистить ";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonOtmena_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExport.Location = new System.Drawing.Point(867, 374);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(102, 86);
            this.buttonExport.TabIndex = 4;
            this.buttonExport.Text = "Экспорт в Word";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textBoxPrilojenie
            // 
            this.textBoxPrilojenie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrilojenie.Location = new System.Drawing.Point(116, 267);
            this.textBoxPrilojenie.Name = "textBoxPrilojenie";
            this.textBoxPrilojenie.Size = new System.Drawing.Size(577, 20);
            this.textBoxPrilojenie.TabIndex = 23;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(867, 164);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 48);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Сохранить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(9, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(730, 86);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Подписи";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(556, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 24);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 24);
            this.textBox1.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(120, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Гл. бухгалтер";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(491, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "Кассир";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSum.Location = new System.Drawing.Point(116, 135);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(119, 20);
            this.textBoxSum.TabIndex = 18;
            this.textBoxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSum_KeyPress);
            // 
            // comboBoxPrinyatOt
            // 
            this.comboBoxPrinyatOt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPrinyatOt.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.сотрудникиBindingSource, "ФИО (табельный номер)", true));
            this.comboBoxPrinyatOt.FormattingEnabled = true;
            this.comboBoxPrinyatOt.Items.AddRange(new object[] {
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
            this.comboBoxPrinyatOt.Location = new System.Drawing.Point(116, 96);
            this.comboBoxPrinyatOt.Name = "comboBoxPrinyatOt";
            this.comboBoxPrinyatOt.Size = new System.Drawing.Size(577, 21);
            this.comboBoxPrinyatOt.TabIndex = 16;
            this.comboBoxPrinyatOt.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrinyatOt_SelectedIndexChanged);
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.cashDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сумма";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // textBoxNum
            // 
            this.textBoxNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNum.Location = new System.Drawing.Point(116, 24);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(119, 20);
            this.textBoxNum.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Приложение";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(23, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Основание";
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
            this.label4.Location = new System.Drawing.Point(23, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Корресп/счет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Принято от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
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
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Image = global::CashOption.Properties.Resources.arrow_left_15605__1_1;
            this.buttonBack.Location = new System.Drawing.Point(36, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(39, 41);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // сотрудникиBindingSource3
            // 
            this.сотрудникиBindingSource3.DataMember = "Сотрудники";
            this.сотрудникиBindingSource3.DataSource = this.cashDataSet;
            // 
            // сотрудникиBindingSource2
            // 
            this.сотрудникиBindingSource2.DataMember = "Сотрудники";
            this.сотрудникиBindingSource2.DataSource = this.cashDataSet;
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this.cashDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // счетаTableAdapter
            // 
            this.счетаTableAdapter.ClearBeforeFill = true;
            // 
            // основаниеПриходаTableAdapter
            // 
            this.основаниеПриходаTableAdapter.ClearBeforeFill = true;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::CashOption.Properties.Resources.check_ok_accept_apply_1582;
            this.button1.Location = new System.Drawing.Point(81, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.buttonFormMain);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.buttonBack);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 46);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // FormPrihodAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrihodAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приходный кассовый ордер / введение данных";
            this.Load += new System.EventHandler(this.FormPrihodAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.счетаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.основаниеПриходаBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        

        #endregion

            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.Button buttonBack;
            private System.Windows.Forms.Button buttonExport;
            public System.Windows.Forms.TextBox textBoxPrilojenie;
            private System.Windows.Forms.Button buttonAdd;
            private System.Windows.Forms.GroupBox groupBox3;
            private System.Windows.Forms.TextBox textBox2;
            private System.Windows.Forms.TextBox textBox1;
            private System.Windows.Forms.Label label14;
            private System.Windows.Forms.Label label15;
            public System.Windows.Forms.TextBox textBoxSum;
            public System.Windows.Forms.ComboBox comboBoxPrinyatOt;
            private System.Windows.Forms.Label label5;
            public System.Windows.Forms.DateTimePicker dateTimePicker1;
            public System.Windows.Forms.TextBox textBoxNum;
            private System.Windows.Forms.Label label12;
            private System.Windows.Forms.Label label11;
            private System.Windows.Forms.Label label7;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label1;
            private CashDataSet cashDataSet;
            private System.Windows.Forms.BindingSource сотрудникиBindingSource;
            private CashDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
            private System.Windows.Forms.BindingSource счетаBindingSource;
            private CashDataSetTableAdapters.СчетаTableAdapter счетаTableAdapter;
            private System.Windows.Forms.BindingSource основаниеПриходаBindingSource;
            private CashDataSetTableAdapters.ОснованиеПриходаTableAdapter основаниеПриходаTableAdapter;
            private System.Windows.Forms.Button buttonClear;
            public System.Windows.Forms.ComboBox comboBoxOsnovanie;
            private System.Windows.Forms.ComboBox comboBoxSchet;
            private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
            private System.Windows.Forms.BindingSource сотрудникиBindingSource2;
            private System.Windows.Forms.BindingSource сотрудникиBindingSource3;
            private System.Windows.Forms.Button buttonFormMain;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.Button button2;
            private System.Windows.Forms.Button button3;
            private System.Windows.Forms.GroupBox groupBox2;
        }
    }
