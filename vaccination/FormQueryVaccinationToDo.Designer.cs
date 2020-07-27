namespace vaccination
{
    partial class FormQueryVaccinationToDo
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
            this.queryVaccinationToDoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medofficeDataSet = new vaccination.medofficeDataSet();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.referencevaccineTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFind = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.reference_vaccineTypesTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_vaccineTypesTableAdapter();
            this.query_VaccinationToDoTableAdapter = new vaccination.medofficeDataSetTableAdapters.query_VaccinationToDoTableAdapter();
            this.dataGridViewQuery = new System.Windows.Forms.DataGridView();
            this.studentKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPatronymDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.queryVaccinationToDoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencevaccineTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // queryVaccinationToDoBindingSource
            // 
            this.queryVaccinationToDoBindingSource.DataMember = "query_VaccinationToDo";
            this.queryVaccinationToDoBindingSource.DataSource = this.medofficeDataSet;
            // 
            // medofficeDataSet
            // 
            this.medofficeDataSet.DataSetName = "medofficeDataSet";
            this.medofficeDataSet.Locale = new System.Globalization.CultureInfo("ru-RU");
            this.medofficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(345, 447);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerEnd.TabIndex = 5;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(345, 401);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerStart.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.referencevaccineTypesBindingSource;
            this.listBox1.DisplayMember = "vaccineTypeName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(46, 384);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 82);
            this.listBox1.TabIndex = 3;
            this.listBox1.ValueMember = "vaccineTypeKEY";
            // 
            // referencevaccineTypesBindingSource
            // 
            this.referencevaccineTypesBindingSource.DataMember = "reference_vaccineTypes";
            this.referencevaccineTypesBindingSource.DataSource = this.medofficeDataSet;
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(43, 368);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(254, 13);
            this.labelFind.TabIndex = 6;
            this.labelFind.Text = "Найти студентов, которые не сделали прививку:";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(382, 368);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(58, 13);
            this.labelPeriod.TabIndex = 7;
            this.labelPeriod.Text = "за период";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(324, 405);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(14, 13);
            this.labelStart.TabIndex = 8;
            this.labelStart.Text = "С";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(324, 449);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(19, 13);
            this.labelEnd.TabIndex = 9;
            this.labelEnd.Text = "по";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(545, 401);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(153, 38);
            this.buttonShow.TabIndex = 10;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // reference_vaccineTypesTableAdapter
            // 
            this.reference_vaccineTypesTableAdapter.ClearBeforeFill = true;
            // 
            // query_VaccinationToDoTableAdapter
            // 
            this.query_VaccinationToDoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewQuery
            // 
            this.dataGridViewQuery.AllowUserToAddRows = false;
            this.dataGridViewQuery.AllowUserToDeleteRows = false;
            this.dataGridViewQuery.AutoGenerateColumns = false;
            this.dataGridViewQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentKEYDataGridViewTextBoxColumn,
            this.studentLastNameDataGridViewTextBoxColumn,
            this.studentFirstNameDataGridViewTextBoxColumn,
            this.studentPatronymDataGridViewTextBoxColumn,
            this.groupNoDataGridViewTextBoxColumn});
            this.dataGridViewQuery.DataSource = this.queryVaccinationToDoBindingSource;
            this.dataGridViewQuery.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewQuery.Name = "dataGridViewQuery";
            this.dataGridViewQuery.ReadOnly = true;
            this.dataGridViewQuery.Size = new System.Drawing.Size(717, 353);
            this.dataGridViewQuery.TabIndex = 11;
            // 
            // studentKEYDataGridViewTextBoxColumn
            // 
            this.studentKEYDataGridViewTextBoxColumn.DataPropertyName = "studentKEY";
            this.studentKEYDataGridViewTextBoxColumn.HeaderText = "Код";
            this.studentKEYDataGridViewTextBoxColumn.Name = "studentKEYDataGridViewTextBoxColumn";
            this.studentKEYDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentKEYDataGridViewTextBoxColumn.Width = 70;
            // 
            // studentLastNameDataGridViewTextBoxColumn
            // 
            this.studentLastNameDataGridViewTextBoxColumn.DataPropertyName = "studentLastName";
            this.studentLastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.studentLastNameDataGridViewTextBoxColumn.Name = "studentLastNameDataGridViewTextBoxColumn";
            this.studentLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentLastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // studentFirstNameDataGridViewTextBoxColumn
            // 
            this.studentFirstNameDataGridViewTextBoxColumn.DataPropertyName = "studentFirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.studentFirstNameDataGridViewTextBoxColumn.Name = "studentFirstNameDataGridViewTextBoxColumn";
            this.studentFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentFirstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentPatronymDataGridViewTextBoxColumn
            // 
            this.studentPatronymDataGridViewTextBoxColumn.DataPropertyName = "studentPatronym";
            this.studentPatronymDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.studentPatronymDataGridViewTextBoxColumn.Name = "studentPatronymDataGridViewTextBoxColumn";
            this.studentPatronymDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentPatronymDataGridViewTextBoxColumn.Width = 150;
            // 
            // groupNoDataGridViewTextBoxColumn
            // 
            this.groupNoDataGridViewTextBoxColumn.DataPropertyName = "groupNo";
            this.groupNoDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupNoDataGridViewTextBoxColumn.Name = "groupNoDataGridViewTextBoxColumn";
            this.groupNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormQueryVaccinationToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 481);
            this.Controls.Add(this.dataGridViewQuery);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.listBox1);
            this.Name = "FormQueryVaccinationToDo";
            this.Text = "Поиск студентов не прошедших вакцинацию";
            this.Load += new System.EventHandler(this.FormQueryVaccinationToDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.queryVaccinationToDoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencevaccineTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private medofficeDataSet medofficeDataSet;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.BindingSource referencevaccineTypesBindingSource;
        private medofficeDataSetTableAdapters.reference_vaccineTypesTableAdapter reference_vaccineTypesTableAdapter;
        private System.Windows.Forms.BindingSource queryVaccinationToDoBindingSource;
        private medofficeDataSetTableAdapters.query_VaccinationToDoTableAdapter query_VaccinationToDoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentKEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPatronymDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNoDataGridViewTextBoxColumn;
    }
}