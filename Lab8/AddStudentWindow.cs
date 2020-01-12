using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab8
{
    public partial class AddStudentWindow : Form
    {
        public AddStudentWindow()
        {
            InitializeComponent();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            int course;
            double averageMark;

            if (firstNameTextBox.Text == "" || middleNameTextBox.Text == "" || lastNameTextBox.Text == ""
                || courseTextBox.Text == "" || averageMarkTextBox.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(lastNameTextBox.Text, Globals.lastNamePattern))
            {
                MessageBox.Show("Неверный формат фамилии", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameTextBox.Clear();
            }
            else if (!Regex.IsMatch(firstNameTextBox.Text, Globals.firstAndMiddleNamePattern))
            {
                MessageBox.Show("Неверный формат имени", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTextBox.Clear();
            }
            else if (!Regex.IsMatch(middleNameTextBox.Text, Globals.firstAndMiddleNamePattern))
            {
                MessageBox.Show("Неверный формат отчества", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                middleNameTextBox.Clear();
            }
            else if (!(Int32.TryParse(courseTextBox.Text, out course) && course > 0 && course <= 6))
            {
                MessageBox.Show("Некорректный курс", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                courseTextBox.Clear();
            }
            else if (!(double.TryParse(averageMarkTextBox.Text, out averageMark)
                && averageMark >= Globals.minAverageMark && averageMark <= Globals.maxAverageMark))
            {
                MessageBox.Show("Некорректный средний балл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                averageMarkTextBox.Clear();
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
