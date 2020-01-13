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

        private void MainWindow_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.OK)
                e.Cancel = false;
            else e.Cancel = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                this.Close();
            }
            if (keyData == (Keys.Down | Keys.Control))
            {
                if (infoListBox.Items.Count != 0)
                {
                    if (infoListBox.SelectedIndex != infoListBox.Items.Count - 1) infoListBox.SelectedIndex++;
                    else if (infoListBox.SelectedIndex == -1) infoListBox.SelectedIndex = 0;
                }
            }
            if (keyData == (Keys.Up | Keys.Control))
            {
                if (infoListBox.Items.Count != 0)
                {
                    if (infoListBox.SelectedIndex != 0) infoListBox.SelectedIndex--;
                    else if (infoListBox.SelectedIndex == -1) infoListBox.SelectedIndex = infoListBox.Items.Count - 1;
                }
            }
            if (keyData == (Keys.Down))
            {
                int a = infoListBox.SelectedIndex;
                switch (ActiveControl.Name)
                {
                    case "addStudentButton":
                        addHeadOfCathedraButton.Focus();
                        break;
                    case "addProfessorButton":
                        changeAverageMarkButton.Focus();
                        break;
                    case "addHeadOfCathedraButton":
                        changeExperienceButton.Focus();
                        break;
                    case "changeAverageMarkButton":
                        changeNumOfPublishesButton.Focus();
                        break;
                    case "changeExperienceButton":
                        addDebt.Focus();
                        break;
                    case "changeNumOfPublishesButton":
                        setprofessor.Focus();
                        break;
                    case "addDebt":
                        infoListBox.Focus();
                        break;
                    case "setprofessor":
                        addStudentButton.Focus();
                        break;
                    case "changeDebtProfessor":
                        addProfessorButton.Focus();
                        break;
                    case "removePersonButton":
                        removePersonButton.Focus();
                        break;
                    case "v":
                        textBoxDebt.Focus();
                        break;
                    case "textBoxDebt":
                        removePersonButton.Focus();
                        break;
                    default:
                        infoListBox.Focus();
                        infoListBox.SelectedIndex = a;
                        break;
                }
            }
            if (keyData == (Keys.Up))
            {
                int a = infoListBox.SelectedIndex;
                switch (ActiveControl.Name)
                {
                    case "addStudentButton":
                        setprofessor.Focus();
                        break;
                    case "addProfessorButton":
                        changeDebtProfessor.Focus();
                        break;
                    case "addHeadOfCathedraButton":
                        removePersonButton.Focus();
                        break;
                    case "changeAverageMarkButton":
                        addProfessorButton.Focus();
                        break;
                    case "changeExperienceButton":
                        addHeadOfCathedraButton.Focus();
                        break;
                    case "changeNumOfPublishesButton":
                        changeAverageMarkButton.Focus();
                        break;
                    case "addDebt":
                        changeExperienceButton.Focus();
                        break;
                    case "setprofessor":
                        changeNumOfPublishesButton.Focus();
                        break;
                    case "changeDebtProfessor":
                        addDebt.Focus();
                        break;
                    case "removePersonButton":
                        infoListBox.Focus();
                        break;
                    case "v":
                        removePersonButton.Focus();
                        break;
                    case "textBoxDebt":
                        v.Focus();
                        break;
                    default:
                        infoListBox.Focus();
                        infoListBox.SelectedIndex = a;
                        break;
                }
            }
            if (keyData == (Keys.Right))
            {
                switch (ActiveControl.Name)
                {
                    case "addStudentButton":
                        addStudentButton.Focus();
                        break;
                    case "addProfessorButton":
                        addProfessorButton.Focus();
                        break;
                    case "addHeadOfCathedraButton":
                        changeDebtProfessor.Focus();
                        break;
                    case "changeAverageMarkButton":
                        changeAverageMarkButton.Focus();
                        break;
                    case "changeExperienceButton":
                        changeExperienceButton.Focus();
                        break;
                    case "changeNumOfPublishesButton":
                        removePersonButton.Focus();
                        break;
                    case "addDebt":
                        addDebt.Focus();
                        break;
                    case "setprofessor":
                        setprofessor.Focus();
                        break;
                    case "changeDebtProfessor":
                        v.Focus();
                        break;
                    case "removePersonButton":
                        infoListBox.Focus();
                        break;
                    case "v":
                        changeAverageMarkButton.Focus();
                        break;
                    case "textBoxDebt":
                        addDebt.Focus();
                        break;
                }
            }
            if (keyData == (Keys.Left))
            {
                switch (ActiveControl.Name)
                {
                    case "addStudentButton":
                        v.Focus();
                        break;
                    case "addProfessorButton":
                        addProfessorButton.Focus();
                        break;
                    case "addHeadOfCathedraButton":
                        addHeadOfCathedraButton.Focus();
                        break;
                    case "changeAverageMarkButton":
                        textBoxDebt.Focus();
                        break;
                    case "changeExperienceButton":
                        changeExperienceButton.Focus();
                        break;
                    case "changeNumOfPublishesButton":
                        changeNumOfPublishesButton.Focus();
                        break;
                    case "addDebt":
                        infoListBox.Focus();
                        break;
                    case "setprofessor":
                        setprofessor.Focus();
                        break;
                    case "changeDebtProfessor":
                        changeDebtProfessor.Focus();
                        break;
                    case "removePersonButton":
                        changeAverageMarkButton.Focus();
                        break;
                    case "v":
                        changeNumOfPublishesButton.Focus();
                        break;
                    case "textBoxDebt":
                        changeDebtProfessor.Focus();
                        break;
                }
            }
            if ((keyData == (Keys.Delete) || keyData == (Keys.Back)) && infoListBox.SelectedIndex != -1)
            {
                RemovePersonButton_Click(this, null);
            }
            if (keyData == (Keys.D1))
            {
                AddStudentButton_Click(this, null);
            }
            if (keyData == (Keys.D2))
            {
                AddProfessorButton_Click(this, null);
            }
            if (keyData == (Keys.D3))
            {
                AddHeadOfCathedraButton_Click(this, null);
            }
            if (keyData == (Keys.D4))
            {
                ChangeAverageMarkButton_Click(this, null);
            }
            if (keyData == (Keys.D5))
            {
                ChangeExperienceButton_Click(this, null);
            }
            if (keyData == (Keys.D6))
            {
                ChangeNumOfPublishesButton_Click(this, null);
            }
            if (keyData == (Keys.D7))
            {
                ChangeDebtProfessor_Click(this, null);
            }
            if (keyData == (Keys.D8))
            {
                Setprofessor_Click(this, null);
            }
            if (keyData == (Keys.D9))
            {
                AddDebt_Click(this, null);
            }
            return base.ProcessCmdKey(ref msg, keyData);
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
                MessageBox.Show("В институте нет преподавателей и студентов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int index = infoListBox.SelectedIndex;
                if (!(institute.GetPerson(index) is Student))
                {
                    for (int i = 0; i <= institute.Count - 1; i++)
                    {
                        if (institute.GetPerson(i) is Student)
                        {
                            Student student = (Student)institute.GetPerson(i);
                            if (student.DebtProfessor == (institute.GetPerson(index).LastName)) student.DebtProfessor = null;
                        }
                    }
                }
                institute.Remove(index);
                ShowAllPersons();
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();

            if (addStudentWindow.DialogResult == DialogResult.OK)
            {
                institute.Add(new Student(addStudentWindow.firstNameTextBox.Text, addStudentWindow.middleNameTextBox.Text,
                addStudentWindow.lastNameTextBox.Text, Convert.ToInt32(addStudentWindow.courseTextBox.Text),
                Convert.ToDouble(addStudentWindow.averageMarkTextBox.Text)));

                ShowAllPersons();
            }
        }

        private void AddProfessorButton_Click(object sender, EventArgs e)
        {
            AddProfessorWindow addProfessorWindow = new AddProfessorWindow();
            addProfessorWindow.ShowDialog();

            if (addProfessorWindow.DialogResult == DialogResult.OK)
            {
                institute.Add(new Professor(addProfessorWindow.firstNameTextBox.Text, addProfessorWindow.middleNameTextBox.Text,
                  addProfessorWindow.lastNameTextBox.Text, Convert.ToInt32(addProfessorWindow.experienceTextBox.Text),
                  addProfessorWindow.cathedraTextBox.Text, addProfessorWindow.textBoxSubject.Text));

                ShowAllPersons();
            }
        }

        private void AddHeadOfCathedraButton_Click(object sender, EventArgs e)
        {
            AddHeadOfCathedraWindow addHeadOfCathedraWindow = new AddHeadOfCathedraWindow();
            addHeadOfCathedraWindow.ShowDialog();

            if (addHeadOfCathedraWindow.DialogResult == DialogResult.OK)
            {
                institute.Add(new HeadOfCathedra(addHeadOfCathedraWindow.firstNameTextBox.Text, addHeadOfCathedraWindow.middleNameTextBox.Text,
                addHeadOfCathedraWindow.lastNameTextBox.Text, Convert.ToInt32(addHeadOfCathedraWindow.experienceTextBox.Text),
                addHeadOfCathedraWindow.cathedraTextBox.Text, addHeadOfCathedraWindow.textBoxSubject.Text, Convert.ToInt32(addHeadOfCathedraWindow.numberOfPublishesTextBox.Text)));

                ShowAllPersons();
            }
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
                    MessageBox.Show("Некорректный средний балл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выбранный человек не является студентом", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Некорректный стаж.\t\nСтаж может находиться в интервале [0; " + Globals.maxExperience + ')',
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    v.Clear();
                }
            }
            else
            {
                MessageBox.Show("Выбранный человек не является преподавателем", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Некорректное количество публикаций.\t\nЗначение должно находиться в промежутке [0; " + Globals.maxPublications + ']'
                        , "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    v.Clear();
                }
            }
            else
            {
                MessageBox.Show("Выбранный человек не является заведующим кафедрой", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Неверный формат фамилии", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                if (professor.LastName == DebtProfessor && professor.Subject == student.Debt) match = true;
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
                                MessageBox.Show("Нет преподавателя с такой фамилией по такому предмету", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Нет преподавателя с такой фамилией", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxDebt.Clear();
                        }
                    }
                }
                else MessageBox.Show("У данного студента нет долгов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выбранный человек не является студентом", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Неверный формат названия предмета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Выбранный человек не является студентом", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Setprofessor_Click(object sender, EventArgs e)
        {
            bool match, match_total = false, unmatch_total = false;
            bool v1 = false, v2 = false, v3 = false;
            if (institute.Count == 0)
            {
                MessageBox.Show("В институте нет преподавателей и студентов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int index = 0; index <= institute.Count - 1; index++)
                {
                    match = false;
                    if (institute.GetPerson(index) is Student)
                    {
                        v1 = true;
                        Student student = (Student)institute.GetPerson(index);
                        if (student.Debt != null)
                        {
                            v2 = true;
                            if (student.DebtProfessor == null)
                            {
                                v3 = true;
                                string debt = student.Debt;

                                int i = 0;
                                Professor professor = null;
                                while (i <= institute.Count - 1 && !match)
                                {
                                    if (institute.GetPerson(i) is Professor)
                                    {
                                        professor = (Professor)institute.GetPerson(i);
                                        if (professor.Subject == debt)
                                        {
                                            match = true;
                                            match_total = true;
                                        }
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
                                    unmatch_total = true;
                                    MessageBox.Show("Нет преподавателя по предмету \"" + debt + "\"" + ", по которому задолженность у студента - "
                                        + student.LastName, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    textBoxDebt.Clear();
                                }
                            }
                        }
                    }
                }
                if (!v1) MessageBox.Show("В институте нет студентов", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (v1 && !v2) MessageBox.Show("В институте нет студентов с долгами", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (v2 && !v3) MessageBox.Show("В институте нет студентов-должников, у которых не назначены преподаватели на пересдачу", "",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (v1 && v2 && v3 && match_total && !unmatch_total) MessageBox.Show("Преподаватели на пересдачу успешно назначены", "",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (v1 && v2 && v3 && match_total && unmatch_total) MessageBox.Show("Преподаватели на пересдачу успешно назначены" +
                    " \nтем студентам, для которых по их предметам с задолженностями удалось найти преподавателей с таким же предметом ", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
