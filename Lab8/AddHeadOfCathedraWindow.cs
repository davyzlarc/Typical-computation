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

        private void addHeadOfCathedraButton_Click(object sender, EventArgs e)
        {
            int experience;
            int numberOfPublishes;

            if (firstNameTextBox.Text == "" || middleNameTextBox.Text == "" || lastNameTextBox.Text == ""
                || cathedraTextBox.Text == "" || textBoxSubject.Text == "" || experienceTextBox.Text == ""
                || numberOfPublishesTextBox.Text=="")
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else if (!Regex.IsMatch(lastNameTextBox.Text, Globals.lastNamePattern))
            {
                MessageBox.Show("Неверный формат фамилии");
                lastNameTextBox.Clear();
            }
            else if (!Regex.IsMatch(firstNameTextBox.Text, Globals.firstAndMiddleNamePattern))
            {
                MessageBox.Show("Неверный формат имени");
                firstNameTextBox.Clear();
            }
            else if (!Regex.IsMatch(middleNameTextBox.Text, Globals.firstAndMiddleNamePattern))
            {
                MessageBox.Show("Неверный формат отчества");
                middleNameTextBox.Clear();
            }
            else if (!Regex.IsMatch(cathedraTextBox.Text, Globals.cathedraPattern))
            {
                MessageBox.Show("Неверный формат названия кафедры");
                cathedraTextBox.Clear();
            }
            else if (!Regex.IsMatch(textBoxSubject.Text, Globals.subjectPattern))
            {
                MessageBox.Show("Неверный формат названия предмета");
                textBoxSubject.Clear();
            }
            else if (!(Int32.TryParse(experienceTextBox.Text, out experience) && experience >= 0 && experience <= Globals.maxExperience))
            {
                MessageBox.Show("Некорректный стаж\t\nСтаж может находиться в промежутке [0; " + Globals.maxExperience + ']');
                experienceTextBox.Clear();
            }
            else if (!(Int32.TryParse(numberOfPublishesTextBox.Text, out numberOfPublishes)
                && numberOfPublishes >= 0 && experience <= Globals.maxPublications))
            {
                MessageBox.Show("Некорректное число публикаций\t\nЧисло публикаций может находиться в промежутке [0; "
                    + Globals.maxPublications + ']');
                numberOfPublishesTextBox.Clear();
            }
            else
            {
                this.Close();
            }
        }
    }
}
