﻿namespace Drugstore.Dictionary
{
    partial class GoodsForm
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.товариBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugstoreDataSet = new Drugstore.DrugstoreDataSet();
            this.товариTableAdapter = new Drugstore.DrugstoreDataSetTableAdapters.ТовариTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.одВимDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мінЗапасDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ставкаНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.виробникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вхЦінаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вхЦінаБезНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.націнкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цінаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.інформаціяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.можливістьПоверненняDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.рецептDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.аналогDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.позиціяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодМорионаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товариBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.назваDataGridViewTextBoxColumn,
            this.одВимDataGridViewTextBoxColumn,
            this.мінЗапасDataGridViewTextBoxColumn,
            this.артикулDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.ставкаНДСDataGridViewTextBoxColumn,
            this.виробникDataGridViewTextBoxColumn,
            this.вхЦінаDataGridViewTextBoxColumn,
            this.вхЦінаБезНДСDataGridViewTextBoxColumn,
            this.націнкаDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.цінаDataGridViewTextBoxColumn,
            this.інформаціяDataGridViewTextBoxColumn,
            this.фотоDataGridViewImageColumn,
            this.можливістьПоверненняDataGridViewCheckBoxColumn,
            this.рецептDataGridViewCheckBoxColumn,
            this.аналогDataGridViewTextBoxColumn,
            this.кількістьDataGridViewTextBoxColumn,
            this.позиціяDataGridViewTextBoxColumn,
            this.кодМорионаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.товариBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(853, 451);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(853, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::Drugstore.Properties.Resources.edit_add_6635;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(66, 22);
            this.tsbAdd.Text = "Додати";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::Drugstore.Properties.Resources.edit_3262;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(87, 22);
            this.tsbEdit.Text = "Редагувати";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::Drugstore.Properties.Resources.deletered_8548;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(79, 22);
            this.tsbDelete.Text = "Видалити";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // товариBindingSource
            // 
            this.товариBindingSource.DataMember = "Товари";
            this.товариBindingSource.DataSource = this.drugstoreDataSet;
            // 
            // drugstoreDataSet
            // 
            this.drugstoreDataSet.DataSetName = "DrugstoreDataSet";
            this.drugstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товариTableAdapter
            // 
            this.товариTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // назваDataGridViewTextBoxColumn
            // 
            this.назваDataGridViewTextBoxColumn.DataPropertyName = "Назва";
            this.назваDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.назваDataGridViewTextBoxColumn.Name = "назваDataGridViewTextBoxColumn";
            // 
            // одВимDataGridViewTextBoxColumn
            // 
            this.одВимDataGridViewTextBoxColumn.DataPropertyName = "ОдВим";
            this.одВимDataGridViewTextBoxColumn.HeaderText = "ОдВим";
            this.одВимDataGridViewTextBoxColumn.Name = "одВимDataGridViewTextBoxColumn";
            // 
            // мінЗапасDataGridViewTextBoxColumn
            // 
            this.мінЗапасDataGridViewTextBoxColumn.DataPropertyName = "МінЗапас";
            this.мінЗапасDataGridViewTextBoxColumn.HeaderText = "МінЗапас";
            this.мінЗапасDataGridViewTextBoxColumn.Name = "мінЗапасDataGridViewTextBoxColumn";
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ШтрихКод";
            this.dataGridViewTextBoxColumn1.HeaderText = "ШтрихКод";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ставкаНДСDataGridViewTextBoxColumn
            // 
            this.ставкаНДСDataGridViewTextBoxColumn.DataPropertyName = "СтавкаНДС";
            this.ставкаНДСDataGridViewTextBoxColumn.HeaderText = "СтавкаНДС";
            this.ставкаНДСDataGridViewTextBoxColumn.Name = "ставкаНДСDataGridViewTextBoxColumn";
            // 
            // виробникDataGridViewTextBoxColumn
            // 
            this.виробникDataGridViewTextBoxColumn.DataPropertyName = "Виробник";
            this.виробникDataGridViewTextBoxColumn.HeaderText = "Виробник";
            this.виробникDataGridViewTextBoxColumn.Name = "виробникDataGridViewTextBoxColumn";
            // 
            // вхЦінаDataGridViewTextBoxColumn
            // 
            this.вхЦінаDataGridViewTextBoxColumn.DataPropertyName = "ВхЦіна";
            this.вхЦінаDataGridViewTextBoxColumn.HeaderText = "ВхЦіна";
            this.вхЦінаDataGridViewTextBoxColumn.Name = "вхЦінаDataGridViewTextBoxColumn";
            // 
            // вхЦінаБезНДСDataGridViewTextBoxColumn
            // 
            this.вхЦінаБезНДСDataGridViewTextBoxColumn.DataPropertyName = "ВхЦінаБезНДС";
            this.вхЦінаБезНДСDataGridViewTextBoxColumn.HeaderText = "ВхЦінаБезНДС";
            this.вхЦінаБезНДСDataGridViewTextBoxColumn.Name = "вхЦінаБезНДСDataGridViewTextBoxColumn";
            // 
            // націнкаDataGridViewTextBoxColumn
            // 
            this.націнкаDataGridViewTextBoxColumn.DataPropertyName = "Націнка";
            this.націнкаDataGridViewTextBoxColumn.HeaderText = "Націнка";
            this.націнкаDataGridViewTextBoxColumn.Name = "націнкаDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Упаковка";
            this.dataGridViewTextBoxColumn2.HeaderText = "Упаковка";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // цінаDataGridViewTextBoxColumn
            // 
            this.цінаDataGridViewTextBoxColumn.DataPropertyName = "Ціна";
            this.цінаDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.цінаDataGridViewTextBoxColumn.Name = "цінаDataGridViewTextBoxColumn";
            // 
            // інформаціяDataGridViewTextBoxColumn
            // 
            this.інформаціяDataGridViewTextBoxColumn.DataPropertyName = "Інформація";
            this.інформаціяDataGridViewTextBoxColumn.HeaderText = "Інформація";
            this.інформаціяDataGridViewTextBoxColumn.Name = "інформаціяDataGridViewTextBoxColumn";
            // 
            // фотоDataGridViewImageColumn
            // 
            this.фотоDataGridViewImageColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewImageColumn.HeaderText = "Фото";
            this.фотоDataGridViewImageColumn.Name = "фотоDataGridViewImageColumn";
            // 
            // можливістьПоверненняDataGridViewCheckBoxColumn
            // 
            this.можливістьПоверненняDataGridViewCheckBoxColumn.DataPropertyName = "МожливістьПовернення";
            this.можливістьПоверненняDataGridViewCheckBoxColumn.HeaderText = "МожливістьПовернення";
            this.можливістьПоверненняDataGridViewCheckBoxColumn.Name = "можливістьПоверненняDataGridViewCheckBoxColumn";
            // 
            // рецептDataGridViewCheckBoxColumn
            // 
            this.рецептDataGridViewCheckBoxColumn.DataPropertyName = "Рецепт";
            this.рецептDataGridViewCheckBoxColumn.HeaderText = "Рецепт";
            this.рецептDataGridViewCheckBoxColumn.Name = "рецептDataGridViewCheckBoxColumn";
            // 
            // аналогDataGridViewTextBoxColumn
            // 
            this.аналогDataGridViewTextBoxColumn.DataPropertyName = "Аналог";
            this.аналогDataGridViewTextBoxColumn.HeaderText = "Аналог";
            this.аналогDataGridViewTextBoxColumn.Name = "аналогDataGridViewTextBoxColumn";
            // 
            // кількістьDataGridViewTextBoxColumn
            // 
            this.кількістьDataGridViewTextBoxColumn.DataPropertyName = "Кількість";
            this.кількістьDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.кількістьDataGridViewTextBoxColumn.Name = "кількістьDataGridViewTextBoxColumn";
            // 
            // позиціяDataGridViewTextBoxColumn
            // 
            this.позиціяDataGridViewTextBoxColumn.DataPropertyName = "Позиція";
            this.позиціяDataGridViewTextBoxColumn.HeaderText = "Позиція";
            this.позиціяDataGridViewTextBoxColumn.Name = "позиціяDataGridViewTextBoxColumn";
            // 
            // кодМорионаDataGridViewTextBoxColumn
            // 
            this.кодМорионаDataGridViewTextBoxColumn.DataPropertyName = "КодМориона";
            this.кодМорионаDataGridViewTextBoxColumn.HeaderText = "КодМориона";
            this.кодМорионаDataGridViewTextBoxColumn.Name = "кодМорионаDataGridViewTextBoxColumn";
            // 
            // GoodsForm
            // 
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "GoodsForm";
            this.Size = new System.Drawing.Size(853, 476);
            this.Load += new System.EventHandler(this.GoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товариBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource товариBindingSource;
        private DrugstoreDataSet drugstoreDataSet;
        private DrugstoreDataSetTableAdapters.ТовариTableAdapter товариTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ШтрихКодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn УпаковкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn одВимDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn мінЗапасDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ставкаНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn виробникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вхЦінаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вхЦінаБезНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn націнкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn цінаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn інформаціяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотоDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn можливістьПоверненняDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn рецептDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аналогDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn позиціяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодМорионаDataGridViewTextBoxColumn;
    }
}
