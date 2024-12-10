namespace Tyuiu.BerezkinAA.Sprint6.Task6.V29
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelUP_BAA = new Panel();
            buttonHelp_BAA = new Button();
            buttonLoad_BAA = new Button();
            buttonStart_BAA = new Button();
            groupBoxTask_BAA = new GroupBox();
            textBoxTask_BAA = new TextBox();
            panelFill_BAA = new Panel();
            groupBoxOutput_BAA = new GroupBox();
            textBoxOutput_BAA = new TextBox();
            panelLeft_BAA = new Panel();
            groupBoxInput_BAA = new GroupBox();
            textBoxInput_BAA = new TextBox();
            splitter1 = new Splitter();
            openFileDialog_BAA = new OpenFileDialog();
            toolTipHelp_BAA = new ToolTip(components);
            panelUP_BAA.SuspendLayout();
            groupBoxTask_BAA.SuspendLayout();
            panelFill_BAA.SuspendLayout();
            groupBoxOutput_BAA.SuspendLayout();
            panelLeft_BAA.SuspendLayout();
            groupBoxInput_BAA.SuspendLayout();
            SuspendLayout();
            // 
            // panelUP_MSM
            // 
            panelUP_BAA.Controls.Add(buttonHelp_BAA);
            panelUP_BAA.Controls.Add(buttonLoad_BAA);
            panelUP_BAA.Controls.Add(buttonStart_BAA);
            panelUP_BAA.Controls.Add(groupBoxTask_BAA);
            panelUP_BAA.Dock = DockStyle.Top;
            panelUP_BAA.Location = new Point(0, 0);
            panelUP_BAA.Name = "panelUP_BAA";
            panelUP_BAA.Size = new Size(784, 162);
            panelUP_BAA.TabIndex = 0;
            // 
            // buttonHelp_BAA
            // 
            buttonHelp_BAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BAA.Location = new Point(692, 12);
            buttonHelp_BAA.Name = "buttonHelp_BAA";
            buttonHelp_BAA.Size = new Size(80, 80);
            buttonHelp_BAA.TabIndex = 2;
            buttonHelp_BAA.Text = "Справка";
            toolTipHelp_BAA.SetToolTip(buttonHelp_BAA, "Информация об авторе приложения");
            buttonHelp_BAA.UseVisualStyleBackColor = true;
            buttonHelp_BAA.Click += buttonHelp_BAA_Click;
            // 
            // buttonLoad_BAA
            // 
            buttonLoad_BAA.Location = new Point(12, 12);
            buttonLoad_BAA.Name = "buttonLoad_MSM";
            buttonLoad_BAA.Size = new Size(80, 80);
            buttonLoad_BAA.TabIndex = 2;
            buttonLoad_BAA.Text = "Загрузить";
            toolTipHelp_BAA.SetToolTip(buttonLoad_BAA, "Загрузка файла");
            buttonLoad_BAA.UseVisualStyleBackColor = true;
            buttonLoad_BAA.Click += buttonLoad_BAA_Click;
            // 
            // buttonStart_BAA
            // 
            buttonStart_BAA.Enabled = false;
            buttonStart_BAA.Location = new Point(98, 12);
            buttonStart_BAA.Name = "buttonStart_BAA";
            buttonStart_BAA.Size = new Size(80, 80);
            buttonStart_BAA.TabIndex = 2;
            buttonStart_BAA.Text = "Выполнить";
            toolTipHelp_BAA.SetToolTip(buttonStart_BAA, "Запуск обработки файла");
            buttonStart_BAA.UseVisualStyleBackColor = true;
            buttonStart_BAA.Click += buttonStart_BAA_Click;
            // 
            // groupBoxTask_BAA
            // 
            groupBoxTask_BAA.Controls.Add(textBoxTask_BAA);
            groupBoxTask_BAA.Dock = DockStyle.Bottom;
            groupBoxTask_BAA.Location = new Point(0, 98);
            groupBoxTask_BAA.Name = "groupBoxTask_BAA";
            groupBoxTask_BAA.Size = new Size(784, 64);
            groupBoxTask_BAA.TabIndex = 0;
            groupBoxTask_BAA.TabStop = false;
            groupBoxTask_BAA.Text = "Условие";
            // 
            // textBoxTask_BAA
            // 
            textBoxTask_BAA.BackColor = SystemColors.Control;
            textBoxTask_BAA.BorderStyle = BorderStyle.None;
            textBoxTask_BAA.Dock = DockStyle.Fill;
            textBoxTask_BAA.Location = new Point(3, 19);
            textBoxTask_BAA.Multiline = true;
            textBoxTask_BAA.Name = "textBoxTask_BAA";
            textBoxTask_BAA.ReadOnly = true;
            textBoxTask_BAA.Size = new Size(778, 42);
            textBoxTask_BAA.TabIndex = 0;
            textBoxTask_BAA.Text = resources.GetString("textBoxTask_BAA.Text");
            // 
            // panelFill_BAA
            // 
            panelFill_BAA.Controls.Add(groupBoxOutput_BAA);
            panelFill_BAA.Dock = DockStyle.Fill;
            panelFill_BAA.Location = new Point(394, 162);
            panelFill_BAA.Name = "panelFill_BAA";
            panelFill_BAA.Size = new Size(390, 349);
            panelFill_BAA.TabIndex = 1;
            // 
            // groupBoxOutput_BAA
            // 
            groupBoxOutput_BAA.Controls.Add(textBoxOutput_BAA);
            groupBoxOutput_BAA.Dock = DockStyle.Fill;
            groupBoxOutput_BAA.Location = new Point(0, 0);
            groupBoxOutput_BAA.Name = "groupBoxOutput_BAA";
            groupBoxOutput_BAA.Size = new Size(390, 349);
            groupBoxOutput_BAA.TabIndex = 0;
            groupBoxOutput_BAA.TabStop = false;
            groupBoxOutput_BAA.Text = "Вывод:";
            // 
            // textBoxOutput_BAA
            // 
            textBoxOutput_BAA.BackColor = SystemColors.Window;
            textBoxOutput_BAA.Dock = DockStyle.Fill;
            textBoxOutput_BAA.Location = new Point(3, 19);
            textBoxOutput_BAA.Multiline = true;
            textBoxOutput_BAA.Name = "textBoxOutput_BAA";
            textBoxOutput_BAA.ReadOnly = true;
            textBoxOutput_BAA.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_BAA.Size = new Size(384, 327);
            textBoxOutput_BAA.TabIndex = 0;
            // 
            // panelLeft_BAA
            // 
            panelLeft_BAA.Controls.Add(groupBoxInput_BAA);
            panelLeft_BAA.Dock = DockStyle.Left;
            panelLeft_BAA.Location = new Point(0, 162);
            panelLeft_BAA.Name = "panelLeft_BAA";
            panelLeft_BAA.Size = new Size(391, 349);
            panelLeft_BAA.TabIndex = 2;
            // 
            // groupBoxInput_BAA
            // 
            groupBoxInput_BAA.Controls.Add(textBoxInput_BAA);
            groupBoxInput_BAA.Dock = DockStyle.Fill;
            groupBoxInput_BAA.Location = new Point(0, 0);
            groupBoxInput_BAA.Name = "groupBoxInput_BAA";
            groupBoxInput_BAA.Size = new Size(391, 349);
            groupBoxInput_BAA.TabIndex = 0;
            groupBoxInput_BAA.TabStop = false;
            groupBoxInput_BAA.Text = "Ввод:";
            // 
            // textBoxInput_BAA
            // 
            textBoxInput_BAA.BackColor = SystemColors.Window;
            textBoxInput_BAA.Dock = DockStyle.Fill;
            textBoxInput_BAA.Location = new Point(3, 19);
            textBoxInput_BAA.Multiline = true;
            textBoxInput_BAA.Name = "textBoxInput_BAA";
            textBoxInput_BAA.ReadOnly = true;
            textBoxInput_BAA.ScrollBars = ScrollBars.Vertical;
            textBoxInput_BAA.Size = new Size(385, 327);
            textBoxInput_BAA.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(391, 162);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 349);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // openFileDialog_BAA
            // 
            openFileDialog_BAA.FileName = "openFileDialogLoad";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 511);
            Controls.Add(panelFill_BAA);
            Controls.Add(splitter1);
            Controls.Add(panelLeft_BAA);
            Controls.Add(panelUP_BAA);
            MinimumSize = new Size(800, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 29 | Березкин А. А.";
            panelUP_BAA.ResumeLayout(false);
            groupBoxTask_BAA.ResumeLayout(false);
            groupBoxTask_BAA.PerformLayout();
            panelFill_BAA.ResumeLayout(false);
            groupBoxOutput_BAA.ResumeLayout(false);
            groupBoxOutput_BAA.PerformLayout();
            panelLeft_BAA.ResumeLayout(false);
            groupBoxInput_BAA.ResumeLayout(false);
            groupBoxInput_BAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUP_BAA;
        private Panel panelFill_BAA;
        private Panel panelLeft_BAA;
        private Splitter splitter1;
        private GroupBox groupBoxTask_BAA;
        private TextBox textBoxTask_BAA;
        private GroupBox groupBoxInput_BAA;
        private TextBox textBoxInput_BAA;
        private Button buttonHelp_BAA;
        private Button buttonLoad_BAA;
        private Button buttonStart_BAA;
        private GroupBox groupBoxOutput_BAA;
        private TextBox textBoxOutput_BAA;
        private OpenFileDialog openFileDialog_BAA;
        private ToolTip toolTipHelp_BAA;
    }
}