namespace vaccination
{
    partial class FormEditStudents
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
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.textBoxPElimitations = new System.Windows.Forms.TextBox();
            this.labelPElimitations = new System.Windows.Forms.Label();
            this.labelPEGroup = new System.Windows.Forms.Label();
            this.comboBoxPEgroup = new System.Windows.Forms.ComboBox();
            this.referencephysicalEducationHealthGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medofficeDataSet = new vaccination.medofficeDataSet();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.referencestudentStatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxPersonalData = new System.Windows.Forms.GroupBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelSchool = new System.Windows.Forms.Label();
            this.textBoxSchool = new System.Windows.Forms.TextBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.buttonGroupFilter = new System.Windows.Forms.Button();
            this.labelPatronym = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.referenceGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxPatronym = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.reference_physicalEducationHealthGroupsTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_physicalEducationHealthGroupsTableAdapter();
            this.reference_studentStatusesTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_studentStatusesTableAdapter();
            this.reference_GroupsTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_GroupsTableAdapter();
            this.referenceStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reference_StudentsTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_StudentsTableAdapter();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.studentKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPatronymDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSchoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentStatusKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicalEducationHealthGroupKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicalEducationLimitationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referencephysicalEducationHealthGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencestudentStatusesBindingSource)).BeginInit();
            this.groupBoxPersonalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.textBoxPElimitations);
            this.groupBoxInformation.Controls.Add(this.labelPElimitations);
            this.groupBoxInformation.Controls.Add(this.labelPEGroup);
            this.groupBoxInformation.Controls.Add(this.comboBoxPEgroup);
            this.groupBoxInformation.Controls.Add(this.labelStatus);
            this.groupBoxInformation.Controls.Add(this.comboBoxStatus);
            this.groupBoxInformation.Location = new System.Drawing.Point(479, 12);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(219, 127);
            this.groupBoxInformation.TabIndex = 32;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Сведения";
            // 
            // textBoxPElimitations
            // 
            this.textBoxPElimitations.Location = new System.Drawing.Point(9, 97);
            this.textBoxPElimitations.Multiline = true;
            this.textBoxPElimitations.Name = "textBoxPElimitations";
            this.textBoxPElimitations.Size = new System.Drawing.Size(204, 20);
            this.textBoxPElimitations.TabIndex = 9;
            // 
            // labelPElimitations
            // 
            this.labelPElimitations.AutoSize = true;
            this.labelPElimitations.Location = new System.Drawing.Point(6, 81);
            this.labelPElimitations.Name = "labelPElimitations";
            this.labelPElimitations.Size = new System.Drawing.Size(159, 13);
            this.labelPElimitations.TabIndex = 8;
            this.labelPElimitations.Text = "Ограничения по физкультуре:";
            // 
            // labelPEGroup
            // 
            this.labelPEGroup.AutoSize = true;
            this.labelPEGroup.Location = new System.Drawing.Point(6, 48);
            this.labelPEGroup.Name = "labelPEGroup";
            this.labelPEGroup.Size = new System.Drawing.Size(115, 13);
            this.labelPEGroup.TabIndex = 6;
            this.labelPEGroup.Text = "Группа физкультуры:";
            // 
            // comboBoxPEgroup
            // 
            this.comboBoxPEgroup.DataSource = this.referencephysicalEducationHealthGroupsBindingSource;
            this.comboBoxPEgroup.DisplayMember = "physicalEducationHealthGroupName";
            this.comboBoxPEgroup.FormattingEnabled = true;
            this.comboBoxPEgroup.Location = new System.Drawing.Point(127, 44);
            this.comboBoxPEgroup.Name = "comboBoxPEgroup";
            this.comboBoxPEgroup.Size = new System.Drawing.Size(86, 21);
            this.comboBoxPEgroup.TabIndex = 5;
            this.comboBoxPEgroup.ValueMember = "physicalEducationHealthGroupKEY";
            // 
            // referencephysicalEducationHealthGroupsBindingSource
            // 
            this.referencephysicalEducationHealthGroupsBindingSource.DataMember = "reference_physicalEducationHealthGroups";
            this.referencephysicalEducationHealthGroupsBindingSource.DataSource = this.medofficeDataSet;
            // 
            // medofficeDataSet
            // 
            this.medofficeDataSet.DataSetName = "medofficeDataSet";
            this.medofficeDataSet.Locale = new System.Globalization.CultureInfo("ru-RU");
            this.medofficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(6, 22);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Статус:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DataSource = this.referencestudentStatusesBindingSource;
            this.comboBoxStatus.DisplayMember = "studentStatusName";
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(54, 19);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(159, 21);
            this.comboBoxStatus.TabIndex = 3;
            this.comboBoxStatus.ValueMember = "studentStatusKEY";
            // 
            // referencestudentStatusesBindingSource
            // 
            this.referencestudentStatusesBindingSource.DataMember = "reference_studentStatuses";
            this.referencestudentStatusesBindingSource.DataSource = this.medofficeDataSet;
            // 
            // groupBoxPersonalData
            // 
            this.groupBoxPersonalData.Controls.Add(this.textBoxAddress);
            this.groupBoxPersonalData.Controls.Add(this.labelAddress);
            this.groupBoxPersonalData.Controls.Add(this.labelSchool);
            this.groupBoxPersonalData.Controls.Add(this.textBoxSchool);
            this.groupBoxPersonalData.Controls.Add(this.labelBirthDate);
            this.groupBoxPersonalData.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBoxPersonalData.Controls.Add(this.buttonGroupFilter);
            this.groupBoxPersonalData.Controls.Add(this.labelPatronym);
            this.groupBoxPersonalData.Controls.Add(this.comboBoxGroup);
            this.groupBoxPersonalData.Controls.Add(this.labelFirstName);
            this.groupBoxPersonalData.Controls.Add(this.labelGroup);
            this.groupBoxPersonalData.Controls.Add(this.labelLastName);
            this.groupBoxPersonalData.Controls.Add(this.textBoxPatronym);
            this.groupBoxPersonalData.Controls.Add(this.textBoxFirstName);
            this.groupBoxPersonalData.Controls.Add(this.textBoxLastName);
            this.groupBoxPersonalData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPersonalData.Name = "groupBoxPersonalData";
            this.groupBoxPersonalData.Size = new System.Drawing.Size(461, 127);
            this.groupBoxPersonalData.TabIndex = 31;
            this.groupBoxPersonalData.TabStop = false;
            this.groupBoxPersonalData.Text = "Личные данные";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(293, 18);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(158, 43);
            this.textBoxAddress.TabIndex = 11;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(246, 22);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(41, 13);
            this.labelAddress.TabIndex = 10;
            this.labelAddress.Text = "Адрес:";
            // 
            // labelSchool
            // 
            this.labelSchool.AutoSize = true;
            this.labelSchool.Location = new System.Drawing.Point(246, 70);
            this.labelSchool.Name = "labelSchool";
            this.labelSchool.Size = new System.Drawing.Size(94, 13);
            this.labelSchool.TabIndex = 9;
            this.labelSchool.Text = "Окончена школа:";
            // 
            // textBoxSchool
            // 
            this.textBoxSchool.Location = new System.Drawing.Point(346, 67);
            this.textBoxSchool.Multiline = true;
            this.textBoxSchool.Name = "textBoxSchool";
            this.textBoxSchool.Size = new System.Drawing.Size(105, 20);
            this.textBoxSchool.TabIndex = 8;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(6, 100);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(89, 13);
            this.labelBirthDate.TabIndex = 7;
            this.labelBirthDate.Text = "Дата рождения:";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(101, 97);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(134, 20);
            this.dateTimePickerBirthDate.TabIndex = 6;
            // 
            // buttonGroupFilter
            // 
            this.buttonGroupFilter.Location = new System.Drawing.Point(397, 96);
            this.buttonGroupFilter.Name = "buttonGroupFilter";
            this.buttonGroupFilter.Size = new System.Drawing.Size(55, 23);
            this.buttonGroupFilter.TabIndex = 2;
            this.buttonGroupFilter.Text = "Фильтр";
            this.buttonGroupFilter.UseVisualStyleBackColor = true;
            // 
            // labelPatronym
            // 
            this.labelPatronym.AutoSize = true;
            this.labelPatronym.Location = new System.Drawing.Point(6, 74);
            this.labelPatronym.Name = "labelPatronym";
            this.labelPatronym.Size = new System.Drawing.Size(57, 13);
            this.labelPatronym.TabIndex = 5;
            this.labelPatronym.Text = "Отчество:";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DataSource = this.referenceGroupsBindingSource;
            this.comboBoxGroup.DisplayMember = "groupNo";
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(293, 97);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(98, 21);
            this.comboBoxGroup.TabIndex = 1;
            this.comboBoxGroup.ValueMember = "groupKey";
            // 
            // referenceGroupsBindingSource
            // 
            this.referenceGroupsBindingSource.DataMember = "reference_Groups";
            this.referenceGroupsBindingSource.DataSource = this.medofficeDataSet;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(6, 48);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(32, 13);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "Имя:";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(245, 100);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(45, 13);
            this.labelGroup.TabIndex = 0;
            this.labelGroup.Text = "Группа:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(6, 22);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(59, 13);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Фамилия:";
            // 
            // textBoxPatronym
            // 
            this.textBoxPatronym.Location = new System.Drawing.Point(101, 71);
            this.textBoxPatronym.Name = "textBoxPatronym";
            this.textBoxPatronym.Size = new System.Drawing.Size(134, 20);
            this.textBoxPatronym.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(101, 45);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(134, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(101, 19);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(134, 20);
            this.textBoxLastName.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::vaccination.Properties.Resources.decline;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(357, 145);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 27);
            this.buttonCancel.TabIndex = 34;
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
            this.buttonAccept.TabIndex = 33;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // reference_physicalEducationHealthGroupsTableAdapter
            // 
            this.reference_physicalEducationHealthGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // reference_studentStatusesTableAdapter
            // 
            this.reference_studentStatusesTableAdapter.ClearBeforeFill = true;
            // 
            // reference_GroupsTableAdapter
            // 
            this.reference_GroupsTableAdapter.ClearBeforeFill = true;
            // 
            // referenceStudentsBindingSource
            // 
            this.referenceStudentsBindingSource.DataMember = "reference_Students";
            this.referenceStudentsBindingSource.DataSource = this.medofficeDataSet;
            // 
            // reference_StudentsTableAdapter
            // 
            this.reference_StudentsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewSt
            // 
            this.dataGridViewStudents.AutoGenerateColumns = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentKEYDataGridViewTextBoxColumn,
            this.studentLastNameDataGridViewTextBoxColumn,
            this.studentFirstNameDataGridViewTextBoxColumn,
            this.studentPatronymDataGridViewTextBoxColumn,
            this.studentBirthDateDataGridViewTextBoxColumn,
            this.studentAddressDataGridViewTextBoxColumn,
            this.studentSchoolDataGridViewTextBoxColumn,
            this.groupKEYDataGridViewTextBoxColumn,
            this.studentStatusKEYDataGridViewTextBoxColumn,
            this.physicalEducationHealthGroupKEYDataGridViewTextBoxColumn,
            this.physicalEducationLimitationsDataGridViewTextBoxColumn});
            this.dataGridViewStudents.DataSource = this.referenceStudentsBindingSource;
            this.dataGridViewStudents.Location = new System.Drawing.Point(597, 145);
            this.dataGridViewStudents.Name = "dataGridViewSt";
            this.dataGridViewStudents.Size = new System.Drawing.Size(28, 27);
            this.dataGridViewStudents.TabIndex = 35;
            this.dataGridViewStudents.Visible = false;
            // 
            // studentKEYDataGridViewTextBoxColumn
            // 
            this.studentKEYDataGridViewTextBoxColumn.DataPropertyName = "studentKEY";
            this.studentKEYDataGridViewTextBoxColumn.HeaderText = "studentKEY";
            this.studentKEYDataGridViewTextBoxColumn.Name = "studentKEYDataGridViewTextBoxColumn";
            this.studentKEYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentLastNameDataGridViewTextBoxColumn
            // 
            this.studentLastNameDataGridViewTextBoxColumn.DataPropertyName = "studentLastName";
            this.studentLastNameDataGridViewTextBoxColumn.HeaderText = "studentLastName";
            this.studentLastNameDataGridViewTextBoxColumn.Name = "studentLastNameDataGridViewTextBoxColumn";
            this.studentLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentFirstNameDataGridViewTextBoxColumn
            // 
            this.studentFirstNameDataGridViewTextBoxColumn.DataPropertyName = "studentFirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.HeaderText = "studentFirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.Name = "studentFirstNameDataGridViewTextBoxColumn";
            this.studentFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentPatronymDataGridViewTextBoxColumn
            // 
            this.studentPatronymDataGridViewTextBoxColumn.DataPropertyName = "studentPatronym";
            this.studentPatronymDataGridViewTextBoxColumn.HeaderText = "studentPatronym";
            this.studentPatronymDataGridViewTextBoxColumn.Name = "studentPatronymDataGridViewTextBoxColumn";
            this.studentPatronymDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBirthDateDataGridViewTextBoxColumn
            // 
            this.studentBirthDateDataGridViewTextBoxColumn.DataPropertyName = "studentBirthDate";
            this.studentBirthDateDataGridViewTextBoxColumn.HeaderText = "studentBirthDate";
            this.studentBirthDateDataGridViewTextBoxColumn.Name = "studentBirthDateDataGridViewTextBoxColumn";
            this.studentBirthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentAddressDataGridViewTextBoxColumn
            // 
            this.studentAddressDataGridViewTextBoxColumn.DataPropertyName = "studentAddress";
            this.studentAddressDataGridViewTextBoxColumn.HeaderText = "studentAddress";
            this.studentAddressDataGridViewTextBoxColumn.Name = "studentAddressDataGridViewTextBoxColumn";
            this.studentAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentSchoolDataGridViewTextBoxColumn
            // 
            this.studentSchoolDataGridViewTextBoxColumn.DataPropertyName = "studentSchool";
            this.studentSchoolDataGridViewTextBoxColumn.HeaderText = "studentSchool";
            this.studentSchoolDataGridViewTextBoxColumn.Name = "studentSchoolDataGridViewTextBoxColumn";
            this.studentSchoolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupKEYDataGridViewTextBoxColumn
            // 
            this.groupKEYDataGridViewTextBoxColumn.DataPropertyName = "groupKEY";
            this.groupKEYDataGridViewTextBoxColumn.HeaderText = "groupKEY";
            this.groupKEYDataGridViewTextBoxColumn.Name = "groupKEYDataGridViewTextBoxColumn";
            this.groupKEYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentStatusKEYDataGridViewTextBoxColumn
            // 
            this.studentStatusKEYDataGridViewTextBoxColumn.DataPropertyName = "studentStatusKEY";
            this.studentStatusKEYDataGridViewTextBoxColumn.HeaderText = "studentStatusKEY";
            this.studentStatusKEYDataGridViewTextBoxColumn.Name = "studentStatusKEYDataGridViewTextBoxColumn";
            this.studentStatusKEYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // physicalEducationHealthGroupKEYDataGridViewTextBoxColumn
            // 
            this.physicalEducationHealthGroupKEYDataGridViewTextBoxColumn.DataPropertyName = "physicalEducationHealthGroupKEY";
            this.physicalEducationHealthGroupKEYDataGridViewTextBoxColumn.HeaderText = "physicalEducationHealthGroupKEY";
            this.physicalEducationHealthGroupKEYDataGridViewTextBoxColumn.Name = "physicalEducationHealthGroupKEYDataGridViewTextBoxColumn";
            this.physicalEducationHealthGroupKEYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // physicalEducationLimitationsDataGridViewTextBoxColumn
            // 
            this.physicalEducationLimitationsDataGridViewTextBoxColumn.DataPropertyName = "physicalEducationLimitations";
            this.physicalEducationLimitationsDataGridViewTextBoxColumn.HeaderText = "physicalEducationLimitations";
            this.physicalEducationLimitationsDataGridViewTextBoxColumn.Name = "physicalEducationLimitationsDataGridViewTextBoxColumn";
            this.physicalEducationLimitationsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormEditStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 184);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.groupBoxPersonalData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEditStudents";
            this.Text = "Редактирование записи о студенте";
            this.Load += new System.EventHandler(this.FormEditStudents_Load);
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referencephysicalEducationHealthGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencestudentStatusesBindingSource)).EndInit();
            this.groupBoxPersonalData.ResumeLayout(false);
            this.groupBoxPersonalData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.TextBox textBoxPElimitations;
        private System.Windows.Forms.Label labelPElimitations;
        private System.Windows.Forms.Label labelPEGroup;
        private System.Windows.Forms.ComboBox comboBoxPEgroup;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.GroupBox groupBoxPersonalData;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelSchool;
        private System.Windows.Forms.TextBox textBoxSchool;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Button buttonGroupFilter;
        private System.Windows.Forms.Label labelPatronym;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxPatronym;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private medofficeDataSet medofficeDataSet;
        private System.Windows.Forms.BindingSource referencephysicalEducationHealthGroupsBindingSource;
        private medofficeDataSetTableAdapters.reference_physicalEducationHealthGroupsTableAdapter reference_physicalEducationHealthGroupsTableAdapter;
        private System.Windows.Forms.BindingSource referencestudentStatusesBindingSource;
        private medofficeDataSetTableAdapters.reference_studentStatusesTableAdapter reference_studentStatusesTableAdapter;
        private System.Windows.Forms.BindingSource referenceGroupsBindingSource;
        private medofficeDataSetTableAdapters.reference_GroupsTableAdapter reference_GroupsTableAdapter;
        private System.Windows.Forms.BindingSource referenceStudentsBindingSource;
        private medofficeDataSetTableAdapters.reference_StudentsTableAdapter reference_StudentsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentKEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPatronymDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSchoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupKEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentStatusKEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicalEducationHealthGroupKEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicalEducationLimitationsDataGridViewTextBoxColumn;
    }
}