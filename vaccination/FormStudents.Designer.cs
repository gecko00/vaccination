namespace vaccination
{
    partial class FormStudents
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
            this.buttonRecordDelete = new System.Windows.Forms.Button();
            this.buttonDataSetFilter = new System.Windows.Forms.Button();
            this.buttonRecordEdit = new System.Windows.Forms.Button();
            this.buttonRecordAdd = new System.Windows.Forms.Button();
            this.labelPElimitations = new System.Windows.Forms.Label();
            this.textBoxPElimitations = new System.Windows.Forms.TextBox();
            this.textBoxSchool = new System.Windows.Forms.TextBox();
            this.labelSchool = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.groupBoxPersonalData = new System.Windows.Forms.GroupBox();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.studentKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPatronymDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentStatusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicalEducationHealthGroupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicalEducationLimitationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSchoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medofficeDataSet = new vaccination.medofficeDataSet();
            this.displayStudentsTableAdapter = new vaccination.medofficeDataSetTableAdapters.displayStudentsTableAdapter();
            this.groupBoxPersonalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRecordDelete
            // 
            this.buttonRecordDelete.Image = global::vaccination.Properties.Resources.delete;
            this.buttonRecordDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecordDelete.Location = new System.Drawing.Point(439, 353);
            this.buttonRecordDelete.Name = "buttonRecordDelete";
            this.buttonRecordDelete.Size = new System.Drawing.Size(200, 27);
            this.buttonRecordDelete.TabIndex = 37;
            this.buttonRecordDelete.Text = "Удалить";
            this.buttonRecordDelete.UseVisualStyleBackColor = true;
            this.buttonRecordDelete.Click += new System.EventHandler(this.buttonRecordDelete_Click);
            // 
            // buttonDataSetFilter
            // 
            this.buttonDataSetFilter.Image = global::vaccination.Properties.Resources.filter;
            this.buttonDataSetFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDataSetFilter.Location = new System.Drawing.Point(645, 353);
            this.buttonDataSetFilter.Name = "buttonDataSetFilter";
            this.buttonDataSetFilter.Size = new System.Drawing.Size(200, 27);
            this.buttonDataSetFilter.TabIndex = 36;
            this.buttonDataSetFilter.Text = "Найти";
            this.buttonDataSetFilter.UseVisualStyleBackColor = true;
            this.buttonDataSetFilter.Click += new System.EventHandler(this.buttonDataSetFilter_Click);
            // 
            // buttonRecordEdit
            // 
            this.buttonRecordEdit.Image = global::vaccination.Properties.Resources.edit;
            this.buttonRecordEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecordEdit.Location = new System.Drawing.Point(233, 353);
            this.buttonRecordEdit.Name = "buttonRecordEdit";
            this.buttonRecordEdit.Size = new System.Drawing.Size(200, 27);
            this.buttonRecordEdit.TabIndex = 35;
            this.buttonRecordEdit.Text = "Редактировать";
            this.buttonRecordEdit.UseVisualStyleBackColor = true;
            this.buttonRecordEdit.Click += new System.EventHandler(this.buttonRecordEdit_Click);
            // 
            // buttonRecordAdd
            // 
            this.buttonRecordAdd.Image = global::vaccination.Properties.Resources.add;
            this.buttonRecordAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecordAdd.Location = new System.Drawing.Point(27, 353);
            this.buttonRecordAdd.Name = "buttonRecordAdd";
            this.buttonRecordAdd.Size = new System.Drawing.Size(200, 27);
            this.buttonRecordAdd.TabIndex = 34;
            this.buttonRecordAdd.Text = "Добавить";
            this.buttonRecordAdd.UseVisualStyleBackColor = true;
            this.buttonRecordAdd.Click += new System.EventHandler(this.buttonRecordAdd_Click);
            // 
            // labelPElimitations
            // 
            this.labelPElimitations.AutoSize = true;
            this.labelPElimitations.Location = new System.Drawing.Point(423, 19);
            this.labelPElimitations.Name = "labelPElimitations";
            this.labelPElimitations.Size = new System.Drawing.Size(159, 13);
            this.labelPElimitations.TabIndex = 8;
            this.labelPElimitations.Text = "Ограничения по физкультуре:";
            // 
            // textBoxPElimitations
            // 
            this.textBoxPElimitations.Location = new System.Drawing.Point(111, 68);
            this.textBoxPElimitations.Multiline = true;
            this.textBoxPElimitations.Name = "textBoxPElimitations";
            this.textBoxPElimitations.Size = new System.Drawing.Size(299, 20);
            this.textBoxPElimitations.TabIndex = 9;
            // 
            // textBoxSchool
            // 
            this.textBoxSchool.Location = new System.Drawing.Point(588, 16);
            this.textBoxSchool.Multiline = true;
            this.textBoxSchool.Name = "textBoxSchool";
            this.textBoxSchool.Size = new System.Drawing.Size(245, 72);
            this.textBoxSchool.TabIndex = 8;
            // 
            // labelSchool
            // 
            this.labelSchool.AutoSize = true;
            this.labelSchool.Location = new System.Drawing.Point(12, 70);
            this.labelSchool.Name = "labelSchool";
            this.labelSchool.Size = new System.Drawing.Size(94, 13);
            this.labelSchool.TabIndex = 9;
            this.labelSchool.Text = "Окончена школа:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(11, 23);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(41, 13);
            this.labelAddress.TabIndex = 10;
            this.labelAddress.Text = "Адрес:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(111, 19);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(299, 43);
            this.textBoxAddress.TabIndex = 11;
            // 
            // groupBoxPersonalData
            // 
            this.groupBoxPersonalData.Controls.Add(this.textBoxPElimitations);
            this.groupBoxPersonalData.Controls.Add(this.textBoxAddress);
            this.groupBoxPersonalData.Controls.Add(this.labelPElimitations);
            this.groupBoxPersonalData.Controls.Add(this.labelAddress);
            this.groupBoxPersonalData.Controls.Add(this.labelSchool);
            this.groupBoxPersonalData.Controls.Add(this.textBoxSchool);
            this.groupBoxPersonalData.Enabled = false;
            this.groupBoxPersonalData.Location = new System.Drawing.Point(12, 386);
            this.groupBoxPersonalData.Name = "groupBoxPersonalData";
            this.groupBoxPersonalData.Size = new System.Drawing.Size(845, 92);
            this.groupBoxPersonalData.TabIndex = 38;
            this.groupBoxPersonalData.TabStop = false;
            this.groupBoxPersonalData.Text = "Личные данные студента";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.AutoGenerateColumns = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentKEYDataGridViewTextBoxColumn,
            this.studentLastNameDataGridViewTextBoxColumn,
            this.studentFirstNameDataGridViewTextBoxColumn,
            this.studentPatronymDataGridViewTextBoxColumn,
            this.groupNoDataGridViewTextBoxColumn,
            this.studentStatusNameDataGridViewTextBoxColumn,
            this.studentBirthDateDataGridViewTextBoxColumn,
            this.physicalEducationHealthGroupNameDataGridViewTextBoxColumn,
            this.physicalEducationLimitationsDataGridViewTextBoxColumn,
            this.studentAddressDataGridViewTextBoxColumn,
            this.studentSchoolDataGridViewTextBoxColumn});
            this.dataGridViewStudents.DataSource = this.displayStudentsBindingSource;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.Size = new System.Drawing.Size(845, 335);
            this.dataGridViewStudents.TabIndex = 39;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            // 
            // studentKEYDataGridViewTextBoxColumn
            // 
            this.studentKEYDataGridViewTextBoxColumn.DataPropertyName = "studentKEY";
            this.studentKEYDataGridViewTextBoxColumn.HeaderText = "Код";
            this.studentKEYDataGridViewTextBoxColumn.Name = "studentKEYDataGridViewTextBoxColumn";
            this.studentKEYDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentKEYDataGridViewTextBoxColumn.Width = 60;
            // 
            // studentLastNameDataGridViewTextBoxColumn
            // 
            this.studentLastNameDataGridViewTextBoxColumn.DataPropertyName = "studentLastName";
            this.studentLastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.studentLastNameDataGridViewTextBoxColumn.Name = "studentLastNameDataGridViewTextBoxColumn";
            this.studentLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentLastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentFirstNameDataGridViewTextBoxColumn
            // 
            this.studentFirstNameDataGridViewTextBoxColumn.DataPropertyName = "studentFirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.studentFirstNameDataGridViewTextBoxColumn.Name = "studentFirstNameDataGridViewTextBoxColumn";
            this.studentFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentPatronymDataGridViewTextBoxColumn
            // 
            this.studentPatronymDataGridViewTextBoxColumn.DataPropertyName = "studentPatronym";
            this.studentPatronymDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.studentPatronymDataGridViewTextBoxColumn.Name = "studentPatronymDataGridViewTextBoxColumn";
            this.studentPatronymDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentPatronymDataGridViewTextBoxColumn.Width = 110;
            // 
            // groupNoDataGridViewTextBoxColumn
            // 
            this.groupNoDataGridViewTextBoxColumn.DataPropertyName = "groupNo";
            this.groupNoDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupNoDataGridViewTextBoxColumn.Name = "groupNoDataGridViewTextBoxColumn";
            this.groupNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupNoDataGridViewTextBoxColumn.Width = 60;
            // 
            // studentStatusNameDataGridViewTextBoxColumn
            // 
            this.studentStatusNameDataGridViewTextBoxColumn.DataPropertyName = "studentStatusName";
            this.studentStatusNameDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.studentStatusNameDataGridViewTextBoxColumn.Name = "studentStatusNameDataGridViewTextBoxColumn";
            this.studentStatusNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBirthDateDataGridViewTextBoxColumn
            // 
            this.studentBirthDateDataGridViewTextBoxColumn.DataPropertyName = "studentBirthDate";
            this.studentBirthDateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.studentBirthDateDataGridViewTextBoxColumn.Name = "studentBirthDateDataGridViewTextBoxColumn";
            this.studentBirthDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentBirthDateDataGridViewTextBoxColumn.Width = 115;
            // 
            // physicalEducationHealthGroupNameDataGridViewTextBoxColumn
            // 
            this.physicalEducationHealthGroupNameDataGridViewTextBoxColumn.DataPropertyName = "physicalEducationHealthGroupName";
            this.physicalEducationHealthGroupNameDataGridViewTextBoxColumn.HeaderText = "Группа физ-ры";
            this.physicalEducationHealthGroupNameDataGridViewTextBoxColumn.Name = "physicalEducationHealthGroupNameDataGridViewTextBoxColumn";
            this.physicalEducationHealthGroupNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.physicalEducationHealthGroupNameDataGridViewTextBoxColumn.Width = 105;
            // 
            // physicalEducationLimitationsDataGridViewTextBoxColumn
            // 
            this.physicalEducationLimitationsDataGridViewTextBoxColumn.DataPropertyName = "physicalEducationLimitations";
            this.physicalEducationLimitationsDataGridViewTextBoxColumn.HeaderText = "physicalEducationLimitations";
            this.physicalEducationLimitationsDataGridViewTextBoxColumn.Name = "physicalEducationLimitationsDataGridViewTextBoxColumn";
            this.physicalEducationLimitationsDataGridViewTextBoxColumn.ReadOnly = true;
            this.physicalEducationLimitationsDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentAddressDataGridViewTextBoxColumn
            // 
            this.studentAddressDataGridViewTextBoxColumn.DataPropertyName = "studentAddress";
            this.studentAddressDataGridViewTextBoxColumn.HeaderText = "studentAddress";
            this.studentAddressDataGridViewTextBoxColumn.Name = "studentAddressDataGridViewTextBoxColumn";
            this.studentAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentSchoolDataGridViewTextBoxColumn
            // 
            this.studentSchoolDataGridViewTextBoxColumn.DataPropertyName = "studentSchool";
            this.studentSchoolDataGridViewTextBoxColumn.HeaderText = "studentSchool";
            this.studentSchoolDataGridViewTextBoxColumn.Name = "studentSchoolDataGridViewTextBoxColumn";
            this.studentSchoolDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentSchoolDataGridViewTextBoxColumn.Visible = false;
            // 
            // displayStudentsBindingSource
            // 
            this.displayStudentsBindingSource.DataMember = "displayStudents";
            this.displayStudentsBindingSource.DataSource = this.medofficeDataSet;
            // 
            // medofficeDataSet
            // 
            this.medofficeDataSet.DataSetName = "medofficeDataSet";
            this.medofficeDataSet.Locale = new System.Globalization.CultureInfo("ru-RU");
            this.medofficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // displayStudentsTableAdapter
            // 
            this.displayStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 481);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.groupBoxPersonalData);
            this.Controls.Add(this.buttonRecordDelete);
            this.Controls.Add(this.buttonDataSetFilter);
            this.Controls.Add(this.buttonRecordEdit);
            this.Controls.Add(this.buttonRecordAdd);
            this.Name = "FormStudents";
            this.Text = "Справочник: студенты";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            this.groupBoxPersonalData.ResumeLayout(false);
            this.groupBoxPersonalData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRecordDelete;
        private System.Windows.Forms.Button buttonDataSetFilter;
        private System.Windows.Forms.Button buttonRecordEdit;
        private System.Windows.Forms.Button buttonRecordAdd;
        private System.Windows.Forms.Label labelPElimitations;
        private System.Windows.Forms.TextBox textBoxPElimitations;
        private System.Windows.Forms.TextBox textBoxSchool;
        private System.Windows.Forms.Label labelSchool;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.GroupBox groupBoxPersonalData;
        private medofficeDataSet medofficeDataSet;
        private System.Windows.Forms.BindingSource displayStudentsBindingSource;
        private medofficeDataSetTableAdapters.displayStudentsTableAdapter displayStudentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentKEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPatronymDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentStatusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicalEducationHealthGroupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicalEducationLimitationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSchoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
    }
}