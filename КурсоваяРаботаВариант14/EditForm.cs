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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vAR14DataSet);

        }

        private void studentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vAR14DataSet);

        }

        private void studentBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vAR14DataSet);

        }

        private void studentBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vAR14DataSet);

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vAR14DataSet.Grade". При необходимости она может быть перемещена или удалена.
            this.gradeTableAdapter.Fill(this.vAR14DataSet.Grade);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vAR14DataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.vAR14DataSet.Subject);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vAR14DataSet.Exam". При необходимости она может быть перемещена или удалена.
            this.examTableAdapter.Fill(this.vAR14DataSet.Exam);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vAR14DataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.vAR14DataSet.Student);

        }
    }
}
