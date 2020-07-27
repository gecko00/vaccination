namespace vaccination
{
    partial class FormGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroups));
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.groupKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graduationYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorClassroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medofficeDataSet = new vaccination.medofficeDataSet();
            this.groupBoxYears = new System.Windows.Forms.GroupBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.numericUpDownFrom = new System.Windows.Forms.NumericUpDown();
            this.groupBoxEducationClasses = new System.Windows.Forms.GroupBox();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxGroupNo = new System.Windows.Forms.MaskedTextBox();
            this.labelGroupNo = new System.Windows.Forms.Label();
            this.groupBoxTutor = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxClassroom = new System.Windows.Forms.MaskedTextBox();
            this.labelClassroom = new System.Windows.Forms.Label();
            this.textBoxTutor = new System.Windows.Forms.TextBox();
            this.labelTutor = new System.Windows.Forms.Label();
            this.reference_GroupsTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_GroupsTableAdapter();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonRecordDelete = new System.Windows.Forms.Button();
            this.buttonDataSetFilter = new System.Windows.Forms.Button();
            this.buttonRecordEdit = new System.Windows.Forms.Button();
            this.buttonRecordAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).BeginInit();
            this.groupBoxYears.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).BeginInit();
            this.groupBoxEducationClasses.SuspendLayout();
            this.groupBoxTutor.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.AllowUserToDeleteRows = false;
            this.dataGridViewGroups.AutoGenerateColumns = false;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupKeyDataGridViewTextBoxColumn,
            this.groupNoDataGridViewTextBoxColumn,
            this.admissionYearDataGridViewTextBoxColumn,
            this.graduationYearDataGridViewTextBoxColumn,
            this.tutorDataGridViewTextBoxColumn,
            this.tutorClassroomDataGridViewTextBoxColumn});
            this.dataGridViewGroups.DataSource = this.referenceGroupsBindingSource;
            this.dataGridViewGroups.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.ReadOnly = true;
            this.dataGridViewGroups.Size = new System.Drawing.Size(845, 285);
            this.dataGridViewGroups.TabIndex = 1;
            this.dataGridViewGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroups_CellClick);
            // 
            // groupKeyDataGridViewTextBoxColumn
            // 
            this.groupKeyDataGridViewTextBoxColumn.DataPropertyName = "groupKey";
            this.groupKeyDataGridViewTextBoxColumn.HeaderText = "Код";
            this.groupKeyDataGridViewTextBoxColumn.Name = "groupKeyDataGridViewTextBoxColumn";
            this.groupKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupKeyDataGridViewTextBoxColumn.Width = 70;
            // 
            // groupNoDataGridViewTextBoxColumn
            // 
            this.groupNoDataGridViewTextBoxColumn.DataPropertyName = "groupNo";
            this.groupNoDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupNoDataGridViewTextBoxColumn.Name = "groupNoDataGridViewTextBoxColumn";
            this.groupNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // admissionYearDataGridViewTextBoxColumn
            // 
            this.admissionYearDataGridViewTextBoxColumn.DataPropertyName = "admissionYear";
            this.admissionYearDataGridViewTextBoxColumn.HeaderText = "Год поступления";
            this.admissionYearDataGridViewTextBoxColumn.Name = "admissionYearDataGridViewTextBoxColumn";
            this.admissionYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.admissionYearDataGridViewTextBoxColumn.Width = 120;
            // 
            // graduationYearDataGridViewTextBoxColumn
            // 
            this.graduationYearDataGridViewTextBoxColumn.DataPropertyName = "graduationYear";
            this.graduationYearDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            this.graduationYearDataGridViewTextBoxColumn.Name = "graduationYearDataGridViewTextBoxColumn";
            this.graduationYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.graduationYearDataGridViewTextBoxColumn.Width = 120;
            // 
            // tutorDataGridViewTextBoxColumn
            // 
            this.tutorDataGridViewTextBoxColumn.DataPropertyName = "tutor";
            this.tutorDataGridViewTextBoxColumn.HeaderText = "tutor";
            this.tutorDataGridViewTextBoxColumn.Name = "tutorDataGridViewTextBoxColumn";
            this.tutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.tutorDataGridViewTextBoxColumn.Visible = false;
            // 
            // tutorClassroomDataGridViewTextBoxColumn
            // 
            this.tutorClassroomDataGridViewTextBoxColumn.DataPropertyName = "tutorClassroom";
            this.tutorClassroomDataGridViewTextBoxColumn.HeaderText = "tutorClassroom";
            this.tutorClassroomDataGridViewTextBoxColumn.Name = "tutorClassroomDataGridViewTextBoxColumn";
            this.tutorClassroomDataGridViewTextBoxColumn.ReadOnly = true;
            this.tutorClassroomDataGridViewTextBoxColumn.Visible = false;
            // 
            // referenceGroupsBindingSource
            // 
            this.referenceGroupsBindingSource.DataMember = "reference_Groups";
            this.referenceGroupsBindingSource.DataSource = this.medofficeDataSet;
            // 
            // medofficeDataSet
            // 
            this.medofficeDataSet.DataSetName = "medofficeDataSet";
            this.medofficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxYears
            // 
            this.groupBoxYears.Controls.Add(this.labelTo);
            this.groupBoxYears.Controls.Add(this.labelFrom);
            this.groupBoxYears.Controls.Add(this.numericUpDownFrom);
            this.groupBoxYears.Enabled = false;
            this.groupBoxYears.Location = new System.Drawing.Point(98, 389);
            this.groupBoxYears.Name = "groupBoxYears";
            this.groupBoxYears.Size = new System.Drawing.Size(172, 41);
            this.groupBoxYears.TabIndex = 25;
            this.groupBoxYears.TabStop = false;
            this.groupBoxYears.Text = "Срок обучения";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(80, 21);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(19, 13);
            this.labelTo.TabIndex = 19;
            this.labelTo.Text = "по";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(6, 21);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(14, 13);
            this.labelFrom.TabIndex = 18;
            this.labelFrom.Text = "С";
            // 
            // numericUpDownFrom
            // 
            this.numericUpDownFrom.Location = new System.Drawing.Point(26, 18);
            this.numericUpDownFrom.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numericUpDownFrom.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.numericUpDownFrom.Name = "numericUpDownFrom";
            this.numericUpDownFrom.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownFrom.TabIndex = 16;
            this.numericUpDownFrom.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.numericUpDownFrom.ValueChanged += new System.EventHandler(this.numericUpDownFrom_ValueChanged);
            // 
            // groupBoxEducationClasses
            // 
            this.groupBoxEducationClasses.Controls.Add(this.radioButton11);
            this.groupBoxEducationClasses.Controls.Add(this.radioButton9);
            this.groupBoxEducationClasses.Enabled = false;
            this.groupBoxEducationClasses.Location = new System.Drawing.Point(98, 342);
            this.groupBoxEducationClasses.Name = "groupBoxEducationClasses";
            this.groupBoxEducationClasses.Size = new System.Drawing.Size(172, 41);
            this.groupBoxEducationClasses.TabIndex = 24;
            this.groupBoxEducationClasses.TabStop = false;
            this.groupBoxEducationClasses.Text = "Образование";
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(88, 19);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(82, 17);
            this.radioButton11.TabIndex = 14;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "11 классов";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Checked = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 19);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(76, 17);
            this.radioButton9.TabIndex = 13;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "9 классов";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // maskedTextBoxGroupNo
            // 
            this.maskedTextBoxGroupNo.Enabled = false;
            this.maskedTextBoxGroupNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.maskedTextBoxGroupNo.Location = new System.Drawing.Point(12, 361);
            this.maskedTextBoxGroupNo.Mask = "000";
            this.maskedTextBoxGroupNo.Name = "maskedTextBoxGroupNo";
            this.maskedTextBoxGroupNo.Size = new System.Drawing.Size(74, 49);
            this.maskedTextBoxGroupNo.TabIndex = 23;
            this.maskedTextBoxGroupNo.Text = "324";
            // 
            // labelGroupNo
            // 
            this.labelGroupNo.AutoSize = true;
            this.labelGroupNo.Location = new System.Drawing.Point(9, 345);
            this.labelGroupNo.Name = "labelGroupNo";
            this.labelGroupNo.Size = new System.Drawing.Size(83, 13);
            this.labelGroupNo.TabIndex = 22;
            this.labelGroupNo.Text = "Номер группы:";
            // 
            // groupBoxTutor
            // 
            this.groupBoxTutor.Controls.Add(this.maskedTextBoxClassroom);
            this.groupBoxTutor.Controls.Add(this.labelClassroom);
            this.groupBoxTutor.Controls.Add(this.textBoxTutor);
            this.groupBoxTutor.Controls.Add(this.labelTutor);
            this.groupBoxTutor.Enabled = false;
            this.groupBoxTutor.Location = new System.Drawing.Point(276, 342);
            this.groupBoxTutor.Name = "groupBoxTutor";
            this.groupBoxTutor.Size = new System.Drawing.Size(198, 88);
            this.groupBoxTutor.TabIndex = 26;
            this.groupBoxTutor.TabStop = false;
            this.groupBoxTutor.Text = "Руководитель группы";
            // 
            // maskedTextBoxClassroom
            // 
            this.maskedTextBoxClassroom.Location = new System.Drawing.Point(64, 52);
            this.maskedTextBoxClassroom.Mask = "999";
            this.maskedTextBoxClassroom.Name = "maskedTextBoxClassroom";
            this.maskedTextBoxClassroom.Size = new System.Drawing.Size(128, 20);
            this.maskedTextBoxClassroom.TabIndex = 3;
            // 
            // labelClassroom
            // 
            this.labelClassroom.AutoSize = true;
            this.labelClassroom.Location = new System.Drawing.Point(6, 55);
            this.labelClassroom.Name = "labelClassroom";
            this.labelClassroom.Size = new System.Drawing.Size(52, 13);
            this.labelClassroom.TabIndex = 2;
            this.labelClassroom.Text = "Кабинет:";
            // 
            // textBoxTutor
            // 
            this.textBoxTutor.Location = new System.Drawing.Point(64, 18);
            this.textBoxTutor.Name = "textBoxTutor";
            this.textBoxTutor.Size = new System.Drawing.Size(128, 20);
            this.textBoxTutor.TabIndex = 1;
            // 
            // labelTutor
            // 
            this.labelTutor.AutoSize = true;
            this.labelTutor.Location = new System.Drawing.Point(6, 21);
            this.labelTutor.Name = "labelTutor";
            this.labelTutor.Size = new System.Drawing.Size(37, 13);
            this.labelTutor.TabIndex = 0;
            this.labelTutor.Text = "ФИО:";
            // 
            // reference_GroupsTableAdapter
            // 
            this.reference_GroupsTableAdapter.ClearBeforeFill = true;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonRecordDelete);
            this.panelMenu.Controls.Add(this.buttonDataSetFilter);
            this.panelMenu.Controls.Add(this.buttonRecordEdit);
            this.panelMenu.Controls.Add(this.buttonRecordAdd);
            this.panelMenu.Location = new System.Drawing.Point(12, 303);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(845, 33);
            this.panelMenu.TabIndex = 29;
            // 
            // buttonRecordDelete
            // 
            this.buttonRecordDelete.Image = global::vaccination.Properties.Resources.delete;
            this.buttonRecordDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecordDelete.Location = new System.Drawing.Point(425, 3);
            this.buttonRecordDelete.Name = "buttonRecordDelete";
            this.buttonRecordDelete.Size = new System.Drawing.Size(200, 27);
            this.buttonRecordDelete.TabIndex = 25;
            this.buttonRecordDelete.Text = "Удалить";
            this.buttonRecordDelete.UseVisualStyleBackColor = true;
            this.buttonRecordDelete.Click += new System.EventHandler(this.buttonRecordDelete_Click);
            // 
            // buttonDataSetFilter
            // 
            this.buttonDataSetFilter.Image = global::vaccination.Properties.Resources.filter;
            this.buttonDataSetFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDataSetFilter.Location = new System.Drawing.Point(631, 3);
            this.buttonDataSetFilter.Name = "buttonDataSetFilter";
            this.buttonDataSetFilter.Size = new System.Drawing.Size(200, 27);
            this.buttonDataSetFilter.TabIndex = 24;
            this.buttonDataSetFilter.Text = "Найти";
            this.buttonDataSetFilter.UseVisualStyleBackColor = true;
            this.buttonDataSetFilter.Click += new System.EventHandler(this.buttonDataSetFilter_Click);
            // 
            // buttonRecordEdit
            // 
            this.buttonRecordEdit.Image = global::vaccination.Properties.Resources.edit;
            this.buttonRecordEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecordEdit.Location = new System.Drawing.Point(219, 3);
            this.buttonRecordEdit.Name = "buttonRecordEdit";
            this.buttonRecordEdit.Size = new System.Drawing.Size(200, 27);
            this.buttonRecordEdit.TabIndex = 23;
            this.buttonRecordEdit.Text = "Редактировать";
            this.buttonRecordEdit.UseVisualStyleBackColor = true;
            this.buttonRecordEdit.Click += new System.EventHandler(this.buttonRecordEdit_Click);
            // 
            // buttonRecordAdd
            // 
            this.buttonRecordAdd.Image = global::vaccination.Properties.Resources.add;
            this.buttonRecordAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecordAdd.Location = new System.Drawing.Point(13, 3);
            this.buttonRecordAdd.Name = "buttonRecordAdd";
            this.buttonRecordAdd.Size = new System.Drawing.Size(200, 27);
            this.buttonRecordAdd.TabIndex = 22;
            this.buttonRecordAdd.Text = "Добавить";
            this.buttonRecordAdd.UseVisualStyleBackColor = true;
            this.buttonRecordAdd.Click += new System.EventHandler(this.buttonRecordAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::vaccination.Properties.Resources.decline;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(704, 392);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(153, 38);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonAccept.Image = ((System.Drawing.Image)(resources.GetObject("buttonAccept.Image")));
            this.buttonAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccept.Location = new System.Drawing.Point(704, 348);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(153, 38);
            this.buttonAccept.TabIndex = 27;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Visible = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 442);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.groupBoxTutor);
            this.Controls.Add(this.groupBoxYears);
            this.Controls.Add(this.groupBoxEducationClasses);
            this.Controls.Add(this.maskedTextBoxGroupNo);
            this.Controls.Add(this.labelGroupNo);
            this.Controls.Add(this.dataGridViewGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGroups";
            this.Text = "Справочник: группы";
            this.Load += new System.EventHandler(this.FormGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).EndInit();
            this.groupBoxYears.ResumeLayout(false);
            this.groupBoxYears.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).EndInit();
            this.groupBoxEducationClasses.ResumeLayout(false);
            this.groupBoxEducationClasses.PerformLayout();
            this.groupBoxTutor.ResumeLayout(false);
            this.groupBoxTutor.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.GroupBox groupBoxYears;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.NumericUpDown numericUpDownFrom;
        private System.Windows.Forms.GroupBox groupBoxEducationClasses;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxGroupNo;
        private System.Windows.Forms.Label labelGroupNo;
        private System.Windows.Forms.GroupBox groupBoxTutor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxClassroom;
        private System.Windows.Forms.Label labelClassroom;
        private System.Windows.Forms.TextBox textBoxTutor;
        private System.Windows.Forms.Label labelTutor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private medofficeDataSet medofficeDataSet;
        private System.Windows.Forms.BindingSource referenceGroupsBindingSource;
        private medofficeDataSetTableAdapters.reference_GroupsTableAdapter reference_GroupsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn graduationYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorClassroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonRecordDelete;
        private System.Windows.Forms.Button buttonDataSetFilter;
        private System.Windows.Forms.Button buttonRecordEdit;
        private System.Windows.Forms.Button buttonRecordAdd;
    }
}