using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class MainWindow : Form
    {
        public Institute institute = new Institute();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowAllPersons()
        {
            infoListBox.Items.Clear();
            if (institute.Count > 0)
            {
                for (int i = 0; i < institute.Count; i++)
                {
                    infoListBox.Items.Add((i + 1) + ". " + institute.GetPerson(i).GetInfo() + "\t\n");
                }
            }
            else
            {
                infoListBox.Text = "В интституте нет студентов и преподавателей\t\n";
            }
        }

        private void RemovePersonButton_Click(object sender, EventArgs e)
        {
            if (institute.Count == 0)
            {
                MessageBox.Show("В институте нет преподавателей и студентов");
            }
            else
            {
                int index = infoListBox.SelectedIndex;
                institute.Remove(index);
                ShowAllPersons();
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();
            if (addStudentWindow.firstNameTextBox.Text != "" && addStudentWindow.middleNameTextBox.Text != ""
                && addStudentWindow.lastNameTextBox.Text != "" && addStudentWindow.courseTextBox.Text != ""
                && addStudentWindow.averageMarkTextBox.Text != "")
            {
                institute.Add(new Student(addStudentWindow.firstNameTextBox.Text, addStudentWindow.middleNameTextBox.Text,
                    addStudentWindow.lastNameTextBox.Text, Convert.ToInt32(addStudentWindow.courseTextBox.Text),
                    Convert.ToDouble(addStudentWindow.averageMarkTextBox.Text)));
            }
            ShowAllPersons();
        }

        private void AddProfessorButton_Click(object sender, EventArgs e)
        {
            AddProfessorWindow addProfessorWindow = new AddProfessorWindow();
            addProfessorWindow.ShowDialog();
            if (addProfessorWindow.firstNameTextBox.Text != "" && addProfessorWindow.middleNameTextBox.Text != ""
                && addProfessorWindow.lastNameTextBox.Text != "" && addProfessorWindow.cathedraTextBox.Text != ""
                && addProfessorWindow.experienceTextBox.Text != "")
            {
                institute.Add(new Professor(addProfessorWindow.firstNameTextBox.Text, addProfessorWindow.middleNameTextBox.Text,
                    addProfessorWindow.lastNameTextBox.Text, Convert.ToInt32(addProfessorWindow.experienceTextBox.Text),
                    addProfessorWindow.cathedraTextBox.Text, addProfessorWindow.textBoxSubject.Text));
            }
            ShowAllPersons();
        }

        private void AddHeadOfCathedraButton_Click(object sender, EventArgs e)
        {
            AddHeadOfCathedraWindow addHeadOfCathedraWindow = new AddHeadOfCathedraWindow();
            addHeadOfCathedraWindow.ShowDialog();
            if (addHeadOfCathedraWindow.firstNameTextBox.Text != "" && addHeadOfCathedraWindow.middleNameTextBox.Text != ""
                && addHeadOfCathedraWindow.lastNameTextBox.Text != "" && addHeadOfCathedraWindow.cathedraTextBox.Text != ""
                && addHeadOfCathedraWindow.experienceTextBox.Text != "" && addHeadOfCathedraWindow.numberOfPublishesTextBox.Text != "")
            {
                institute.Add(new HeadOfCathedra(addHeadOfCathedraWindow.firstNameTextBox.Text, addHeadOfCathedraWindow.middleNameTextBox.Text,
                    addHeadOfCathedraWindow.lastNameTextBox.Text, Convert.ToInt32(addHeadOfCathedraWindow.experienceTextBox.Text),
                    addHeadOfCathedraWindow.cathedraTextBox.Text, addHeadOfCathedraWindow.textBoxSubject.Text, Convert.ToInt32(addHeadOfCathedraWindow.numberOfPublishesTextBox.Text)));
            }
            ShowAllPersons();
        }

        private void ChangeAverageMarkButton_Click(object sender, EventArgs e)
        {
            int index = infoListBox.SelectedIndex;
            if (institute.GetPerson(index) is Student)
            {
                Student student = (Student)institute.GetPerson(index);
                double newAverageMark;
                if (double.TryParse(v.Text, out newAverageMark) && newAverageMark >= 2 && newAverageMark <= 5)
                {
                    student.AverageMark = newAverageMark;
                    student.CalculateStipend();
                    ShowAllPersons();
                    v.Clear();
                }
                else
                {
                    MessageBox.Show("Некорректный средний балл");
                    v.Clear();
                }
            }
            else
            {
                MessageBox.Show("Выбранный человек не является студентом");
            }
        }

        private void ChangeExperienceButton_Click(object sender, EventArgs e)
        {
            int index = infoListBox.SelectedIndex;
            if (institute.GetPerson(index) is Professor)
            {
                Professor professor = (Professor)institute.GetPerson(index);
                int newExperience;
                if (Int32.TryParse(v.Text, out newExperience) && newExperience > 0 && newExperience < Globals.maxExperience)
                {
                    professor.Experience = newExperience;
                    professor.CalculateSalary();
                    ShowAllPersons();
                    v.Clear();
                }
                else
                {
                    MessageBox.Show("Некорректный стаж\t\nСтаж может находиться в интервале [0; " + Globals.maxExperience + ')');
                    v.Clear();
                }
            }
            else
            {
                MessageBox.Show("Выбранный человек не является преподавателем");
            }
        }

        private void ChangeNumOfPublishesButton_Click(object sender, EventArgs e)
        {
            int index = infoListBox.SelectedIndex;
            if (institute.GetPerson(index) is HeadOfCathedra)
            {
                HeadOfCathedra headOfCathedra = (HeadOfCathedra)institute.GetPerson(index);
                int newNumberOfPublishes;
                if (Int32.TryParse(v.Text, out newNumberOfPublishes) && newNumberOfPublishes > 0
                    && newNumberOfPublishes < Globals.maxPublications)
                {
                    headOfCathedra.NumberOfPublications = newNumberOfPublishes;
                    headOfCathedra.CalculateSalary();
                    ShowAllPersons();
                    v.Clear();
                }
                else
                {
                    MessageBox.Show("Некорректный стаж\t\nСтаж может находиться в промежутке [0; " + Globals.maxPublications + ']');
                    v.Clear();
                }
            }
            else
            {
                MessageBox.Show("Выбранный человек не является заведующим кафедрой");
            }
        }

        private void ChangeDebtProfessor_Click(object sender, EventArgs e)
        {
            int index = infoListBox.SelectedIndex;
            if (institute.GetPerson(index) is Student)
            {
                Student student = (Student)institute.GetPerson(index);
                if (student.Debt != null)
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxDebt.Text, Globals.lastNamePattern))
                    {
                        MessageBox.Show("Неверный формат фамилии");
                        textBoxDebt.Clear();
                    }
                    else
                    {
                        string DebtProfessor = textBoxDebt.Text;

                        bool match = false;
                        int i = 0;
                        Professor professor = null;
                        while (i <= institute.Count - 1 && !match)
                        {
                            if (institute.GetPerson(i) is Professor)
                            {
                                professor = (Professor)institute.GetPerson(i);
                                if (professor.LastName == DebtProfessor) match = true;
                            }
                            i++;
                        }
                        if (match)
                        {
                            if (professor.Subject == student.Debt)
                            {
                                student.DebtProfessor = DebtProfessor;
                                ShowAllPersons();
                                textBoxDebt.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Нет преподавателя с такой фамилией по такому предмету");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Нет преподавателя с такой фамилией");
                            textBoxDebt.Clear();
                        }
                    }
                }
                else MessageBox.Show("У данного студента нет долгов");
            }
            else
            {
                MessageBox.Show("Выбранный человек не является студентом");
            }
        }
        private void AddDebt_Click(object sender, EventArgs e)
        {
            int index = infoListBox.SelectedIndex;
            if (institute.GetPerson(index) is Student)
            {
                Student student = (Student)institute.GetPerson(index);

                if (student.Debt != null)
                {
                    student.Debt = null;
                    student.DebtProfessor = null;
                    ShowAllPersons();
                    textBoxDebt.Clear();
                }
                else
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxDebt.Text, Globals.subjectPattern))
                    {
                        MessageBox.Show("Неверный формат названия предмета");
                        textBoxDebt.Clear();
                    }
                    else
                    {
                        string Debt = textBoxDebt.Text;

                        student.Debt = Debt;
                        ShowAllPersons();
                        textBoxDebt.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выбранный человек не является студентом");
            }
        }

        private void Setprofessor_Click(object sender, EventArgs e)
        {
            bool match = false;
            if (institute.Count == 0)
            {
                MessageBox.Show("В институте нет преподавателей и студентов");
            }
            else
            {
                for (int index = 0; index <= institute.Count - 1; index++)
                {
                    if (institute.GetPerson(index) is Student)
                    {
                        Student student = (Student)institute.GetPerson(index);
                        if (student.Debt != null && student.DebtProfessor == null)
                        {
                            string debt = student.Debt;

                            int i = 0;
                            Professor professor = null;
                            while (i <= institute.Count - 1 && !match)
                            {
                                if (institute.GetPerson(i) is Professor)
                                {
                                    professor = (Professor)institute.GetPerson(i);
                                    if (professor.Subject == debt) match = true;
                                }
                                i++;
                            }

                            if (match)
                            {
                                student.DebtProfessor = professor.LastName;
                                ShowAllPersons();
                            }
                            else
                            {
                                MessageBox.Show("Нет преподавателя по предмету \"" + debt + "\"" + ", по которому задолженность у студента - " + student.LastName);
                                textBoxDebt.Clear();
                            }
                        }
                    }
                }
                MessageBox.Show("Преподаватели на пересдачу успешно назначены");
            }
        }
    }
}
