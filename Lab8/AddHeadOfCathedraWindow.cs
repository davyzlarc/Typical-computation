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
    public partial class AddHeadOfCathedraWindow : Form
    {
        public AddHeadOfCathedraWindow()
        {
            InitializeComponent();
        }

        private void AddHeadOfCathedraButton_Click(object sender, EventArgs e)
        {
            int experience;
            int numberOfPublishes;

            if (firstNameTextBox.Text == "" || middleNameTextBox.Text == "" || lastNameTextBox.Text == ""
                || cathedraTextBox.Text == "" || textBoxSubject.Text == "" || experienceTextBox.Text == ""
                || numberOfPublishesTextBox.Text == "")
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
            else if (!Regex.IsMatch(cathedraTextBox.Text, Globals.cathedraPattern))
            {
                MessageBox.Show("Неверный формат названия кафедры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cathedraTextBox.Clear();
            }
            else if (!Regex.IsMatch(textBoxSubject.Text, Globals.subjectPattern))
            {
                MessageBox.Show("Неверный формат названия предмета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSubject.Clear();
            }
            else if (!(Int32.TryParse(experienceTextBox.Text, out experience) && experience >= 0 && experience <= Globals.maxExperience))
            {
                MessageBox.Show("Некорректный стаж\t\nСтаж может находиться в промежутке [0; " + Globals.maxExperience + ']',
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                experienceTextBox.Clear();
            }
            else if (!(Int32.TryParse(numberOfPublishesTextBox.Text, out numberOfPublishes)
                && numberOfPublishes >= 0 && experience <= Globals.maxPublications))
            {
                MessageBox.Show("Некорректное число публикаций\t\nЧисло публикаций может находиться в промежутке [0; "
                    + Globals.maxPublications + ']', "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numberOfPublishesTextBox.Clear();
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
