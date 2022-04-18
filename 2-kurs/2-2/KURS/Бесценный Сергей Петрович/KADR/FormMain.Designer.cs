
namespace KADR
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.кадрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарплатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sotrudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kadrDataSet = new KADR.kadrDataSet();
            this.sotrudTableAdapter = new KADR.kadrDataSetTableAdapters.sotrudTableAdapter();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koeff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrazrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddolgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadrDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кадрыToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.зарплатаToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // кадрыToolStripMenuItem
            // 
            this.кадрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.кадрыToolStripMenuItem.Name = "кадрыToolStripMenuItem";
            this.кадрыToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.кадрыToolStripMenuItem.Text = "Кадры";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // зарплатаToolStripMenuItem
            // 
            this.зарплатаToolStripMenuItem.Name = "зарплатаToolStripMenuItem";
            this.зарплатаToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.зарплатаToolStripMenuItem.Text = "Зарплата";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(16, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудники";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioDataGridViewTextBoxColumn,
            this.nazv,
            this.koeff,
            this.premiapDataGridViewTextBoxColumn,
            this.phonesDataGridViewTextBoxColumn,
            this.adrDataGridViewTextBoxColumn,
            this.dopDataGridViewTextBoxColumn,
            this.idrazrDataGridViewTextBoxColumn,
            this.iddolgDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sotrudBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // sotrudBindingSource
            // 
            this.sotrudBindingSource.DataMember = "sotrud";
            this.sotrudBindingSource.DataSource = this.kadrDataSet;
            // 
            // kadrDataSet
            // 
            this.kadrDataSet.DataSetName = "kadrDataSet";
            this.kadrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudTableAdapter
            // 
            this.sotrudTableAdapter.ClearBeforeFill = true;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.Width = 59;
            // 
            // nazv
            // 
            this.nazv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nazv.DataPropertyName = "nazv";
            this.nazv.HeaderText = "Должность";
            this.nazv.Name = "nazv";
            this.nazv.Width = 90;
            // 
            // koeff
            // 
            this.koeff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.koeff.DataPropertyName = "koeff";
            this.koeff.HeaderText = "Кофф";
            this.koeff.Name = "koeff";
            this.koeff.Width = 61;
            // 
            // premiapDataGridViewTextBoxColumn
            // 
            this.premiapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.premiapDataGridViewTextBoxColumn.DataPropertyName = "premia_p";
            this.premiapDataGridViewTextBoxColumn.HeaderText = "Премия";
            this.premiapDataGridViewTextBoxColumn.Name = "premiapDataGridViewTextBoxColumn";
            this.premiapDataGridViewTextBoxColumn.Width = 5;
            // 
            // phonesDataGridViewTextBoxColumn
            // 
            this.phonesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phonesDataGridViewTextBoxColumn.DataPropertyName = "phones";
            this.phonesDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phonesDataGridViewTextBoxColumn.Name = "phonesDataGridViewTextBoxColumn";
            this.phonesDataGridViewTextBoxColumn.Width = 77;
            // 
            // adrDataGridViewTextBoxColumn
            // 
            this.adrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.adrDataGridViewTextBoxColumn.DataPropertyName = "adr";
            this.adrDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adrDataGridViewTextBoxColumn.Name = "adrDataGridViewTextBoxColumn";
            this.adrDataGridViewTextBoxColumn.Width = 63;
            // 
            // dopDataGridViewTextBoxColumn
            // 
            this.dopDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dopDataGridViewTextBoxColumn.DataPropertyName = "dop";
            this.dopDataGridViewTextBoxColumn.HeaderText = "Прим.";
            this.dopDataGridViewTextBoxColumn.Name = "dopDataGridViewTextBoxColumn";
            this.dopDataGridViewTextBoxColumn.Width = 63;
            // 
            // idrazrDataGridViewTextBoxColumn
            // 
            this.idrazrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.idrazrDataGridViewTextBoxColumn.DataPropertyName = "id_razr";
            this.idrazrDataGridViewTextBoxColumn.HeaderText = "ИДР";
            this.idrazrDataGridViewTextBoxColumn.Name = "idrazrDataGridViewTextBoxColumn";
            this.idrazrDataGridViewTextBoxColumn.Width = 5;
            // 
            // iddolgDataGridViewTextBoxColumn
            // 
            this.iddolgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.iddolgDataGridViewTextBoxColumn.DataPropertyName = "id_dolg";
            this.iddolgDataGridViewTextBoxColumn.HeaderText = "ИДД";
            this.iddolgDataGridViewTextBoxColumn.Name = "iddolgDataGridViewTextBoxColumn";
            this.iddolgDataGridViewTextBoxColumn.Width = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ИДС";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Управление кадрами и зарплатой";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadrDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem кадрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зарплатаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kadrDataSet kadrDataSet;
        private System.Windows.Forms.BindingSource sotrudBindingSource;
        private kadrDataSetTableAdapters.sotrudTableAdapter sotrudTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazv;
        private System.Windows.Forms.DataGridViewTextBoxColumn koeff;
        private System.Windows.Forms.DataGridViewTextBoxColumn premiapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrazrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddolgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}

