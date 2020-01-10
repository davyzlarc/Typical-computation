namespace Lab8
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.changeAverageMarkButton = new System.Windows.Forms.Button();
            this.changeNumOfPublishesButton = new System.Windows.Forms.Button();
            this.changeExperienceButton = new System.Windows.Forms.Button();
            this.addProfessorButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.addHeadOfCathedraButton = new System.Windows.Forms.Button();
            this.removePersonButton = new System.Windows.Forms.Button();
            this.infoListBox = new System.Windows.Forms.ListBox();
            this.newValueLabel = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.TextBox();
            this.addDebt = new System.Windows.Forms.Button();
            this.changeDebtProfessor = new System.Windows.Forms.Button();
            this.debt_label = new System.Windows.Forms.Label();
            this.textBoxDebt = new System.Windows.Forms.TextBox();
            this.setprofessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeAverageMarkButton
            // 
            this.changeAverageMarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.changeAverageMarkButton.Location = new System.Drawing.Point(277, 348);
            this.changeAverageMarkButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeAverageMarkButton.Name = "changeAverageMarkButton";
            this.changeAverageMarkButton.Size = new System.Drawing.Size(204, 49);
            this.changeAverageMarkButton.TabIndex = 4;
            this.changeAverageMarkButton.Text = "Изменить средний балл студента";
            this.changeAverageMarkButton.UseVisualStyleBackColor = true;
            this.changeAverageMarkButton.Click += new System.EventHandler(this.changeAverageMarkButton_Click);
            // 
            // changeNumOfPublishesButton
            // 
            this.changeNumOfPublishesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.changeNumOfPublishesButton.Location = new System.Drawing.Point(747, 348);
            this.changeNumOfPublishesButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeNumOfPublishesButton.Name = "changeNumOfPublishesButton";
            this.changeNumOfPublishesButton.Size = new System.Drawing.Size(204, 49);
            this.changeNumOfPublishesButton.TabIndex = 6;
            this.changeNumOfPublishesButton.Text = "Изменить количество публикаций зав. кафедрой";
            this.changeNumOfPublishesButton.UseVisualStyleBackColor = true;
            this.changeNumOfPublishesButton.Click += new System.EventHandler(this.changeNumOfPublishesButton_Click);
            // 
            // changeExperienceButton
            // 
            this.changeExperienceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.changeExperienceButton.Location = new System.Drawing.Point(512, 348);
            this.changeExperienceButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeExperienceButton.Name = "changeExperienceButton";
            this.changeExperienceButton.Size = new System.Drawing.Size(204, 49);
            this.changeExperienceButton.TabIndex = 5;
            this.changeExperienceButton.Text = "Изменить стаж преподавателя";
            this.changeExperienceButton.UseVisualStyleBackColor = true;
            this.changeExperienceButton.Click += new System.EventHandler(this.changeExperienceButton_Click);
            // 
            // addProfessorButton
            // 
            this.addProfessorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProfessorButton.Location = new System.Drawing.Point(512, 275);
            this.addProfessorButton.Margin = new System.Windows.Forms.Padding(2);
            this.addProfessorButton.Name = "addProfessorButton";
            this.addProfessorButton.Size = new System.Drawing.Size(204, 36);
            this.addProfessorButton.TabIndex = 2;
            this.addProfessorButton.Text = "Добавить преподавателя";
            this.addProfessorButton.UseVisualStyleBackColor = true;
            this.addProfessorButton.Click += new System.EventHandler(this.addProfessorButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudentButton.Location = new System.Drawing.Point(277, 275);
            this.addStudentButton.Margin = new System.Windows.Forms.Padding(2);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(204, 36);
            this.addStudentButton.TabIndex = 1;
            this.addStudentButton.Text = "Добавить студента";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // addHeadOfCathedraButton
            // 
            this.addHeadOfCathedraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addHeadOfCathedraButton.Location = new System.Drawing.Point(747, 275);
            this.addHeadOfCathedraButton.Margin = new System.Windows.Forms.Padding(2);
            this.addHeadOfCathedraButton.Name = "addHeadOfCathedraButton";
            this.addHeadOfCathedraButton.Size = new System.Drawing.Size(204, 36);
            this.addHeadOfCathedraButton.TabIndex = 3;
            this.addHeadOfCathedraButton.Text = "Добавить зав. кафедрой";
            this.addHeadOfCathedraButton.UseVisualStyleBackColor = true;
            this.addHeadOfCathedraButton.Click += new System.EventHandler(this.addHeadOfCathedraButton_Click);
            // 
            // removePersonButton
            // 
            this.removePersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removePersonButton.Location = new System.Drawing.Point(27, 275);
            this.removePersonButton.Margin = new System.Windows.Forms.Padding(2);
            this.removePersonButton.Name = "removePersonButton";
            this.removePersonButton.Size = new System.Drawing.Size(216, 36);
            this.removePersonButton.TabIndex = 10;
            this.removePersonButton.Text = "Исключить из интститута";
            this.removePersonButton.UseVisualStyleBackColor = true;
            this.removePersonButton.Click += new System.EventHandler(this.removePersonButton_Click);
            // 
            // infoListBox
            // 
            this.infoListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoListBox.Font = new System.Drawing.Font("Calibri", 10F);
            this.infoListBox.FormattingEnabled = true;
            this.infoListBox.HorizontalScrollbar = true;
            this.infoListBox.ItemHeight = 15;
            this.infoListBox.Location = new System.Drawing.Point(0, 0);
            this.infoListBox.Margin = new System.Windows.Forms.Padding(2);
            this.infoListBox.Name = "infoListBox";
            this.infoListBox.Size = new System.Drawing.Size(977, 244);
            this.infoListBox.TabIndex = 9;
            // 
            // newValueLabel
            // 
            this.newValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.newValueLabel.Location = new System.Drawing.Point(29, 339);
            this.newValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newValueLabel.Name = "newValueLabel";
            this.newValueLabel.Size = new System.Drawing.Size(214, 37);
            this.newValueLabel.TabIndex = 13;
            this.newValueLabel.Text = "Новое значение среднего балла/стажа/числа публикаций:";
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(32, 379);
            this.v.Margin = new System.Windows.Forms.Padding(2);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(211, 20);
            this.v.TabIndex = 11;
            // 
            // addDebt
            // 
            this.addDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addDebt.Location = new System.Drawing.Point(277, 422);
            this.addDebt.Margin = new System.Windows.Forms.Padding(2);
            this.addDebt.Name = "addDebt";
            this.addDebt.Size = new System.Drawing.Size(204, 49);
            this.addDebt.TabIndex = 7;
            this.addDebt.Text = "Добавить/удалить задолженность студента";
            this.addDebt.UseVisualStyleBackColor = true;
            this.addDebt.Click += new System.EventHandler(this.AddDebt_Click);
            // 
            // changeDebtProfessor
            // 
            this.changeDebtProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.changeDebtProfessor.Location = new System.Drawing.Point(747, 422);
            this.changeDebtProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.changeDebtProfessor.Name = "changeDebtProfessor";
            this.changeDebtProfessor.Size = new System.Drawing.Size(204, 49);
            this.changeDebtProfessor.TabIndex = 9;
            this.changeDebtProfessor.Text = "Изменить преподавателя, принимающего пересдачу";
            this.changeDebtProfessor.UseVisualStyleBackColor = true;
            this.changeDebtProfessor.Click += new System.EventHandler(this.ChangeDebtProfessor_Click);
            // 
            // debt_label
            // 
            this.debt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.debt_label.Location = new System.Drawing.Point(29, 402);
            this.debt_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debt_label.Name = "debt_label";
            this.debt_label.Size = new System.Drawing.Size(231, 36);
            this.debt_label.TabIndex = 14;
            this.debt_label.Text = "Задолженность по предмету/фамилия преподавателя:";
            // 
            // textBoxDebt
            // 
            this.textBoxDebt.Location = new System.Drawing.Point(32, 440);
            this.textBoxDebt.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDebt.Name = "textBoxDebt";
            this.textBoxDebt.Size = new System.Drawing.Size(211, 20);
            this.textBoxDebt.TabIndex = 12;
            // 
            // setprofessor
            // 
            this.setprofessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.setprofessor.Location = new System.Drawing.Point(511, 422);
            this.setprofessor.Margin = new System.Windows.Forms.Padding(2);
            this.setprofessor.Name = "setprofessor";
            this.setprofessor.Size = new System.Drawing.Size(204, 49);
            this.setprofessor.TabIndex = 8;
            this.setprofessor.Text = "Назначить автоматически преподавателей на пересдачу";
            this.setprofessor.UseVisualStyleBackColor = true;
            this.setprofessor.Click += new System.EventHandler(this.setprofessor_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 483);
            this.Controls.Add(this.setprofessor);
            this.Controls.Add(this.textBoxDebt);
            this.Controls.Add(this.debt_label);
            this.Controls.Add(this.changeDebtProfessor);
            this.Controls.Add(this.addDebt);
            this.Controls.Add(this.v);
            this.Controls.Add(this.newValueLabel);
            this.Controls.Add(this.infoListBox);
            this.Controls.Add(this.removePersonButton);
            this.Controls.Add(this.addHeadOfCathedraButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.addProfessorButton);
            this.Controls.Add(this.changeExperienceButton);
            this.Controls.Add(this.changeNumOfPublishesButton);
            this.Controls.Add(this.changeAverageMarkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Типовой расчет - Карелин Влад , группа А-08-18";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button changeAverageMarkButton;
        private System.Windows.Forms.Button changeNumOfPublishesButton;
        private System.Windows.Forms.Button changeExperienceButton;
        private System.Windows.Forms.Button addProfessorButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button addHeadOfCathedraButton;
        private System.Windows.Forms.Button removePersonButton;
        private System.Windows.Forms.ListBox infoListBox;
        private System.Windows.Forms.Label newValueLabel;
        private System.Windows.Forms.TextBox v;
        private System.Windows.Forms.Button addDebt;
        private System.Windows.Forms.Button changeDebtProfessor;
        private System.Windows.Forms.Label debt_label;
        private System.Windows.Forms.TextBox textBoxDebt;
        private System.Windows.Forms.Button setprofessor;
    }
}

