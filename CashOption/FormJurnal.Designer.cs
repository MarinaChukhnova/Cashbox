namespace CashOption
{
    partial class FormJurnal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJurnal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSearchDate = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFormMain = new System.Windows.Forms.Button();
            this.buttonExsportNavigator = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFormMain);
            this.groupBox1.Controls.Add(this.buttonExsportNavigator);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSearchDate);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(6, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 80);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // buttonSearchDate
            // 
            this.buttonSearchDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchDate.Location = new System.Drawing.Point(0, 19);
            this.buttonSearchDate.Name = "buttonSearchDate";
            this.buttonSearchDate.Size = new System.Drawing.Size(75, 45);
            this.buttonSearchDate.TabIndex = 1;
            this.buttonSearchDate.Text = "Поиск по дате";
            this.buttonSearchDate.UseVisualStyleBackColor = true;
            this.buttonSearchDate.Click += new System.EventHandler(this.buttonSearchDate_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(338, 31);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(106, 25);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 25);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "по";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "с \r\n(не вкл.)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFormMain
            // 
            this.buttonFormMain.Image = global::CashOption.Properties.Resources.arrow_double_up_1_15737__1_;
            this.buttonFormMain.Location = new System.Drawing.Point(7, 5);
            this.buttonFormMain.Name = "buttonFormMain";
            this.buttonFormMain.Size = new System.Drawing.Size(39, 43);
            this.buttonFormMain.TabIndex = 3;
            this.buttonFormMain.UseVisualStyleBackColor = true;
            this.buttonFormMain.Click += new System.EventHandler(this.buttonFormMain_Click);
            // 
            // buttonExsportNavigator
            // 
            this.buttonExsportNavigator.Image = global::CashOption.Properties.Resources.word_16076;
            this.buttonExsportNavigator.Location = new System.Drawing.Point(52, 6);
            this.buttonExsportNavigator.Name = "buttonExsportNavigator";
            this.buttonExsportNavigator.Size = new System.Drawing.Size(48, 42);
            this.buttonExsportNavigator.TabIndex = 2;
            this.buttonExsportNavigator.UseVisualStyleBackColor = true;
            this.buttonExsportNavigator.Click += new System.EventHandler(this.buttonExsportNavigator_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExport.Image = global::CashOption.Properties.Resources.word_16076;
            this.buttonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExport.Location = new System.Drawing.Point(578, 418);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(138, 60);
            this.buttonExport.TabIndex = 1;
            this.buttonExport.Text = "Экспорт\r\n в Word";
            this.buttonExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // FormJurnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJurnal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал регистрации кассовых операций";
            this.Load += new System.EventHandler(this.FormJurnal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonExsportNavigator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFormMain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSearchDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}