namespace Tyuiu.BerezkinAA.Sprint6.Task3.V25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_BAA = new GroupBox();
            labelTask_BAA = new Label();
            dataGridViewMatrix_BAA = new DataGridView();
            buttonStart_BAA = new Button();
            buttonHelp_BAA = new Button();
            groupBoxOutPut_BAA = new GroupBox();
            labelResult_Baa = new Label();
            groupBoxCondition_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BAA).BeginInit();
            groupBoxOutPut_BAA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_BAA
            // 
            groupBoxCondition_BAA.Controls.Add(labelTask_BAA);
            groupBoxCondition_BAA.Location = new Point(23, 21);
            groupBoxCondition_BAA.Name = "groupBoxCondition_BAA";
            groupBoxCondition_BAA.Size = new Size(395, 298);
            groupBoxCondition_BAA.TabIndex = 0;
            groupBoxCondition_BAA.TabStop = false;
            groupBoxCondition_BAA.Text = "Условие";
            // 
            // labelTask_BAA
            // 
            labelTask_BAA.AutoSize = true;
            labelTask_BAA.Location = new Point(6, 28);
            labelTask_BAA.Name = "labelTask_BAA";
            labelTask_BAA.Size = new Size(335, 195);
            labelTask_BAA.TabIndex = 0;
            labelTask_BAA.Text = resources.GetString("labelTask_BAA.Text");
            // 
            // dataGridViewMatrix_BAA
            // 
            dataGridViewMatrix_BAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_BAA.ColumnHeadersVisible = false;
            dataGridViewMatrix_BAA.Location = new Point(6, 37);
            dataGridViewMatrix_BAA.Name = "dataGridViewMatrix_BAA";
            dataGridViewMatrix_BAA.RowHeadersVisible = false;
            dataGridViewMatrix_BAA.Size = new Size(240, 215);
            dataGridViewMatrix_BAA.TabIndex = 1;
            // 
            // buttonStart_BAA
            // 
            buttonStart_BAA.Location = new Point(472, 281);
            buttonStart_BAA.Name = "buttonStart_BAA";
            buttonStart_BAA.Size = new Size(94, 27);
            buttonStart_BAA.TabIndex = 1;
            buttonStart_BAA.Text = "Выполнить";
            buttonStart_BAA.UseVisualStyleBackColor = true;
            buttonStart_BAA.Click += buttonStart_BAA_Click;
            // 
            // buttonHelp_BAA
            // 
            buttonHelp_BAA.Location = new Point(440, 283);
            buttonHelp_BAA.Name = "buttonHelp_BAA";
            buttonHelp_BAA.Size = new Size(26, 23);
            buttonHelp_BAA.TabIndex = 2;
            buttonHelp_BAA.Text = "?";
            buttonHelp_BAA.UseVisualStyleBackColor = true;
            buttonHelp_BAA.Click += buttonHelp_BAA_Click;
            // 
            // groupBoxOutPut_BAA
            // 
            groupBoxOutPut_BAA.Controls.Add(dataGridViewMatrix_BAA);
            groupBoxOutPut_BAA.Controls.Add(labelResult_Baa);
            groupBoxOutPut_BAA.Location = new Point(434, 12);
            groupBoxOutPut_BAA.Name = "groupBoxOutPut_BAA";
            groupBoxOutPut_BAA.Size = new Size(251, 261);
            groupBoxOutPut_BAA.TabIndex = 3;
            groupBoxOutPut_BAA.TabStop = false;
            groupBoxOutPut_BAA.Text = "Вывод данных";
            // 
            // labelResult_Baa
            // 
            labelResult_Baa.AutoSize = true;
            labelResult_Baa.Location = new Point(6, 19);
            labelResult_Baa.Name = "labelResult_Baa";
            labelResult_Baa.Size = new Size(63, 15);
            labelResult_Baa.TabIndex = 1;
            labelResult_Baa.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 331);
            Controls.Add(groupBoxOutPut_BAA);
            Controls.Add(buttonHelp_BAA);
            Controls.Add(buttonStart_BAA);
            Controls.Add(groupBoxCondition_BAA);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 25 | Березкин А.А.";
            Load += FormMain_Load;
            groupBoxCondition_BAA.ResumeLayout(false);
            groupBoxCondition_BAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BAA).EndInit();
            groupBoxOutPut_BAA.ResumeLayout(false);
            groupBoxOutPut_BAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_BAA;
        private Label labelTask_BAA;
        private Button buttonStart_BAA;
        private Button buttonHelp_BAA;
        private DataGridView dataGridViewMatrix_BAA;
        private GroupBox groupBoxOutPut_BAA;
        private Label labelResult_Baa;
    }
}
