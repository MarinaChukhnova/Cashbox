namespace CashOption
{
    partial class FormScheta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScheta));
            this.cashDataSet = new CashOption.CashDataSet();
            this.счетаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.счетаTableAdapter = new CashOption.CashDataSetTableAdapters.СчетаTableAdapter();
            this.tableAdapterManager = new CashOption.CashDataSetTableAdapters.TableAdapterManager();
            this.счетаDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImya = new System.Windows.Forms.TextBox();
            this.textBoxSchet = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cashDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cashDataSet
            // 
            this.cashDataSet.DataSetName = "CashDataSet";
            this.cashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // счетаBindingSource
            // 
            this.счетаBindingSource.DataMember = "Счета";
            this.счетаBindingSource.DataSource = this.cashDataSet;
            // 
            // счетаTableAdapter
            // 
            this.счетаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CashOption.CashDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЖурналРегистрацииКассовыхОрдеровTableAdapter = null;
            this.tableAdapterManager.КассоваяКнигаTableAdapter = null;
            this.tableAdapterManager.ЛимитTableAdapter = null;
            this.tableAdapterManager.ОснованиеПриходаTableAdapter = null;
            this.tableAdapterManager.ОснованиеРасходаTableAdapter = null;
            this.tableAdapterManager.ПриходныйКассовыйОрдерTableAdapter = null;
            this.tableAdapterManager.РасходныйКассовыйОрдерTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СчетаTableAdapter = this.счетаTableAdapter;
            // 
            // счетаDataGridView
            // 
            this.счетаDataGridView.AutoGenerateColumns = false;
            this.счетаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.счетаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.счетаDataGridView.DataSource = this.счетаBindingSource;
            this.счетаDataGridView.Location = new System.Drawing.Point(1, 35);
            this.счетаDataGridView.Name = "счетаDataGridView";
            this.счетаDataGridView.Size = new System.Drawing.Size(505, 278);
            this.счетаDataGridView.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(164, 397);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(277, 397);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наименование счета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Корреспондирующий счет";
            // 
            // textBoxImya
            // 
            this.textBoxImya.Location = new System.Drawing.Point(164, 327);
            this.textBoxImya.Name = "textBoxImya";
            this.textBoxImya.Size = new System.Drawing.Size(265, 20);
            this.textBoxImya.TabIndex = 6;
            // 
            // textBoxSchet
            // 
            this.textBoxSchet.Location = new System.Drawing.Point(164, 353);
            this.textBoxSchet.Name = "textBoxSchet";
            this.textBoxSchet.Size = new System.Drawing.Size(100, 20);
            this.textBoxSchet.TabIndex = 7;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = global::CashOption.Properties.Resources.arrow_left_15605__1_;
            this.buttonBack.Location = new System.Drawing.Point(1, -1);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(39, 30);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Корресп/ счет";
            this.dataGridViewTextBoxColumn2.HeaderText = "Корресп/ счет";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 365;
            // 
            // FormScheta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 443);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxSchet);
            this.Controls.Add(this.textBoxImya);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.счетаDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormScheta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корреспондирующие счета";
            this.Load += new System.EventHandler(this.FormScheta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CashDataSet cashDataSet;
        private System.Windows.Forms.BindingSource счетаBindingSource;
        private CashDataSetTableAdapters.СчетаTableAdapter счетаTableAdapter;
        private CashDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView счетаDataGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxImya;
        private System.Windows.Forms.TextBox textBoxSchet;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}