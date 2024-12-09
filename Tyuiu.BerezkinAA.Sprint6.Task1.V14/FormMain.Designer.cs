namespace Tyuiu.BerezkinAA.Sprint6.Task1.V14
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonStart_BAA = new Button();
            groupBoxCondition_BAA = new GroupBox();
            labelCondition_BAA = new Label();
            groupBoxOutput_BAA = new GroupBox();
            textBoxResult_BAA = new TextBox();
            labelGoal_BAA = new Label();
            buttonHelp_BAA = new Button();
            groupBoxInput_BAA = new GroupBox();
            textBoxStopStep_BAA = new TextBox();
            textBoxStartStep_BAA = new TextBox();
            labelStop_BAA = new Label();
            labelStart_BAA = new Label();
            groupBoxCondition_BAA.SuspendLayout();
            groupBoxOutput_BAA.SuspendLayout();
            groupBoxInput_BAA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonStart_BAA
            // 
            buttonStart_BAA.BackColor = Color.FromArgb(128, 255, 128);
            buttonStart_BAA.Location = new Point(395, 366);
            buttonStart_BAA.Name = "buttonStart_BAA";
            buttonStart_BAA.Size = new Size(120, 55);
            buttonStart_BAA.TabIndex = 0;
            buttonStart_BAA.Text = "Выполнить";
            buttonStart_BAA.UseVisualStyleBackColor = false;
            buttonStart_BAA.Click += buttonStart_BAA_Click;
            // 
            // groupBoxCondition_BAA
            // 
            groupBoxCondition_BAA.Controls.Add(labelCondition_BAA);
            groupBoxCondition_BAA.Location = new Point(12, 48);
            groupBoxCondition_BAA.Name = "groupBoxCondition_BAA";
            groupBoxCondition_BAA.Size = new Size(470, 247);
            groupBoxCondition_BAA.TabIndex = 1;
            groupBoxCondition_BAA.TabStop = false;
            groupBoxCondition_BAA.Text = "Условие";
            // 
            // labelCondition_BAA
            // 
            labelCondition_BAA.AutoSize = true;
            labelCondition_BAA.Location = new Point(10, 25);
            labelCondition_BAA.Name = "labelCondition_BAA";
            labelCondition_BAA.Size = new Size(295, 30);
            labelCondition_BAA.TabIndex = 0;
            labelCondition_BAA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // groupBoxOutput_BAA
            // 
            groupBoxOutput_BAA.Controls.Add(textBoxResult_BAA);
            groupBoxOutput_BAA.Controls.Add(labelGoal_BAA);
            groupBoxOutput_BAA.Location = new Point(531, 48);
            groupBoxOutput_BAA.Name = "groupBoxOutput_BAA";
            groupBoxOutput_BAA.Size = new Size(257, 347);
            groupBoxOutput_BAA.TabIndex = 2;
            groupBoxOutput_BAA.TabStop = false;
            groupBoxOutput_BAA.Text = "Вывод данных";
            groupBoxOutput_BAA.Enter += groupBox2_Enter;
            // 
            // textBoxResult_BAA
            // 
            textBoxResult_BAA.Font = new Font("Consolas", 10F);
            textBoxResult_BAA.Location = new Point(6, 26);
            textBoxResult_BAA.Margin = new Padding(3, 2, 3, 2);
            textBoxResult_BAA.Multiline = true;
            textBoxResult_BAA.Name = "textBoxResult_BAA";
            textBoxResult_BAA.ReadOnly = true;
            textBoxResult_BAA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_BAA.Size = new Size(185, 270);
            textBoxResult_BAA.TabIndex = 0;
            // 
            // labelGoal_BAA
            // 
            labelGoal_BAA.AutoSize = true;
            labelGoal_BAA.Location = new Point(6, 25);
            labelGoal_BAA.Name = "labelGoal_BAA";
            labelGoal_BAA.Size = new Size(60, 15);
            labelGoal_BAA.TabIndex = 0;
            labelGoal_BAA.Text = "Результат";
            // 
            // buttonHelp_BAA
            // 
            buttonHelp_BAA.BackColor = Color.FromArgb(128, 255, 255);
            buttonHelp_BAA.Location = new Point(322, 366);
            buttonHelp_BAA.Name = "buttonHelp_BAA";
            buttonHelp_BAA.Size = new Size(67, 55);
            buttonHelp_BAA.TabIndex = 3;
            buttonHelp_BAA.Text = "Справка";
            buttonHelp_BAA.UseVisualStyleBackColor = false;
            buttonHelp_BAA.Click += buttonHelp_BAA_Click_1;
            // 
            // groupBoxInput_BAA
            // 
            groupBoxInput_BAA.Controls.Add(textBoxStopStep_BAA);
            groupBoxInput_BAA.Controls.Add(textBoxStartStep_BAA);
            groupBoxInput_BAA.Controls.Add(labelStop_BAA);
            groupBoxInput_BAA.Controls.Add(labelStart_BAA);
            groupBoxInput_BAA.Location = new Point(22, 301);
            groupBoxInput_BAA.Name = "groupBoxInput_BAA";
            groupBoxInput_BAA.Size = new Size(262, 120);
            groupBoxInput_BAA.TabIndex = 4;
            groupBoxInput_BAA.TabStop = false;
            groupBoxInput_BAA.Text = "Ввод данных:";
            // 
            // textBoxStopStep_BAA
            // 
            textBoxStopStep_BAA.Location = new Point(117, 55);
            textBoxStopStep_BAA.Name = "textBoxStopStep_BAA";
            textBoxStopStep_BAA.Size = new Size(72, 23);
            textBoxStopStep_BAA.TabIndex = 3;
            textBoxStopStep_BAA.TextChanged += textBox2_TextChanged;
            // 
            // textBoxStartStep_BAA
            // 
            textBoxStartStep_BAA.Location = new Point(6, 55);
            textBoxStartStep_BAA.Name = "textBoxStartStep_BAA";
            textBoxStartStep_BAA.Size = new Size(69, 23);
            textBoxStartStep_BAA.TabIndex = 2;
            // 
            // labelStop_BAA
            // 
            labelStop_BAA.AutoSize = true;
            labelStop_BAA.Location = new Point(117, 28);
            labelStop_BAA.Name = "labelStop_BAA";
            labelStop_BAA.Size = new Size(72, 15);
            labelStop_BAA.TabIndex = 1;
            labelStop_BAA.Text = "Конец шага";
            // 
            // labelStart_BAA
            // 
            labelStart_BAA.AutoSize = true;
            labelStart_BAA.Location = new Point(6, 28);
            labelStart_BAA.Name = "labelStart_BAA";
            labelStart_BAA.Size = new Size(69, 15);
            labelStart_BAA.TabIndex = 0;
            labelStart_BAA.Text = "Старт шага";
            labelStart_BAA.Click += label1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxInput_BAA);
            Controls.Add(buttonHelp_BAA);
            Controls.Add(groupBoxOutput_BAA);
            Controls.Add(groupBoxCondition_BAA);
            Controls.Add(buttonStart_BAA);
            Name = "FormMain";
            Text = "Form1";
            groupBoxCondition_BAA.ResumeLayout(false);
            groupBoxCondition_BAA.PerformLayout();
            groupBoxOutput_BAA.ResumeLayout(false);
            groupBoxOutput_BAA.PerformLayout();
            groupBoxInput_BAA.ResumeLayout(false);
            groupBoxInput_BAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart_BAA;
        private GroupBox groupBoxCondition_BAA;
        private GroupBox groupBoxOutput_BAA;
        private Button buttonHelp_BAA;
        private Label labelCondition_BAA;
        private Label labelGoal_BAA;
        private GroupBox groupBoxInput_BAA;
        private Label labelStart_BAA;
        private Label labelStop_BAA;
        private TextBox textBoxStopStep_BAA;
        private TextBox textBoxStartStep_BAA;
        private TextBox textBoxResult_BAA;
    }
}
