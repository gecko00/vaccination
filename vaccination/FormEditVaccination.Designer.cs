namespace vaccination
{
    partial class FormEditVaccination
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
            this.groupBoxVaccine = new System.Windows.Forms.GroupBox();
            this.numericUpDownRepetition = new System.Windows.Forms.NumericUpDown();
            this.checkBoxInCollege = new System.Windows.Forms.CheckBox();
            this.labelRepetition = new System.Windows.Forms.Label();
            this.dateTimePickerDateV = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerExpiration = new System.Windows.Forms.DateTimePicker();
            this.labelExpiration = new System.Windows.Forms.Label();
            this.textBoxControlNo = new System.Windows.Forms.TextBox();
            this.labelControlNo = new System.Windows.Forms.Label();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.labelSerial = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelVaccineType = new System.Windows.Forms.Label();
            this.comboBoxVaccineType = new System.Windows.Forms.ComboBox();
            this.referencevaccineTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medofficeDataSet = new vaccination.medofficeDataSet();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelBorn = new System.Windows.Forms.Label();
            this.labelGroupNo = new System.Windows.Forms.Label();
            this.labelPatronym = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.referenceStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.dataGridViewVaccination = new System.Windows.Forms.DataGridView();
            this.vaccinationKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccinationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineTypeKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineSerialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineControlNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineExpirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineRepetitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inCollegeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.operationalVaccinationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operational_VaccinationsTableAdapter = new vaccination.medofficeDataSetTableAdapters.operational_VaccinationsTableAdapter();
            this.reference_StudentsTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_StudentsTableAdapter();
            this.reference_vaccineTypesTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_vaccineTypesTableAdapter();
            this.groupBoxVaccine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepetition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencevaccineTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).BeginInit();
            this.groupBoxStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationalVaccinationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVaccine
            // 
            this.groupBoxVaccine.Controls.Add(this.numericUpDownRepetition);
            this.groupBoxVaccine.Controls.Add(this.checkBoxInCollege);
            this.groupBoxVaccine.Controls.Add(this.labelRepetition);
            this.groupBoxVaccine.Controls.Add(this.dateTimePickerDateV);
            this.groupBoxVaccine.Controls.Add(this.dateTimePickerExpiration);
            this.groupBoxVaccine.Controls.Add(this.labelExpiration);
            this.groupBoxVaccine.Controls.Add(this.textBoxControlNo);
            this.groupBoxVaccine.Controls.Add(this.labelControlNo);
            this.groupBoxVaccine.Controls.Add(this.textBoxSerial);
            this.groupBoxVaccine.Controls.Add(this.labelSerial);
            this.groupBoxVaccine.Controls.Add(this.labelDate);
            this.groupBoxVaccine.Controls.Add(this.labelVaccineType);
            this.groupBoxVaccine.Controls.Add(this.comboBoxVaccineType);
            this.groupBoxVaccine.Location = new System.Drawing.Point(282, 12);
            this.groupBoxVaccine.Name = "groupBoxVaccine";
            this.groupBoxVaccine.Size = new System.Drawing.Size(416, 127);
            this.groupBoxVaccine.TabIndex = 36;
            this.groupBoxVaccine.TabStop = false;
            this.groupBoxVaccine.Text = "Вакцина";
            // 
            // numericUpDownRepetition
            // 
            this.numericUpDownRepetition.Location = new System.Drawing.Point(361, 99);
            this.numericUpDownRepetition.Name = "numericUpDownRepetition";
            this.numericUpDownRepetition.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownRepetition.TabIndex = 19;
            // 
            // checkBoxInCollege
            // 
            this.checkBoxInCollege.AutoSize = true;
            this.checkBoxInCollege.Checked = true;
            this.checkBoxInCollege.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInCollege.Location = new System.Drawing.Point(278, 67);
            this.checkBoxInCollege.Name = "checkBoxInCollege";
            this.checkBoxInCollege.Size = new System.Drawing.Size(137, 17);
            this.checkBoxInCollege.TabIndex = 17;
            this.checkBoxInCollege.Text = "Проведена в СПбКИТ";
            this.checkBoxInCollege.UseVisualStyleBackColor = true;
            // 
            // labelRepetition
            // 
            this.labelRepetition.AutoSize = true;
            this.labelRepetition.Location = new System.Drawing.Point(275, 102);
            this.labelRepetition.Name = "labelRepetition";
            this.labelRepetition.Size = new System.Drawing.Size(63, 13);
            this.labelRepetition.TabIndex = 18;
            this.labelRepetition.Text = "Кратность:";
            // 
            // dateTimePickerDateV
            // 
            this.dateTimePickerDateV.Location = new System.Drawing.Point(278, 37);
            this.dateTimePickerDateV.Name = "dateTimePickerDateV";
            this.dateTimePickerDateV.Size = new System.Drawing.Size(132, 20);
            this.dateTimePickerDateV.TabIndex = 16;
            // 
            // dateTimePickerExpiration
            // 
            this.dateTimePickerExpiration.Location = new System.Drawing.Point(125, 99);
            this.dateTimePickerExpiration.Name = "dateTimePickerExpiration";
            this.dateTimePickerExpiration.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerExpiration.TabIndex = 15;
            // 
            // labelExpiration
            // 
            this.labelExpiration.AutoSize = true;
            this.labelExpiration.Location = new System.Drawing.Point(6, 102);
            this.labelExpiration.Name = "labelExpiration";
            this.labelExpiration.Size = new System.Drawing.Size(99, 13);
            this.labelExpiration.TabIndex = 14;
            this.labelExpiration.Text = "Срок годности до:";
            // 
            // textBoxControlNo
            // 
            this.textBoxControlNo.Location = new System.Drawing.Point(125, 73);
            this.textBoxControlNo.Name = "textBoxControlNo";
            this.textBoxControlNo.Size = new System.Drawing.Size(129, 20);
            this.textBoxControlNo.TabIndex = 13;
            // 
            // labelControlNo
            // 
            this.labelControlNo.AutoSize = true;
            this.labelControlNo.Location = new System.Drawing.Point(6, 76);
            this.labelControlNo.Name = "labelControlNo";
            this.labelControlNo.Size = new System.Drawing.Size(113, 13);
            this.labelControlNo.TabIndex = 12;
            this.labelControlNo.Text = "Контрольный номер:";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Location = new System.Drawing.Point(125, 46);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(129, 20);
            this.textBoxSerial.TabIndex = 11;
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Location = new System.Drawing.Point(6, 49);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(41, 13);
            this.labelSerial.TabIndex = 10;
            this.labelSerial.Text = "Серия:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(275, 22);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(99, 13);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Дата вакцинации:";
            // 
            // labelVaccineType
            // 
            this.labelVaccineType.AutoSize = true;
            this.labelVaccineType.Location = new System.Drawing.Point(6, 22);
            this.labelVaccineType.Name = "labelVaccineType";
            this.labelVaccineType.Size = new System.Drawing.Size(76, 13);
            this.labelVaccineType.TabIndex = 6;
            this.labelVaccineType.Text = "Вид вакцины:";
            // 
            // comboBoxVaccineType
            // 
            this.comboBoxVaccineType.DataSource = this.referencevaccineTypesBindingSource;
            this.comboBoxVaccineType.DisplayMember = "vaccineTypeName";
            this.comboBoxVaccineType.FormattingEnabled = true;
            this.comboBoxVaccineType.Location = new System.Drawing.Point(125, 19);
            this.comboBoxVaccineType.Name = "comboBoxVaccineType";
            this.comboBoxVaccineType.Size = new System.Drawing.Size(129, 21);
            this.comboBoxVaccineType.TabIndex = 5;
            this.comboBoxVaccineType.ValueMember = "vaccineTypeKEY";
            // 
            // referencevaccineTypesBindingSource
            // 
            this.referencevaccineTypesBindingSource.DataMember = "reference_vaccineTypes";
            this.referencevaccineTypesBindingSource.DataSource = this.medofficeDataSet;
            // 
            // medofficeDataSet
            // 
            this.medofficeDataSet.DataSetName = "medofficeDataSet";
            this.medofficeDataSet.Locale = new System.Globalization.CultureInfo("ru-RU");
            this.medofficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.labelBirthDate);
            this.groupBoxStudent.Controls.Add(this.labelBorn);
            this.groupBoxStudent.Controls.Add(this.labelGroupNo);
            this.groupBoxStudent.Controls.Add(this.labelPatronym);
            this.groupBoxStudent.Controls.Add(this.labelFirstName);
            this.groupBoxStudent.Controls.Add(this.labelLastName);
            this.groupBoxStudent.Controls.Add(this.buttonSearch);
            this.groupBoxStudent.Controls.Add(this.comboBoxStudent);
            this.groupBoxStudent.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(264, 127);
            this.groupBoxStudent.TabIndex = 35;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Студент";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(172, 61);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(61, 13);
            this.labelBirthDate.TabIndex = 7;
            this.labelBirthDate.Text = "00.00.0000";
            // 
            // labelBorn
            // 
            this.labelBorn.AutoSize = true;
            this.labelBorn.Location = new System.Drawing.Point(173, 43);
            this.labelBorn.Name = "labelBorn";
            this.labelBorn.Size = new System.Drawing.Size(89, 13);
            this.labelBorn.TabIndex = 6;
            this.labelBorn.Text = "Дата рождения:";
            // 
            // labelGroupNo
            // 
            this.labelGroupNo.AutoSize = true;
            this.labelGroupNo.Location = new System.Drawing.Point(75, 106);
            this.labelGroupNo.Name = "labelGroupNo";
            this.labelGroupNo.Size = new System.Drawing.Size(56, 13);
            this.labelGroupNo.TabIndex = 5;
            this.labelGroupNo.Text = "Группа №";
            // 
            // labelPatronym
            // 
            this.labelPatronym.AutoSize = true;
            this.labelPatronym.Location = new System.Drawing.Point(75, 78);
            this.labelPatronym.Name = "labelPatronym";
            this.labelPatronym.Size = new System.Drawing.Size(54, 13);
            this.labelPatronym.TabIndex = 4;
            this.labelPatronym.Text = "Отчество";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(75, 61);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "Имя";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(75, 43);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Фамилия";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(5, 43);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(63, 38);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Найти студента";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.DataSource = this.referenceStudentsBindingSource;
            this.comboBoxStudent.DisplayMember = "studentLastName";
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(6, 19);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(252, 21);
            this.comboBoxStudent.TabIndex = 0;
            this.comboBoxStudent.ValueMember = "studentKEY";
            this.comboBoxStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent_SelectedIndexChanged);
            // 
            // referenceStudentsBindingSource
            // 
            this.referenceStudentsBindingSource.DataMember = "reference_Students";
            this.referenceStudentsBindingSource.DataSource = this.medofficeDataSet;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::vaccination.Properties.Resources.decline;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(357, 145);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 27);
            this.buttonCancel.TabIndex = 36;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Image = global::vaccination.Properties.Resources.accept;
            this.buttonAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccept.Location = new System.Drawing.Point(151, 145);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(200, 27);
            this.buttonAccept.TabIndex = 35;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // dataGridViewVaccination
            // 
            this.dataGridViewVaccination.AllowUserToAddRows = false;
            this.dataGridViewVaccination.AllowUserToDeleteRows = false;
            this.dataGridViewVaccination.AutoGenerateColumns = false;
            this.dataGridViewVaccination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVaccination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vaccinationKEYDataGridViewTextBoxColumn,
            this.studentKEYDataGridViewTextBoxColumn,
            this.vaccinationDateDataGridViewTextBoxColumn,
            this.vaccineTypeKEYDataGridViewTextBoxColumn,
            this.vaccineSerialNumberDataGridViewTextBoxColumn,
            this.vaccineControlNumberDataGridViewTextBoxColumn,
            this.vaccineExpirationDateDataGridViewTextBoxColumn,
            this.vaccineRepetitionDataGridViewTextBoxColumn,
            this.inCollegeDataGridViewCheckBoxColumn});
            this.dataGridViewVaccination.DataSource = this.operationalVaccinationsBindingSource;
            this.dataGridViewVaccination.Location = new System.Drawing.Point(590, 145);
            this.dataGridViewVaccination.Name = "dataGridViewVaccination";
            this.dataGridViewVaccination.ReadOnly = true;
            this.dataGridViewVaccination.Size = new System.Drawing.Size(30, 27);
            this.dataGridViewVaccination.TabIndex = 8;
            this.dataGridViewVaccination.Visible = false;
            // 
            // vaccinationKEYDataGridViewTextBoxColumn
            // 
            this.vaccinationKEYDataGridViewTextBoxColumn.DataPropertyName = "vaccinationKEY";
            this.vaccinationKEYDataGridViewTextBoxColumn.HeaderText = "vaccinationKEY";
            this.vaccinationKEYDataGridViewTextBoxColumn.Name = "vaccinationKEYDataGridViewTextBoxColumn";
            this.vaccinationKEYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentKEYDataGridViewTextBoxColumn
            // 
            this.studentKEYDataGridViewTextBoxColumn.DataPropertyName = "studentKEY";
            this.studentKEYDataGridViewTextBoxColumn.HeaderText = "studentKEY";
            this.studentKEYDataGridViewTextBoxColumn.Name = "studentKEYDataGridViewTextBoxColumn";
            this.studentKEYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vaccinationDateDataGridViewTextBoxColumn
            // 
            this.vaccinationDateDataGridViewTextBoxColumn.DataPropertyName = "vaccinationDate";
            this.vaccinationDateDataGridViewTextBoxColumn.HeaderText = "vaccinationDate";
            this.vaccinationDateDataGridViewTextBoxColumn.Name = "vaccinationDateDataGridViewTextBoxColumn";
            this.vaccinationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vaccineTypeKEYDataGridViewTextBoxColumn
            // 
            this.vaccineTypeKEYDataGridViewTextBoxColumn.DataPropertyName = "vaccineTypeKEY";
            this.vaccineTypeKEYDataGridViewTextBoxColumn.HeaderText = "vaccineTypeKEY";
            this.vaccineTypeKEYDataGridViewTextBoxColumn.Name = "vaccineTypeKEYDataGridViewTextBoxColumn";
            this.vaccineTypeKEYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vaccineSerialNumberDataGridViewTextBoxColumn
            // 
            this.vaccineSerialNumberDataGridViewTextBoxColumn.DataPropertyName = "vaccineSerialNumber";
            this.vaccineSerialNumberDataGridViewTextBoxColumn.HeaderText = "vaccineSerialNumber";
            this.vaccineSerialNumberDataGridViewTextBoxColumn.Name = "vaccineSerialNumberDataGridViewTextBoxColumn";
            this.vaccineSerialNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vaccineControlNumberDataGridViewTextBoxColumn
            // 
            this.vaccineControlNumberDataGridViewTextBoxColumn.DataPropertyName = "vaccineControlNumber";
            this.vaccineControlNumberDataGridViewTextBoxColumn.HeaderText = "vaccineControlNumber";
            this.vaccineControlNumberDataGridViewTextBoxColumn.Name = "vaccineControlNumberDataGridViewTextBoxColumn";
            this.vaccineControlNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vaccineExpirationDateDataGridViewTextBoxColumn
            // 
            this.vaccineExpirationDateDataGridViewTextBoxColumn.DataPropertyName = "vaccineExpirationDate";
            this.vaccineExpirationDateDataGridViewTextBoxColumn.HeaderText = "vaccineExpirationDate";
            this.vaccineExpirationDateDataGridViewTextBoxColumn.Name = "vaccineExpirationDateDataGridViewTextBoxColumn";
            this.vaccineExpirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vaccineRepetitionDataGridViewTextBoxColumn
            // 
            this.vaccineRepetitionDataGridViewTextBoxColumn.DataPropertyName = "vaccineRepetition";
            this.vaccineRepetitionDataGridViewTextBoxColumn.HeaderText = "vaccineRepetition";
            this.vaccineRepetitionDataGridViewTextBoxColumn.Name = "vaccineRepetitionDataGridViewTextBoxColumn";
            this.vaccineRepetitionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inCollegeDataGridViewCheckBoxColumn
            // 
            this.inCollegeDataGridViewCheckBoxColumn.DataPropertyName = "inCollege";
            this.inCollegeDataGridViewCheckBoxColumn.HeaderText = "inCollege";
            this.inCollegeDataGridViewCheckBoxColumn.Name = "inCollegeDataGridViewCheckBoxColumn";
            this.inCollegeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // operationalVaccinationsBindingSource
            // 
            this.operationalVaccinationsBindingSource.DataMember = "operational_Vaccinations";
            this.operationalVaccinationsBindingSource.DataSource = this.medofficeDataSet;
            // 
            // operational_VaccinationsTableAdapter
            // 
            this.operational_VaccinationsTableAdapter.ClearBeforeFill = true;
            // 
            // reference_StudentsTableAdapter
            // 
            this.reference_StudentsTableAdapter.ClearBeforeFill = true;
            // 
            // reference_vaccineTypesTableAdapter
            // 
            this.reference_vaccineTypesTableAdapter.ClearBeforeFill = true;
            // 
            // FormEditVaccination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 184);
            this.Controls.Add(this.dataGridViewVaccination);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxVaccine);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.groupBoxStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEditVaccination";
            this.Text = "Добавление записи о вакцинации";
            this.Load += new System.EventHandler(this.FormEditVaccination_Load);
            this.groupBoxVaccine.ResumeLayout(false);
            this.groupBoxVaccine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepetition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencevaccineTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).EndInit();
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationalVaccinationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVaccine;
        private System.Windows.Forms.NumericUpDown numericUpDownRepetition;
        private System.Windows.Forms.CheckBox checkBoxInCollege;
        private System.Windows.Forms.Label labelRepetition;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateV;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiration;
        private System.Windows.Forms.Label labelExpiration;
        private System.Windows.Forms.TextBox textBoxControlNo;
        private System.Windows.Forms.Label labelControlNo;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelVaccineType;
        private System.Windows.Forms.ComboBox comboBoxVaccineType;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelBorn;
        private System.Windows.Forms.Label labelGroupNo;
        private System.Windows.Forms.Label labelPatronym;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.DataGridView dataGridViewVaccination;
        private medofficeDataSet medofficeDataSet;
        private System.Windows.Forms.BindingSource operationalVaccinationsBindingSource;
        private medofficeDataSetTableAdapters.operational_VaccinationsTableAdapter operational_VaccinationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccinationKEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentKEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccinationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineTypeKEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineSerialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineControlNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineExpirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineRepetitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inCollegeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource referenceStudentsBindingSource;
        private medofficeDataSetTableAdapters.reference_StudentsTableAdapter reference_StudentsTableAdapter;
        private System.Windows.Forms.BindingSource referencevaccineTypesBindingSource;
        private medofficeDataSetTableAdapters.reference_vaccineTypesTableAdapter reference_vaccineTypesTableAdapter;
    }
}