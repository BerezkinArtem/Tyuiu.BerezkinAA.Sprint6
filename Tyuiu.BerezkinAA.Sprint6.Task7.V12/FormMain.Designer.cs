namespace Tyuiu.BerezkinAA.Sprint6.Task7.V12
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
            buttonOpen_BAA = new Button();
            buttonStart_BAA = new Button();
            buttonSave_BAA = new Button();
            buttonInfo_BAA = new Button();
            groupBoxCondition_BAA = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBoxInPut_BAA = new GroupBox();
            DataGridViewInPut_BAA = new DataGridView();
            groupBoxOutPut_BAA = new GroupBox();
            DataGridViewOutPut_BAA = new DataGridView();
            openFileDialog_BAA = new OpenFileDialog();
            saveFileDialog_BAA = new SaveFileDialog();
            groupBoxCondition_BAA.SuspendLayout();
            groupBoxInPut_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInPut_BAA).BeginInit();
            groupBoxOutPut_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOutPut_BAA).BeginInit();
            SuspendLayout();
            // 
            // buttonOpen_BAA
            // 
            buttonOpen_BAA.Image = Properties.Resources.icons8_файловый_проводник_новый_48;
            buttonOpen_BAA.Location = new Point(12, 12);
            buttonOpen_BAA.Name = "buttonOpen_BAA";
            buttonOpen_BAA.Size = new Size(84, 67);
            buttonOpen_BAA.TabIndex = 0;
            buttonOpen_BAA.UseVisualStyleBackColor = true;
            buttonOpen_BAA.Click += buttonOpen_BAA_Click;
            // 
            // buttonStart_BAA
            // 
            buttonStart_BAA.Image = Properties.Resources.EXE_29677;
            buttonStart_BAA.Location = new Point(102, 12);
            buttonStart_BAA.Name = "buttonStart_BAA";
            buttonStart_BAA.Size = new Size(84, 67);
            buttonStart_BAA.TabIndex = 1;
            buttonStart_BAA.UseVisualStyleBackColor = true;
            buttonStart_BAA.Click += buttonStart_BAA_Click;
            // 
            // buttonSave_BAA
            // 
            buttonSave_BAA.Image = (Image)resources.GetObject("buttonSave_BAA.Image");
            buttonSave_BAA.Location = new Point(192, 12);
            buttonSave_BAA.Name = "buttonSave_BAA";
            buttonSave_BAA.Size = new Size(84, 67);
            buttonSave_BAA.TabIndex = 2;
            buttonSave_BAA.UseVisualStyleBackColor = true;
            buttonSave_BAA.Click += buttonSave_BAA_Click;
            // 
            // buttonInfo_BAA
            // 
            buttonInfo_BAA.Image = (Image)resources.GetObject("buttonInfo_BAA.Image");
            buttonInfo_BAA.Location = new Point(742, 12);
            buttonInfo_BAA.Name = "buttonInfo_BAA";
            buttonInfo_BAA.Size = new Size(84, 67);
            buttonInfo_BAA.TabIndex = 3;
            buttonInfo_BAA.UseVisualStyleBackColor = true;
            buttonInfo_BAA.Click += buttonInfo_BAA_Click;
            // 
            // groupBoxCondition_BAA
            // 
            groupBoxCondition_BAA.Controls.Add(label1);
            groupBoxCondition_BAA.Controls.Add(textBox1);
            groupBoxCondition_BAA.Location = new Point(12, 85);
            groupBoxCondition_BAA.Name = "groupBoxCondition_BAA";
            groupBoxCondition_BAA.Size = new Size(814, 74);
            groupBoxCondition_BAA.TabIndex = 4;
            groupBoxCondition_BAA.TabStop = false;
            groupBoxCondition_BAA.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(670, 45);
            label1.TabIndex = 8;
            label1.Text = resources.GetString("label1.Text");
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(802, 87);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxInPut_BAA
            // 
            groupBoxInPut_BAA.Controls.Add(DataGridViewInPut_BAA);
            groupBoxInPut_BAA.Location = new Point(12, 191);
            groupBoxInPut_BAA.Name = "groupBoxInPut_BAA";
            groupBoxInPut_BAA.Size = new Size(375, 395);
            groupBoxInPut_BAA.TabIndex = 5;
            groupBoxInPut_BAA.TabStop = false;
            groupBoxInPut_BAA.Text = "Ввод";
            // 
            // DataGridViewInPut_BAA
            // 
            DataGridViewInPut_BAA.AllowUserToResizeColumns = false;
            DataGridViewInPut_BAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewInPut_BAA.ColumnHeadersVisible = false;
            DataGridViewInPut_BAA.Location = new Point(6, 22);
            DataGridViewInPut_BAA.Name = "DataGridViewInPut_BAA";
            DataGridViewInPut_BAA.RowHeadersVisible = false;
            DataGridViewInPut_BAA.Size = new Size(330, 330);
            DataGridViewInPut_BAA.TabIndex = 0;
            // 
            // groupBoxOutPut_BAA
            // 
            groupBoxOutPut_BAA.Controls.Add(DataGridViewOutPut_BAA);
            groupBoxOutPut_BAA.Location = new Point(449, 191);
            groupBoxOutPut_BAA.Name = "groupBoxOutPut_BAA";
            groupBoxOutPut_BAA.Size = new Size(371, 395);
            groupBoxOutPut_BAA.TabIndex = 6;
            groupBoxOutPut_BAA.TabStop = false;
            groupBoxOutPut_BAA.Text = "Вывод";
            // 
            // DataGridViewOutPut_BAA
            // 
            DataGridViewOutPut_BAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewOutPut_BAA.ColumnHeadersVisible = false;
            DataGridViewOutPut_BAA.Location = new Point(6, 22);
            DataGridViewOutPut_BAA.Name = "DataGridViewOutPut_BAA";
            DataGridViewOutPut_BAA.RowHeadersVisible = false;
            DataGridViewOutPut_BAA.Size = new Size(330, 330);
            DataGridViewOutPut_BAA.TabIndex = 0;
            // 
            // openFileDialog_BAA
            // 
            openFileDialog_BAA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 585);
            Controls.Add(groupBoxOutPut_BAA);
            Controls.Add(groupBoxInPut_BAA);
            Controls.Add(groupBoxCondition_BAA);
            Controls.Add(buttonInfo_BAA);
            Controls.Add(buttonSave_BAA);
            Controls.Add(buttonStart_BAA);
            Controls.Add(buttonOpen_BAA);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 12 | Березкин А.А.";
            Load += FormMain_Load;
            groupBoxCondition_BAA.ResumeLayout(false);
            groupBoxCondition_BAA.PerformLayout();
            groupBoxInPut_BAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewInPut_BAA).EndInit();
            groupBoxOutPut_BAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewOutPut_BAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen_BAA;
        private Button buttonStart_BAA;
        private Button buttonSave_BAA;
        private Button buttonInfo_BAA;
        private GroupBox groupBoxCondition_BAA;
        private GroupBox groupBoxInPut_BAA;
        private DataGridView DataGridViewInPut_BAA;
        private GroupBox groupBoxOutPut_BAA;
        private DataGridView DataGridViewOutPut_BAA;
        private TextBox textBox1;
        private OpenFileDialog openFileDialog_BAA;
        private SaveFileDialog saveFileDialog_BAA;
        private Label label1;
    }
}