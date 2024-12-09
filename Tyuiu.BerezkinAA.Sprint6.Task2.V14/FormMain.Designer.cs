namespace Tyuiu.BerezkinAA.Sprint6.Task2.V14
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
            groupBoxCondition_BAA = new GroupBox();
            labelTask_BAA = new Label();
            groupBoxInPut_BAA = new GroupBox();
            textBoxStop_BAA = new TextBox();
            textBoxStart_BAA = new TextBox();
            labelStopStep_BAA = new Label();
            labelStartStep_BAA = new Label();
            groupBoxOutPut_BAA = new GroupBox();
            dataGridViewFunction_BAA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            buttonStart_BAA = new Button();
            buttonHelp_BAA = new Button();
            groupBoxCondition_BAA.SuspendLayout();
            groupBoxInPut_BAA.SuspendLayout();
            groupBoxOutPut_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_BAA
            // 
            groupBoxCondition_BAA.Controls.Add(labelTask_BAA);
            groupBoxCondition_BAA.Location = new Point(28, 29);
            groupBoxCondition_BAA.Name = "groupBoxCondition_BAA";
            groupBoxCondition_BAA.Size = new Size(402, 256);
            groupBoxCondition_BAA.TabIndex = 0;
            groupBoxCondition_BAA.TabStop = false;
            groupBoxCondition_BAA.Text = "Условие";
            // 
            // labelTask_BAA
            // 
            labelTask_BAA.AutoSize = true;
            labelTask_BAA.Location = new Point(5, 33);
            labelTask_BAA.Name = "labelTask_BAA";
            labelTask_BAA.Size = new Size(365, 30);
            labelTask_BAA.TabIndex = 0;
            labelTask_BAA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGriedView и построить график функции.";
            labelTask_BAA.Click += label1_Click;
            // 
            // groupBoxInPut_BAA
            // 
            groupBoxInPut_BAA.Controls.Add(textBoxStop_BAA);
            groupBoxInPut_BAA.Controls.Add(textBoxStart_BAA);
            groupBoxInPut_BAA.Controls.Add(labelStopStep_BAA);
            groupBoxInPut_BAA.Controls.Add(labelStartStep_BAA);
            groupBoxInPut_BAA.Location = new Point(28, 305);
            groupBoxInPut_BAA.Name = "groupBoxInPut_BAA";
            groupBoxInPut_BAA.Size = new Size(286, 102);
            groupBoxInPut_BAA.TabIndex = 1;
            groupBoxInPut_BAA.TabStop = false;
            groupBoxInPut_BAA.Text = "Ввод данных:";
            // 
            // textBoxStop_BAA
            // 
            textBoxStop_BAA.Location = new Point(129, 59);
            textBoxStop_BAA.Name = "textBoxStop_BAA";
            textBoxStop_BAA.Size = new Size(70, 23);
            textBoxStop_BAA.TabIndex = 3;
            textBoxStop_BAA.TextChanged += textBox2_TextChanged;
            // 
            // textBoxStart_BAA
            // 
            textBoxStart_BAA.Location = new Point(5, 59);
            textBoxStart_BAA.Name = "textBoxStart_BAA";
            textBoxStart_BAA.Size = new Size(70, 23);
            textBoxStart_BAA.TabIndex = 2;
            textBoxStart_BAA.TextChanged += textBox1_TextChanged;
            // 
            // labelStopStep_BAA
            // 
            labelStopStep_BAA.AutoSize = true;
            labelStopStep_BAA.Location = new Point(127, 30);
            labelStopStep_BAA.Name = "labelStopStep_BAA";
            labelStopStep_BAA.Size = new Size(72, 15);
            labelStopStep_BAA.TabIndex = 1;
            labelStopStep_BAA.Text = "Конец шага";
            labelStopStep_BAA.Click += label3_Click;
            // 
            // labelStartStep_BAA
            // 
            labelStartStep_BAA.AutoSize = true;
            labelStartStep_BAA.Location = new Point(6, 30);
            labelStartStep_BAA.Name = "labelStartStep_BAA";
            labelStartStep_BAA.Size = new Size(69, 15);
            labelStartStep_BAA.TabIndex = 0;
            labelStartStep_BAA.Text = "Старт шага";
            // 
            // groupBoxOutPut_BAA
            // 
            groupBoxOutPut_BAA.Controls.Add(dataGridViewFunction_BAA);
            groupBoxOutPut_BAA.Location = new Point(587, 29);
            groupBoxOutPut_BAA.Name = "groupBoxOutPut_BAA";
            groupBoxOutPut_BAA.Size = new Size(200, 393);
            groupBoxOutPut_BAA.TabIndex = 2;
            groupBoxOutPut_BAA.TabStop = false;
            groupBoxOutPut_BAA.Text = "Вывод данных:";
            groupBoxOutPut_BAA.Enter += groupBox3_Enter;
            // 
            // dataGridViewFunction_BAA
            // 
            dataGridViewFunction_BAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_BAA.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridViewFunction_BAA.Location = new Point(6, 22);
            dataGridViewFunction_BAA.Name = "dataGridViewFunction_BAA";
            dataGridViewFunction_BAA.RowHeadersVisible = false;
            dataGridViewFunction_BAA.Size = new Size(188, 371);
            dataGridViewFunction_BAA.TabIndex = 5;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            // 
            // F
            // 
            F.HeaderText = "F(x)";
            F.Name = "F";
            // 
            // buttonStart_BAA
            // 
            buttonStart_BAA.BackColor = Color.LightGreen;
            buttonStart_BAA.Location = new Point(440, 357);
            buttonStart_BAA.Name = "buttonStart_BAA";
            buttonStart_BAA.Size = new Size(122, 65);
            buttonStart_BAA.TabIndex = 3;
            buttonStart_BAA.Text = "Выполнить";
            buttonStart_BAA.UseVisualStyleBackColor = false;
            buttonStart_BAA.Click += buttonStart_BAA_Click;
            buttonStart_BAA.MouseDown += buttonStart_BAA_MouseDown;
            buttonStart_BAA.MouseEnter += buttonStart_BAA_MouseEnter;
            buttonStart_BAA.MouseLeave += buttonStart_BAA_MouseLeave;
            // 
            // buttonHelp_BAA
            // 
            buttonHelp_BAA.BackColor = SystemColors.ActiveCaption;
            buttonHelp_BAA.Location = new Point(351, 364);
            buttonHelp_BAA.Name = "buttonHelp_BAA";
            buttonHelp_BAA.Size = new Size(79, 50);
            buttonHelp_BAA.TabIndex = 4;
            buttonHelp_BAA.Text = "Справка";
            buttonHelp_BAA.UseVisualStyleBackColor = false;
            buttonHelp_BAA.Click += buttonStop_BAA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 450);
            Controls.Add(buttonHelp_BAA);
            Controls.Add(buttonStart_BAA);
            Controls.Add(groupBoxOutPut_BAA);
            Controls.Add(groupBoxInPut_BAA);
            Controls.Add(groupBoxCondition_BAA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 14 | Березкин А.А.";
            Load += FormMain_Load;
            groupBoxCondition_BAA.ResumeLayout(false);
            groupBoxCondition_BAA.PerformLayout();
            groupBoxInPut_BAA.ResumeLayout(false);
            groupBoxInPut_BAA.PerformLayout();
            groupBoxOutPut_BAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_BAA;
        private Label labelTask_BAA;
        private GroupBox groupBoxInPut_BAA;
        private Label labelStopStep_BAA;
        private Label labelStartStep_BAA;
        private GroupBox groupBoxOutPut_BAA;
        private Button buttonStart_BAA;
        private Button buttonHelp_BAA;
        private TextBox textBoxStop_BAA;
        private TextBox textBoxStart_BAA;
        private DataGridView dataGridViewFunction_BAA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
        
    }
}
