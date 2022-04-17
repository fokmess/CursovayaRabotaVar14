using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсоваяРаботаВариант14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vAR14DataSet.Grade". При необходимости она может быть перемещена или удалена.
            this.gradeTableAdapter.Fill(this.vAR14DataSet.Grade);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vAR14DataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.vAR14DataSet.Subject);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vAR14DataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.vAR14DataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vAR14DataSet.ExamView". При необходимости она может быть перемещена или удалена.
            this.examViewTableAdapter.Fill(this.vAR14DataSet.ExamView);

        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                examViewDataGridView.DataSource = this.studentExamViewBindingSource;
            }
            catch 
            {

              
            }
            
        }

        private void nameComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                examViewDataGridView.DataSource = this.subjectExamViewBindingSource;
            }
            catch 
            {

               
            }
          
        }

        private void gradeAsTextComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                examViewDataGridView.DataSource = this.gradeExamViewBindingSource;
            }
            catch
            {

               
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new EditForm();
            form.ShowDialog();  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vAR14DataSet.Grade". При необходимости она может быть перемещена или удалена.
            this.gradeTableAdapter.Fill(this.vAR14DataSet.Grade);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vAR14DataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.vAR14DataSet.Subject);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vAR14DataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.vAR14DataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vAR14DataSet.ExamView". При необходимости она может быть перемещена или удалена.
            this.examViewTableAdapter.Fill(this.vAR14DataSet.ExamView);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            examViewDataGridView.DataSource = this.examViewBindingSource;
        }
    }
}
