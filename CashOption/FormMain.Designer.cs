namespace CashOption
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRKO = new System.Windows.Forms.Button();
            this.buttonPKO = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonJurnal = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.первичныеДокументыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приходныйКассовыйОрдерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходныйКассовыйОрдерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетныеДокументыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кассоваяКнигаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналРегистрацииКассовыхОрдеровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справичникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лимитКассыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(998, 516);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonRKO);
            this.tabPage1.Controls.Add(this.buttonPKO);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(990, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кассовые операции";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonRKO
            // 
            this.buttonRKO.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRKO.Location = new System.Drawing.Point(549, 135);
            this.buttonRKO.Name = "buttonRKO";
            this.buttonRKO.Size = new System.Drawing.Size(336, 204);
            this.buttonRKO.TabIndex = 1;
            this.buttonRKO.Text = "Выдача денежных средств из кассы";
            this.buttonRKO.UseVisualStyleBackColor = true;
            this.buttonRKO.Click += new System.EventHandler(this.buttonRKO_Click);
            // 
            // buttonPKO
            // 
            this.buttonPKO.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPKO.Location = new System.Drawing.Point(108, 135);
            this.buttonPKO.Name = "buttonPKO";
            this.buttonPKO.Size = new System.Drawing.Size(343, 204);
            this.buttonPKO.TabIndex = 0;
            this.buttonPKO.Text = "Оприходование денежных средств в кассу";
            this.buttonPKO.UseVisualStyleBackColor = true;
            this.buttonPKO.Click += new System.EventHandler(this.buttonPKO_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonBook);
            this.tabPage2.Controls.Add(this.buttonJurnal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(990, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчеты по кассовым операциям";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonBook
            // 
            this.buttonBook.AutoSize = true;
            this.buttonBook.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBook.Location = new System.Drawing.Point(581, 130);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(318, 210);
            this.buttonBook.TabIndex = 1;
            this.buttonBook.Text = "Кассовая книга";
            this.buttonBook.UseMnemonic = false;
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonJurnal
            // 
            this.buttonJurnal.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonJurnal.Location = new System.Drawing.Point(115, 130);
            this.buttonJurnal.Name = "buttonJurnal";
            this.buttonJurnal.Size = new System.Drawing.Size(326, 210);
            this.buttonJurnal.TabIndex = 0;
            this.buttonJurnal.Text = "Журнал регистрации кассовых ордеров";
            this.buttonJurnal.UseVisualStyleBackColor = true;
            this.buttonJurnal.Click += new System.EventHandler(this.buttonJurnal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.первичныеДокументыToolStripMenuItem,
            this.отчетныеДокументыToolStripMenuItem,
            this.справичникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // первичныеДокументыToolStripMenuItem
            // 
            this.первичныеДокументыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приходныйКассовыйОрдерToolStripMenuItem,
            this.расходныйКассовыйОрдерToolStripMenuItem});
            this.первичныеДокументыToolStripMenuItem.Name = "первичныеДокументыToolStripMenuItem";
            this.первичныеДокументыToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.первичныеДокументыToolStripMenuItem.Text = "Первичные документы";
            // 
            // приходныйКассовыйОрдерToolStripMenuItem
            // 
            this.приходныйКассовыйОрдерToolStripMenuItem.Name = "приходныйКассовыйОрдерToolStripMenuItem";
            this.приходныйКассовыйОрдерToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.приходныйКассовыйОрдерToolStripMenuItem.Text = "Приходный кассовый ордер";
            this.приходныйКассовыйОрдерToolStripMenuItem.Click += new System.EventHandler(this.приходныйКассовыйОрдерToolStripMenuItem_Click);
            // 
            // расходныйКассовыйОрдерToolStripMenuItem
            // 
            this.расходныйКассовыйОрдерToolStripMenuItem.Name = "расходныйКассовыйОрдерToolStripMenuItem";
            this.расходныйКассовыйОрдерToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.расходныйКассовыйОрдерToolStripMenuItem.Text = "Расходный кассовый ордер";
            this.расходныйКассовыйОрдерToolStripMenuItem.Click += new System.EventHandler(this.расходныйКассовыйОрдерToolStripMenuItem_Click);
            // 
            // отчетныеДокументыToolStripMenuItem
            // 
            this.отчетныеДокументыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кассоваяКнигаToolStripMenuItem,
            this.журналРегистрацииКассовыхОрдеровToolStripMenuItem});
            this.отчетныеДокументыToolStripMenuItem.Name = "отчетныеДокументыToolStripMenuItem";
            this.отчетныеДокументыToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.отчетныеДокументыToolStripMenuItem.Text = "Отчетные документы";
            // 
            // кассоваяКнигаToolStripMenuItem
            // 
            this.кассоваяКнигаToolStripMenuItem.Name = "кассоваяКнигаToolStripMenuItem";
            this.кассоваяКнигаToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.кассоваяКнигаToolStripMenuItem.Text = "Кассовая книга";
            this.кассоваяКнигаToolStripMenuItem.Click += new System.EventHandler(this.кассоваяКнигаToolStripMenuItem_Click);
            // 
            // журналРегистрацииКассовыхОрдеровToolStripMenuItem
            // 
            this.журналРегистрацииКассовыхОрдеровToolStripMenuItem.Name = "журналРегистрацииКассовыхОрдеровToolStripMenuItem";
            this.журналРегистрацииКассовыхОрдеровToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.журналРегистрацииКассовыхОрдеровToolStripMenuItem.Text = "Журнал регистрации кассовых ордеров";
            this.журналРегистрацииКассовыхОрдеровToolStripMenuItem.Click += new System.EventHandler(this.журналРегистрацииКассовыхОрдеровToolStripMenuItem_Click);
            // 
            // справичникиToolStripMenuItem
            // 
            this.справичникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.счетаToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.лимитКассыToolStripMenuItem});
            this.справичникиToolStripMenuItem.Name = "справичникиToolStripMenuItem";
            this.справичникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справичникиToolStripMenuItem.Text = "Справочники";
            // 
            // счетаToolStripMenuItem
            // 
            this.счетаToolStripMenuItem.Name = "счетаToolStripMenuItem";
            this.счетаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.счетаToolStripMenuItem.Text = "Счета";
            this.счетаToolStripMenuItem.Click += new System.EventHandler(this.счетаToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // лимитКассыToolStripMenuItem
            // 
            this.лимитКассыToolStripMenuItem.Name = "лимитКассыToolStripMenuItem";
            this.лимитКассыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.лимитКассыToolStripMenuItem.Text = "Лимит кассы";
            this.лимитКассыToolStripMenuItem.Click += new System.EventHandler(this.лимитКассыToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 555);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonRKO;
        private System.Windows.Forms.Button buttonPKO;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonJurnal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem первичныеДокументыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приходныйКассовыйОрдерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расходныйКассовыйОрдерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетныеДокументыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кассоваяКнигаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналРегистрацииКассовыхОрдеровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справичникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem счетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лимитКассыToolStripMenuItem;
    }
}

