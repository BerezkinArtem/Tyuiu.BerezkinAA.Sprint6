namespace Tyuiu.BerezkinAA.Sprint6.Task5.V27
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
            groupBoxCondition_BAA = new GroupBox();
            textBoxCondition_BAA = new TextBox();
            groupBoxOutPut_BAA = new GroupBox();
            dataGridView_BAA = new DataGridView();
            buttonStart_BAA = new Button();
            buttonOpen_BAA = new Button();
            buttonHelp_BAA = new Button();
            chart_BAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCondition_BAA.SuspendLayout();
            groupBoxOutPut_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_BAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_BAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_BAA
            // 
            groupBoxCondition_BAA.Controls.Add(textBoxCondition_BAA);
            groupBoxCondition_BAA.Location = new Point(3, 12);
            groupBoxCondition_BAA.Name = "groupBoxCondition_BAA";
            groupBoxCondition_BAA.Size = new Size(418, 82);
            groupBoxCondition_BAA.TabIndex = 0;
            groupBoxCondition_BAA.TabStop = false;
            groupBoxCondition_BAA.Text = "Условие:";
            // 
            // textBoxCondition_BAA
            // 
            textBoxCondition_BAA.BackColor = SystemColors.MenuBar;
            textBoxCondition_BAA.BorderStyle = BorderStyle.None;
            textBoxCondition_BAA.Location = new Point(6, 22);
            textBoxCondition_BAA.Multiline = true;
            textBoxCondition_BAA.Name = "textBoxCondition_BAA";
            textBoxCondition_BAA.Size = new Size(406, 54);
            textBoxCondition_BAA.TabIndex = 4;
            textBoxCondition_BAA.Text = "Прочитать данные из файла InPutDataFileTask5V27.txt. Вывести в dataGridView. Вывести все числа не кратные 5. Построить диаграмму по этим значениям.";
            // 
            // groupBoxOutPut_BAA
            // 
            groupBoxOutPut_BAA.Controls.Add(dataGridView_BAA);
            groupBoxOutPut_BAA.Location = new Point(3, 100);
            groupBoxOutPut_BAA.Name = "groupBoxOutPut_BAA";
            groupBoxOutPut_BAA.Size = new Size(159, 347);
            groupBoxOutPut_BAA.TabIndex = 0;
            groupBoxOutPut_BAA.TabStop = false;
            groupBoxOutPut_BAA.Text = "Вывод данных:";
            // 
            // dataGridView_BAA
            // 
            dataGridView_BAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView_BAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_BAA.Location = new Point(3, 19);
            dataGridView_BAA.Name = "dataGridView_BAA";
            dataGridView_BAA.Size = new Size(150, 322);
            dataGridView_BAA.TabIndex = 0;
            // 
            // buttonStart_BAA
            // 
            buttonStart_BAA.BackColor = Color.LightCoral;
            buttonStart_BAA.Location = new Point(462, 36);
            buttonStart_BAA.Name = "buttonStart_BAA";
            buttonStart_BAA.Size = new Size(86, 49);
            buttonStart_BAA.TabIndex = 1;
            buttonStart_BAA.Text = "Выполнить";
            buttonStart_BAA.UseVisualStyleBackColor = false;
            // 
            // buttonOpen_BAA
            // 
            buttonOpen_BAA.BackColor = Color.YellowGreen;
            buttonOpen_BAA.Location = new Point(568, 36);
            buttonOpen_BAA.Name = "buttonOpen_BAA";
            buttonOpen_BAA.Size = new Size(86, 49);
            buttonOpen_BAA.TabIndex = 2;
            buttonOpen_BAA.Text = "Открыть файл";
            buttonOpen_BAA.UseVisualStyleBackColor = false;
            buttonOpen_BAA.Click += buttonOpen_BAA_Click;
            // 
            // buttonHelp_BAA
            // 
            buttonHelp_BAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BAA.BackColor = Color.PeachPuff;
            buttonHelp_BAA.Location = new Point(674, 36);
            buttonHelp_BAA.Name = "buttonHelp_BAA";
            buttonHelp_BAA.Size = new Size(86, 49);
            buttonHelp_BAA.TabIndex = 3;
            buttonHelp_BAA.Text = "Справка";
            buttonHelp_BAA.UseVisualStyleBackColor = false;
            buttonHelp_BAA.Click += buttonHelp_BAA_Click;
            // 
            // chart_BAA
            // 
            chart_BAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart_BAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_BAA.Legends.Add(legend1);
            chart_BAA.Location = new Point(168, 100);
            chart_BAA.Name = "chart_BAA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_BAA.Series.Add(series1);
            chart_BAA.Size = new Size(620, 347);
            chart_BAA.TabIndex = 4;
            chart_BAA.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chart_BAA);
            Controls.Add(buttonHelp_BAA);
            Controls.Add(buttonOpen_BAA);
            Controls.Add(buttonStart_BAA);
            Controls.Add(groupBoxOutPut_BAA);
            Controls.Add(groupBoxCondition_BAA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 27 | Березкин .А.А";
            groupBoxCondition_BAA.ResumeLayout(false);
            groupBoxCondition_BAA.PerformLayout();
            groupBoxOutPut_BAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_BAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_BAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_BAA;
        private GroupBox groupBoxOutPut_BAA;
        private Button buttonStart_BAA;
        private Button buttonOpen_BAA;
        private Button buttonHelp_BAA;
        private TextBox textBoxCondition_BAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_BAA;
        private DataGridView dataGridView_BAA;
    }
}