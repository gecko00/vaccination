namespace vaccination
{
    partial class FormVaccination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVaccination));
            this.dataGridViewVaccination = new System.Windows.Forms.DataGridView();
            this.vaccinationKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccinationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineSerialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineControlNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineExpirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineRepetitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inCollegeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.displayVaccinationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medofficeDataSet = new vaccination.medofficeDataSet();
            this.buttonRecordDelete = new System.Windows.Forms.Button();
            this.buttonRecordEdit = new System.Windows.Forms.Button();
            this.buttonRecordAdd = new System.Windows.Forms.Button();
            this.displayVaccinationsTableAdapter = new vaccination.medofficeDataSetTableAdapters.displayVaccinationsTableAdapter();
            this.buttonDataSetFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayVaccinationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVaccination
            // 
            this.dataGridViewVaccination.AllowUserToAddRows = false;
            this.dataGridViewVaccination.AllowUserToDeleteRows = false;
            this.dataGridViewVaccination.AutoGenerateColumns = false;
            this.dataGridViewVaccination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVaccination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vaccinationKEYDataGridViewTextBoxColumn,
            this.vaccinationDateDataGridViewTextBoxColumn,
            this.vaccineTypeNameDataGridViewTextBoxColumn,
            this.studentLastNameDataGridViewTextBoxColumn,
            this.studentFirstNameDataGridViewTextBoxColumn,
            this.groupNoDataGridViewTextBoxColumn,
            this.vaccineSerialNumberDataGridViewTextBoxColumn,
            this.vaccineControlNumberDataGridViewTextBoxColumn,
            this.vaccineExpirationDateDataGridViewTextBoxColumn,
            this.vaccineRepetitionDataGridViewTextBoxColumn,
            this.inCollegeDataGridViewCheckBoxColumn});
            this.dataGridViewVaccination.DataSource = this.displayVaccinationsBindingSource;
            this.dataGridViewVaccination.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVaccination.Name = "dataGridViewVaccination";
            this.dataGridViewVaccination.ReadOnly = true;
            this.dataGridViewVaccination.Size = new System.Drawing.Size(845, 285);
            this.dataGridViewVaccination.TabIndex = 0;
            // 
            // vaccinationKEYDataGridViewTextBoxColumn
            // 
            this.vaccinationKEYDataGridViewTextBoxColumn.DataPropertyName = "vaccinationKEY";
            this.vaccinationKEYDataGridViewTextBoxColumn.HeaderText = "Код";
            this.vaccinationKEYDataGridViewTextBoxColumn.Name = "vaccinationKEYDataGridViewTextBoxColumn";
            this.vaccinationKEYDataGridViewTextBoxColumn.ReadOnly = true;
            this.vaccinationKEYDataGridViewTextBoxColumn.Width = 70;
            // 
            // vaccinationDateDataGridViewTextBoxColumn
            // 
            this.vaccinationDateDataGridViewTextBoxColumn.DataPropertyName = "vaccinationDate";
            this.vaccinationDateDataGridViewTextBoxColumn.HeaderText = "Дата ";
            this.vaccinationDateDataGridViewTextBoxColumn.Name = "vaccinationDateDataGridViewTextBoxColumn";
            this.vaccinationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.vaccinationDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // vaccineTypeNameDataGridViewTextBoxColumn
            // 
            this.vaccineTypeNameDataGridViewTextBoxColumn.DataPropertyName = "vaccineTypeName";
            this.vaccineTypeNameDataGridViewTextBoxColumn.HeaderText = "Вакцина";
            this.vaccineTypeNameDataGridViewTextBoxColumn.Name = "vaccineTypeNameDataGridViewTextBoxColumn";
            this.vaccineTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentLastNameDataGridViewTextBoxColumn
            // 
            this.studentLastNameDataGridViewTextBoxColumn.DataPropertyName = "studentLastName";
            this.studentLastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.studentLastNameDataGridViewTextBoxColumn.Name = "studentLastNameDataGridViewTextBoxColumn";
            this.studentLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentLastNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // studentFirstNameDataGridViewTextBoxColumn
            // 
            this.studentFirstNameDataGridViewTextBoxColumn.DataPropertyName = "studentFirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.studentFirstNameDataGridViewTextBoxColumn.Name = "studentFirstNameDataGridViewTextBoxColumn";
            this.studentFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupNoDataGridViewTextBoxColumn
            // 
            this.groupNoDataGridViewTextBoxColumn.DataPropertyName = "groupNo";
            this.groupNoDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupNoDataGridViewTextBoxColumn.Name = "groupNoDataGridViewTextBoxColumn";
            this.groupNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupNoDataGridViewTextBoxColumn.Width = 60;
            // 
            // vaccineSerialNumberDataGridViewTextBoxColumn
            // 
            this.vaccineSerialNumberDataGridViewTextBoxColumn.DataPropertyName = "vaccineSerialNumber";
            this.vaccineSerialNumberDataGridViewTextBoxColumn.HeaderText = "Серия";
            this.vaccineSerialNumberDataGridViewTextBoxColumn.Name = "vaccineSerialNumberDataGridViewTextBoxColumn";
            this.vaccineSerialNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vaccineControlNumberDataGridViewTextBoxColumn
            // 
            this.vaccineControlNumberDataGridViewTextBoxColumn.DataPropertyName = "vaccineControlNumber";
            this.vaccineControlNumberDataGridViewTextBoxColumn.HeaderText = "Контр. номер";
            this.vaccineControlNumberDataGridViewTextBoxColumn.Name = "vaccineControlNumberDataGridViewTextBoxColumn";
            this.vaccineControlNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vaccineExpirationDateDataGridViewTextBoxColumn
            // 
            this.vaccineExpirationDateDataGridViewTextBoxColumn.DataPropertyName = "vaccineExpirationDate";
            this.vaccineExpirationDateDataGridViewTextBoxColumn.HeaderText = "Срок годн.";
            this.vaccineExpirationDateDataGridViewTextBoxColumn.Name = "vaccineExpirationDateDataGridViewTextBoxColumn";
            this.vaccineExpirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vaccineRepetitionDataGridViewTextBoxColumn
            // 
            this.vaccineRepetitionDataGridViewTextBoxColumn.DataPropertyName = "vaccineRepetition";
            this.vaccineRepetitionDataGridViewTextBoxColumn.HeaderText = "Кратность";
            this.vaccineRepetitionDataGridViewTextBoxColumn.Name = "vaccineRepetitionDataGridViewTextBoxColumn";
            this.vaccineRepetitionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inCollegeDataGridViewCheckBoxColumn
            // 
            this.inCollegeDataGridViewCheckBoxColumn.DataPropertyName = "inCollege";
            this.inCollegeDataGridViewCheckBoxColumn.HeaderText = "В колледже";
            this.inCollegeDataGridViewCheckBoxColumn.Name = "inCollegeDataGridViewCheckBoxColumn";
            this.inCollegeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // displayVaccinationsBindingSource
            // 
            this.displayVaccinationsBindingSource.DataMember = "displayVaccinations";
            this.displayVaccinationsBindingSource.DataSource = this.medofficeDataSet;
            // 
            // medofficeDataSet
            // 
            this.medofficeDataSet.DataSetName = "medofficeDataSet";
            this.medofficeDataSet.Locale = new System.Globalization.CultureInfo("ru-RU");
            this.medofficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonRecordDelete
            // 
            this.buttonRecordDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonRecordDelete.Image")));
            this.buttonRecordDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecordDelete.Location = new System.Drawing.Point(437, 303);
            this.buttonRecordDelete.Name = "buttonRecordDelete";
            this.buttonRecordDelete.Size = new System.Drawing.Size(200, 26);
            this.buttonRecordDelete.TabIndex = 27;
            this.buttonRecordDelete.Text = "Удалить";
            this.buttonRecordDelete.UseVisualStyleBackColor = true;
            this.buttonRecordDelete.Click += new System.EventHandler(this.buttonRecordDelete_Click);
            // 
            // buttonRecordEdit
            // 
            this.buttonRecordEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonRecordEdit.Image")));
            this.buttonRecordEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecordEdit.Location = new System.Drawing.Point(231, 303);
            this.buttonRecordEdit.Name = "buttonRecordEdit";
            this.buttonRecordEdit.Size = new System.Drawing.Size(200, 26);
            this.buttonRecordEdit.TabIndex = 25;
            this.buttonRecordEdit.Text = "Редактировать";
            this.buttonRecordEdit.UseVisualStyleBackColor = true;
            this.buttonRecordEdit.Click += new System.EventHandler(this.buttonRecordEdit_Click);
            // 
            // buttonRecordAdd
            // 
            this.buttonRecordAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonRecordAdd.Image")));
            this.buttonRecordAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecordAdd.Location = new System.Drawing.Point(25, 303);
            this.buttonRecordAdd.Name = "buttonRecordAdd";
            this.buttonRecordAdd.Size = new System.Drawing.Size(200, 26);
            this.buttonRecordAdd.TabIndex = 24;
            this.buttonRecordAdd.Text = "Добавить";
            this.buttonRecordAdd.UseVisualStyleBackColor = true;
            this.buttonRecordAdd.Click += new System.EventHandler(this.buttonRecordAdd_Click);
            // 
            // displayVaccinationsTableAdapter
            // 
            this.displayVaccinationsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonDataSetFilter
            // 
            this.buttonDataSetFilter.Image = global::vaccination.Properties.Resources.filter;
            this.buttonDataSetFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDataSetFilter.Location = new System.Drawing.Point(643, 303);
            this.buttonDataSetFilter.Name = "buttonDataSetFilter";
            this.buttonDataSetFilter.Size = new System.Drawing.Size(200, 26);
            this.buttonDataSetFilter.TabIndex = 37;
            this.buttonDataSetFilter.Text = "Найти";
            this.buttonDataSetFilter.UseVisualStyleBackColor = true;
            this.buttonDataSetFilter.Click += new System.EventHandler(this.buttonDataSetFilter_Click);
            // 
            // FormVaccination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 335);
            this.Controls.Add(this.buttonDataSetFilter);
            this.Controls.Add(this.buttonRecordDelete);
            this.Controls.Add(this.buttonRecordEdit);
            this.Controls.Add(this.buttonRecordAdd);
            this.Controls.Add(this.dataGridViewVaccination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormVaccination";
            this.Text = "Вакцинация";
            this.Load += new System.EventHandler(this.FormVaccination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayVaccinationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVaccination;
        private System.Windows.Forms.Button buttonRecordDelete;
        private System.Windows.Forms.Button buttonRecordEdit;
        private System.Windows.Forms.Button buttonRecordAdd;
        private medofficeDataSet medofficeDataSet;
        private System.Windows.Forms.BindingSource displayVaccinationsBindingSource;
        private medofficeDataSetTableAdapters.displayVaccinationsTableAdapter displayVaccinationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccinationKEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccinationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineSerialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineControlNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineExpirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineRepetitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inCollegeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button buttonDataSetFilter;
    }
}