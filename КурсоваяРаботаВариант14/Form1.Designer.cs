namespace КурсоваяРаботаВариант14
{
    partial class Form1
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label gradeAsTextLabel;
            this.vAR14DataSet = new КурсоваяРаботаВариант14.VAR14DataSet();
            this.examViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examViewTableAdapter = new КурсоваяРаботаВариант14.VAR14DataSetTableAdapters.ExamViewTableAdapter();
            this.tableAdapterManager = new КурсоваяРаботаВариант14.VAR14DataSetTableAdapters.TableAdapterManager();
            this.examViewDataGridView = new System.Windows.Forms.DataGridView();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeExamViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new КурсоваяРаботаВариант14.VAR14DataSetTableAdapters.StudentTableAdapter();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new КурсоваяРаботаВариант14.VAR14DataSetTableAdapters.SubjectTableAdapter();
            this.nameComboBox1 = new System.Windows.Forms.ComboBox();
            this.gradeTableAdapter = new КурсоваяРаботаВариант14.VAR14DataSetTableAdapters.GradeTableAdapter();
            this.gradeAsTextComboBox = new System.Windows.Forms.ComboBox();
            this.studentExamViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectExamViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.examViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            gradeAsTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vAR14DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeExamViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentExamViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectExamViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(28, 43);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(62, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Студент";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel1.Location = new System.Drawing.Point(28, 109);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(67, 15);
            nameLabel1.TabIndex = 3;
            nameLabel1.Text = "Предмет";
            // 
            // gradeAsTextLabel
            // 
            gradeAsTextLabel.AutoSize = true;
            gradeAsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            gradeAsTextLabel.Location = new System.Drawing.Point(28, 182);
            gradeAsTextLabel.Name = "gradeAsTextLabel";
            gradeAsTextLabel.Size = new System.Drawing.Size(56, 15);
            gradeAsTextLabel.TabIndex = 5;
            gradeAsTextLabel.Text = "Оценка";
            // 
            // vAR14DataSet
            // 
            this.vAR14DataSet.DataSetName = "VAR14DataSet";
            this.vAR14DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examViewBindingSource
            // 
            this.examViewBindingSource.DataMember = "ExamView";
            this.examViewBindingSource.DataSource = this.vAR14DataSet;
            // 
            // examViewTableAdapter
            // 
            this.examViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ExamTableAdapter = null;
            this.tableAdapterManager.GradeTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = КурсоваяРаботаВариант14.VAR14DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // examViewDataGridView
            // 
            this.examViewDataGridView.AllowUserToAddRows = false;
            this.examViewDataGridView.AllowUserToDeleteRows = false;
            this.examViewDataGridView.AutoGenerateColumns = false;
            this.examViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.examViewDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.examViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn,
            this.gradeTextDataGridViewTextBoxColumn,
            this.semestrDataGridViewTextBoxColumn});
            this.examViewDataGridView.DataSource = this.examViewBindingSource1;
            this.examViewDataGridView.GridColor = System.Drawing.Color.Black;
            this.examViewDataGridView.Location = new System.Drawing.Point(303, 11);
            this.examViewDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.examViewDataGridView.Name = "examViewDataGridView";
            this.examViewDataGridView.RowHeadersWidth = 20;
            this.examViewDataGridView.RowTemplate.Height = 33;
            this.examViewDataGridView.Size = new System.Drawing.Size(811, 529);
            this.examViewDataGridView.TabIndex = 1;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Студент";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            // 
            // gradeTextDataGridViewTextBoxColumn
            // 
            this.gradeTextDataGridViewTextBoxColumn.DataPropertyName = "GradeText";
            this.gradeTextDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.gradeTextDataGridViewTextBoxColumn.Name = "gradeTextDataGridViewTextBoxColumn";
            // 
            // semestrDataGridViewTextBoxColumn
            // 
            this.semestrDataGridViewTextBoxColumn.DataPropertyName = "Semestr";
            this.semestrDataGridViewTextBoxColumn.HeaderText = "Семестр";
            this.semestrDataGridViewTextBoxColumn.Name = "semestrDataGridViewTextBoxColumn";
            // 
            // gradeExamViewBindingSource
            // 
            this.gradeExamViewBindingSource.DataMember = "Grade_ExamView";
            this.gradeExamViewBindingSource.DataSource = this.gradeBindingSource;
            // 
            // gradeBindingSource
            // 
            this.gradeBindingSource.DataMember = "Grade";
            this.gradeBindingSource.DataSource = this.vAR14DataSet;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.vAR14DataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Name", true));
            this.nameComboBox.DataSource = this.studentBindingSource;
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(31, 59);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(255, 21);
            this.nameComboBox.TabIndex = 2;
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.vAR14DataSet;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // nameComboBox1
            // 
            this.nameComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectBindingSource, "Name", true));
            this.nameComboBox1.DataSource = this.subjectBindingSource;
            this.nameComboBox1.DisplayMember = "Name";
            this.nameComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox1.FormattingEnabled = true;
            this.nameComboBox1.Location = new System.Drawing.Point(31, 125);
            this.nameComboBox1.Name = "nameComboBox1";
            this.nameComboBox1.Size = new System.Drawing.Size(255, 21);
            this.nameComboBox1.TabIndex = 4;
            this.nameComboBox1.SelectedIndexChanged += new System.EventHandler(this.nameComboBox1_SelectedIndexChanged);
            // 
            // gradeTableAdapter
            // 
            this.gradeTableAdapter.ClearBeforeFill = true;
            // 
            // gradeAsTextComboBox
            // 
            this.gradeAsTextComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gradeBindingSource, "GradeAsText", true));
            this.gradeAsTextComboBox.DataSource = this.gradeBindingSource;
            this.gradeAsTextComboBox.DisplayMember = "GradeAsText";
            this.gradeAsTextComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradeAsTextComboBox.FormattingEnabled = true;
            this.gradeAsTextComboBox.Location = new System.Drawing.Point(31, 198);
            this.gradeAsTextComboBox.Name = "gradeAsTextComboBox";
            this.gradeAsTextComboBox.Size = new System.Drawing.Size(255, 21);
            this.gradeAsTextComboBox.TabIndex = 6;
            this.gradeAsTextComboBox.SelectedIndexChanged += new System.EventHandler(this.gradeAsTextComboBox_SelectedIndexChanged);
            // 
            // studentExamViewBindingSource
            // 
            this.studentExamViewBindingSource.DataMember = "Student_ExamView";
            this.studentExamViewBindingSource.DataSource = this.studentBindingSource;
            // 
            // subjectExamViewBindingSource
            // 
            this.subjectExamViewBindingSource.DataMember = "Subject_ExamView";
            this.subjectExamViewBindingSource.DataSource = this.subjectBindingSource;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(31, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 213);
            this.button1.TabIndex = 7;
            this.button1.Text = "Изменение данных в справочных таблицах";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(31, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Обновить данные из БД";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(31, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Очистить фильтры";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // examViewBindingSource1
            // 
            this.examViewBindingSource1.DataMember = "ExamView";
            this.examViewBindingSource1.DataSource = this.vAR14DataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1125, 556);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(gradeAsTextLabel);
            this.Controls.Add(this.gradeAsTextComboBox);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameComboBox1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.examViewDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vAR14DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeExamViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentExamViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectExamViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examViewBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VAR14DataSet vAR14DataSet;
        private System.Windows.Forms.BindingSource examViewBindingSource;
        private VAR14DataSetTableAdapters.ExamViewTableAdapter examViewTableAdapter;
        private VAR14DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView examViewDataGridView;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private VAR14DataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private VAR14DataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.ComboBox nameComboBox1;
        private System.Windows.Forms.BindingSource gradeBindingSource;
        private VAR14DataSetTableAdapters.GradeTableAdapter gradeTableAdapter;
        private System.Windows.Forms.ComboBox gradeAsTextComboBox;
        private System.Windows.Forms.BindingSource gradeExamViewBindingSource;
        private System.Windows.Forms.BindingSource studentExamViewBindingSource;
        private System.Windows.Forms.BindingSource subjectExamViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource examViewBindingSource1;
    }
}

