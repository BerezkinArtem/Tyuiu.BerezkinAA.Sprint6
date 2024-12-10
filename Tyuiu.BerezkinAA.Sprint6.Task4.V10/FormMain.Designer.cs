namespace Tyuiu.BerezkinAA.Sprint6.Task4.V10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonStart_BAA = new Button();
            groupBoxInPut_BAA = new GroupBox();
            textBoxStop_BAA = new TextBox();
            textBoxStart_BAA = new TextBox();
            labelStop_BAA = new Label();
            labelStart_BAA = new Label();
            groupBoxCondition_BAA = new GroupBox();
            labelResult_BAA = new Label();
            groupBoxOutPut_BAA = new GroupBox();
            textBoxResult_BAA = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonHelp_BAA = new Button();
            buttonSave_BAA = new Button();
            groupBoxInPut_BAA.SuspendLayout();
            groupBoxCondition_BAA.SuspendLayout();
            groupBoxOutPut_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            buttonStart_BAA.Location = new Point(675, 47);
            buttonStart_BAA.Name = "button1";
            buttonStart_BAA.Size = new Size(143, 48);
            buttonStart_BAA.TabIndex = 10;
            buttonStart_BAA.Text = "Выполнить";
            buttonStart_BAA.UseVisualStyleBackColor = true;
            buttonStart_BAA.Click += buttonStart_BAA_Click;
            // 
            // groupBoxOutPut_BAA
            // 
            groupBoxInPut_BAA.Controls.Add(textBoxStop_BAA);
            groupBoxInPut_BAA.Controls.Add(textBoxStart_BAA);
            groupBoxInPut_BAA.Controls.Add(labelStop_BAA);
            groupBoxInPut_BAA.Controls.Add(labelStart_BAA);
            groupBoxInPut_BAA.Location = new Point(370, 6);
            groupBoxInPut_BAA.Name = "groupBox3";
            groupBoxInPut_BAA.Size = new Size(299, 99);
            groupBoxInPut_BAA.TabIndex = 9;
            groupBoxInPut_BAA.TabStop = false;
            groupBoxInPut_BAA.Text = "Ввод данных";
            // 
            // textBox2
            // 
            textBoxStop_BAA.Location = new Point(140, 62);
            textBoxStop_BAA.Name = "textBox2";
            textBoxStop_BAA.Size = new Size(125, 27);
            textBoxStop_BAA.TabIndex = 3;
            // 
            // textBoxStart_BAA
            // 
            textBoxStart_BAA.Location = new Point(9, 62);
            textBoxStart_BAA.Name = "textBox1";
            textBoxStart_BAA.Size = new Size(125, 27);
            textBoxStart_BAA.TabIndex = 2;
            // 
            // label4
            // 
            labelStop_BAA.AutoSize = true;
            labelStop_BAA.Location = new Point(140, 41);
            labelStop_BAA.Name = "label4";
            labelStop_BAA.Size = new Size(53, 20);
            labelStop_BAA.TabIndex = 1;
            labelStop_BAA.Text = "Конец";
            // 
            // labelStart_BAA
            // 
            labelStart_BAA.AutoSize = true;
            labelStart_BAA.Location = new Point(9, 41);
            labelStart_BAA.Name = "label1";
            labelStart_BAA.Size = new Size(47, 20);
            labelStart_BAA.TabIndex = 0;
            labelStart_BAA.Text = "Старт";
            // 
            // groupBoxCondition_BAA
            // 
            groupBoxCondition_BAA.Controls.Add(labelResult_BAA);
            groupBoxCondition_BAA.Location = new Point(5, 6);
            groupBoxCondition_BAA.Name = "groupBox1";
            groupBoxCondition_BAA.Size = new Size(345, 99);
            groupBoxCondition_BAA.TabIndex = 8;
            groupBoxCondition_BAA.TabStop = false;
            groupBoxCondition_BAA.Text = "Условие";
            // 
            // labelResult_BAA
            // 
            labelResult_BAA.AutoSize = true;
            labelResult_BAA.Location = new Point(12, 41);
            labelResult_BAA.Name = "label2";
            labelResult_BAA.Size = new Size(209, 20);
            labelResult_BAA.TabIndex = 0;
            labelResult_BAA.Text = "Результат вывести в таблице";
            // 
            // groupBoxOutPut_BAA
            // 
            groupBoxOutPut_BAA.Controls.Add(textBoxResult_BAA);
            groupBoxOutPut_BAA.Location = new Point(5, 111);
            groupBoxOutPut_BAA.Name = "groupBox2";
            groupBoxOutPut_BAA.Size = new Size(345, 444);
            groupBoxOutPut_BAA.TabIndex = 11;
            groupBoxOutPut_BAA.TabStop = false;
            groupBoxOutPut_BAA.Text = "Вывод данных";
            // 
            // textBox3
            // 
            textBoxResult_BAA.Location = new Point(16, 33);
            textBoxResult_BAA.Multiline = true;
            textBoxResult_BAA.Name = "textBox3";
            textBoxResult_BAA.Size = new Size(312, 405);
            textBoxResult_BAA.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(370, 111);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(719, 444);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // button2
            // 
            buttonHelp_BAA.Location = new Point(824, 47);
            buttonHelp_BAA.Name = "buttonHelp_BAA";
            buttonHelp_BAA.Size = new Size(143, 48);
            buttonHelp_BAA.TabIndex = 12;
            buttonHelp_BAA.Text = "Справка";
            buttonHelp_BAA.UseVisualStyleBackColor = true;
            buttonHelp_BAA.Click += buttonHelp_BAA_Click;
            // 
            // buttonSave_BAA
            // 
            buttonSave_BAA.Location = new Point(973, 47);
            buttonSave_BAA.Name = "button3";
            buttonSave_BAA.Size = new Size(143, 48);
            buttonSave_BAA.TabIndex = 13;
            buttonSave_BAA.Text = "Сохранить";
            buttonSave_BAA.UseVisualStyleBackColor = true;
            buttonSave_BAA.Click += buttonSave_BAA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 567);
            Controls.Add(chart1);
            Controls.Add(buttonSave_BAA);
            Controls.Add(buttonHelp_BAA);
            Controls.Add(buttonStart_BAA);
            Controls.Add(groupBoxInPut_BAA);
            Controls.Add(groupBoxCondition_BAA);
            Controls.Add(groupBoxOutPut_BAA);
            Name = "FormMain";
            Text = "Form1";
            groupBoxInPut_BAA.ResumeLayout(false);
            groupBoxInPut_BAA.PerformLayout();
            groupBoxCondition_BAA.ResumeLayout(false);
            groupBoxCondition_BAA.PerformLayout();
            groupBoxOutPut_BAA.ResumeLayout(false);
            groupBoxOutPut_BAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart_BAA;
        private GroupBox groupBoxInPut_BAA;
        private TextBox textBoxStop_BAA;
        private TextBox textBoxStart_BAA;
        private Label labelStop_BAA;
        private Label labelStart_BAA;
        private GroupBox groupBoxCondition_BAA;
        private Label labelResult_BAA;
        private GroupBox groupBoxOutPut_BAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button buttonHelp_BAA;
        private Button buttonSave_BAA;
        private TextBox textBoxResult_BAA;
    }
}