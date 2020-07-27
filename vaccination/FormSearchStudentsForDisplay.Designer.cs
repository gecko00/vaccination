namespace vaccination
{
    partial class FormSearchStudentsForDisplay
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
            this.reference_studentStatusesTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_studentStatusesTableAdapter();
            this.reference_GroupsTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_GroupsTableAdapter();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.checkBoxLastName = new System.Windows.Forms.CheckBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.checkBoxGroup = new System.Windows.Forms.CheckBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.referenceGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medofficeDataSet = new vaccination.medofficeDataSet();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.comboBoxHealthGroup = new System.Windows.Forms.ComboBox();
            this.referencephysicalEducationHealthGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxHealthGroup = new System.Windows.Forms.CheckBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.referencestudentStatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxAge = new System.Windows.Forms.CheckBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.reference_physicalEducationHealthGroupsTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_physicalEducationHealthGroupsTableAdapter();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencephysicalEducationHealthGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencestudentStatusesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reference_studentStatusesTableAdapter
            // 
            this.reference_studentStatusesTableAdapter.ClearBeforeFill = true;
            // 
            // reference_GroupsTableAdapter
            // 
            this.reference_GroupsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.checkBoxLastName);
            this.groupBoxFilters.Controls.Add(this.textBoxLastName);
            this.groupBoxFilters.Controls.Add(this.checkBoxGroup);
            this.groupBoxFilters.Controls.Add(this.comboBoxGroup);
            this.groupBoxFilters.Controls.Add(this.numericUpDownAge);
            this.groupBoxFilters.Controls.Add(this.comboBoxHealthGroup);
            this.groupBoxFilters.Controls.Add(this.checkBoxHealthGroup);
            this.groupBoxFilters.Controls.Add(this.comboBoxStatus);
            this.groupBoxFilters.Controls.Add(this.checkBoxAge);
            this.groupBoxFilters.Controls.Add(this.checkBoxStatus);
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(430, 134);
            this.groupBoxFilters.TabIndex = 42;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фильтры";
            // 
            // checkBoxLastName
            // 
            this.checkBoxLastName.AutoSize = true;
            this.checkBoxLastName.Location = new System.Drawing.Point(6, 19);
            this.checkBoxLastName.Name = "checkBoxLastName";
            this.checkBoxLastName.Size = new System.Drawing.Size(75, 17);
            this.checkBoxLastName.TabIndex = 0;
            this.checkBoxLastName.Text = "Фамилия";
            this.checkBoxLastName.UseVisualStyleBackColor = true;
            this.checkBoxLastName.CheckedChanged += new System.EventHandler(this.checkBoxLastName_CheckedChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Location = new System.Drawing.Point(6, 42);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 1;
            // 
            // checkBoxGroup
            // 
            this.checkBoxGroup.AutoSize = true;
            this.checkBoxGroup.Location = new System.Drawing.Point(154, 19);
            this.checkBoxGroup.Name = "checkBoxGroup";
            this.checkBoxGroup.Size = new System.Drawing.Size(61, 17);
            this.checkBoxGroup.TabIndex = 2;
            this.checkBoxGroup.Text = "Группа";
            this.checkBoxGroup.UseVisualStyleBackColor = true;
            this.checkBoxGroup.CheckedChanged += new System.EventHandler(this.checkBoxGroup_CheckedChanged);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DataSource = this.referenceGroupsBindingSource;
            this.comboBoxGroup.DisplayMember = "groupNo";
            this.comboBoxGroup.Enabled = false;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(154, 41);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(100, 21);
            this.comboBoxGroup.TabIndex = 3;
            this.comboBoxGroup.ValueMember = "groupKey";
            // 
            // referenceGroupsBindingSource
            // 
            this.referenceGroupsBindingSource.DataMember = "reference_Groups";
            this.referenceGroupsBindingSource.DataSource = this.medofficeDataSet;
            // 
            // medofficeDataSet
            // 
            this.medofficeDataSet.DataSetName = "medofficeDataSet";
            this.medofficeDataSet.Locale = new System.Globalization.CultureInfo("ru-RU");
            this.medofficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Enabled = false;
            this.numericUpDownAge.Location = new System.Drawing.Point(305, 41);
            this.numericUpDownAge.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownAge.TabIndex = 12;
            this.numericUpDownAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // comboBoxHealthGroup
            // 
            this.comboBoxHealthGroup.DataSource = this.referencephysicalEducationHealthGroupsBindingSource;
            this.comboBoxHealthGroup.DisplayMember = "physicalEducationHealthGroupName";
            this.comboBoxHealthGroup.Enabled = false;
            this.comboBoxHealthGroup.FormattingEnabled = true;
            this.comboBoxHealthGroup.Location = new System.Drawing.Point(6, 105);
            this.comboBoxHealthGroup.Name = "comboBoxHealthGroup";
            this.comboBoxHealthGroup.Size = new System.Drawing.Size(100, 21);
            this.comboBoxHealthGroup.TabIndex = 6;
            this.comboBoxHealthGroup.ValueMember = "physicalEducationHealthGroupKEY";
            // 
            // referencephysicalEducationHealthGroupsBindingSource
            // 
            this.referencephysicalEducationHealthGroupsBindingSource.DataMember = "reference_physicalEducationHealthGroups";
            this.referencephysicalEducationHealthGroupsBindingSource.DataSource = this.medofficeDataSet;
            // 
            // checkBoxHealthGroup
            // 
            this.checkBoxHealthGroup.AutoSize = true;
            this.checkBoxHealthGroup.Location = new System.Drawing.Point(6, 81);
            this.checkBoxHealthGroup.Name = "checkBoxHealthGroup";
            this.checkBoxHealthGroup.Size = new System.Drawing.Size(112, 17);
            this.checkBoxHealthGroup.TabIndex = 7;
            this.checkBoxHealthGroup.Text = "Группа здоровья";
            this.checkBoxHealthGroup.UseVisualStyleBackColor = true;
            this.checkBoxHealthGroup.CheckedChanged += new System.EventHandler(this.checkBoxHealthGroup_CheckedChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DataSource = this.referencestudentStatusesBindingSource;
            this.comboBoxStatus.DisplayMember = "studentStatusName";
            this.comboBoxStatus.Enabled = false;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(154, 103);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStatus.TabIndex = 9;
            this.comboBoxStatus.ValueMember = "studentStatusKEY";
            // 
            // referencestudentStatusesBindingSource
            // 
            this.referencestudentStatusesBindingSource.DataMember = "reference_studentStatuses";
            this.referencestudentStatusesBindingSource.DataSource = this.medofficeDataSet;
            // 
            // checkBoxAge
            // 
            this.checkBoxAge.AutoSize = true;
            this.checkBoxAge.Location = new System.Drawing.Point(305, 19);
            this.checkBoxAge.Name = "checkBoxAge";
            this.checkBoxAge.Size = new System.Drawing.Size(111, 17);
            this.checkBoxAge.TabIndex = 8;
            this.checkBoxAge.Text = "Возраст младше";
            this.checkBoxAge.UseVisualStyleBackColor = true;
            this.checkBoxAge.CheckedChanged += new System.EventHandler(this.checkBoxAge_CheckedChanged);
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(154, 81);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(60, 17);
            this.checkBoxStatus.TabIndex = 8;
            this.checkBoxStatus.Text = "Статус";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            this.checkBoxStatus.CheckedChanged += new System.EventHandler(this.checkBoxStatus_CheckedChanged);
            // 
            // reference_physicalEducationHealthGroupsTableAdapter
            // 
            this.reference_physicalEducationHealthGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::vaccination.Properties.Resources.decline;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(230, 152);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 27);
            this.buttonCancel.TabIndex = 43;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Image = global::vaccination.Properties.Resources.accept;
            this.buttonAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccept.Location = new System.Drawing.Point(24, 152);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(200, 27);
            this.buttonAccept.TabIndex = 42;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // FormSearchStudentsForDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 191);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.groupBoxFilters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSearchStudentsForDisplay";
            this.Text = "Поиск студентов";
            this.Load += new System.EventHandler(this.FormSearchStudentsForDisplay_Load);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencephysicalEducationHealthGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencestudentStatusesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private medofficeDataSetTableAdapters.reference_studentStatusesTableAdapter reference_studentStatusesTableAdapter;
        private medofficeDataSetTableAdapters.reference_GroupsTableAdapter reference_GroupsTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.CheckBox checkBoxLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.CheckBox checkBoxGroup;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.BindingSource referenceGroupsBindingSource;
        private medofficeDataSet medofficeDataSet;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.ComboBox comboBoxHealthGroup;
        private System.Windows.Forms.BindingSource referencephysicalEducationHealthGroupsBindingSource;
        private System.Windows.Forms.CheckBox checkBoxHealthGroup;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.BindingSource referencestudentStatusesBindingSource;
        private System.Windows.Forms.CheckBox checkBoxAge;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private medofficeDataSetTableAdapters.reference_physicalEducationHealthGroupsTableAdapter reference_physicalEducationHealthGroupsTableAdapter;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
    }
}