namespace Tyuiu.BerezkinAA.Sprint6.Task0.V1
{
    partial class FormMain
    {
       
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_BAA = new GroupBox();
            pictureBoxFormula_BAA = new PictureBox();
            labelGoal_BAA = new Label();
            groupBoxInput_BAA = new GroupBox();
            labelVariable_BAA = new Label();
            textBoxWrite_BAA = new TextBox();
            groupBoxOutput_BAA = new GroupBox();
            textBoxResult_BAA = new TextBox();
            buttonStart_BAA = new Button();
            buttonHelp_BAA = new Button();
            groupBoxCondition_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BAA).BeginInit();
            groupBoxInput_BAA.SuspendLayout();
            groupBoxOutput_BAA.SuspendLayout();
            SuspendLayout();
           
            // groupBoxCondition_BAA
            
            groupBoxCondition_BAA.Controls.Add(pictureBoxFormula_BAA);
            groupBoxCondition_BAA.Controls.Add(labelGoal_BAA);
            groupBoxCondition_BAA.Location = new Point(27, 23);
            groupBoxCondition_BAA.Name = "groupBoxCondition_BAA";
            groupBoxCondition_BAA.Size = new Size(530, 164);
            groupBoxCondition_BAA.TabIndex = 0;
            groupBoxCondition_BAA.TabStop = false;
            groupBoxCondition_BAA.Text = "Условие";
            
            // pictureBoxFormula_BAA
           
            pictureBoxFormula_BAA.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFormula_BAA.Image = (Image)resources.GetObject("pictureBoxFormula_BAA.Image");
            pictureBoxFormula_BAA.Location = new Point(376, 0);
            pictureBoxFormula_BAA.Name = "pictureBoxFormula_BAA";
            pictureBoxFormula_BAA.Size = new Size(115, 52);
            pictureBoxFormula_BAA.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFormula_BAA.TabIndex = 2;
            pictureBoxFormula_BAA.TabStop = false;
            
            // labelGoal_BAA
            
            labelGoal_BAA.AutoSize = true;
            labelGoal_BAA.Location = new Point(6, 19);
            labelGoal_BAA.Name = "labelGoal_BAA";
            labelGoal_BAA.Size = new Size(205, 15);
            labelGoal_BAA.TabIndex = 1;
            labelGoal_BAA.Text = "Вычислить выражение по формуле";
             
            // groupBoxInput_BAA
             
            groupBoxInput_BAA.Controls.Add(labelVariable_BAA);
            groupBoxInput_BAA.Controls.Add(textBoxWrite_BAA);
            groupBoxInput_BAA.Location = new Point(27, 193);
            groupBoxInput_BAA.Name = "groupBoxInput_BAA";
            groupBoxInput_BAA.Size = new Size(348, 100);
            groupBoxInput_BAA.TabIndex = 1;
            groupBoxInput_BAA.TabStop = false;
            groupBoxInput_BAA.Text = "Ввод данных";
           
            // labelVariable_BAA
             
            labelVariable_BAA.AutoSize = true;
            labelVariable_BAA.Location = new Point(6, 19);
            labelVariable_BAA.Name = "labelVariable_BAA";
            labelVariable_BAA.Size = new Size(89, 15);
            labelVariable_BAA.TabIndex = 3;
            labelVariable_BAA.Text = "Переменная X:";
             
            // textBoxWrite_BAA
            
            textBoxWrite_BAA.Cursor = Cursors.IBeam;
            textBoxWrite_BAA.Location = new Point(6, 39);
            textBoxWrite_BAA.Name = "textBoxWrite_BAA";
            textBoxWrite_BAA.Size = new Size(100, 23);
            textBoxWrite_BAA.TabIndex = 0;
            textBoxWrite_BAA.KeyPress += textBoxWrite_BAA_KeyPress;
             
            // groupBoxOutput_BAA
           
            groupBoxOutput_BAA.Controls.Add(textBoxResult_BAA);
            groupBoxOutput_BAA.Location = new Point(381, 193);
            groupBoxOutput_BAA.Name = "groupBoxOutput_BAA";
            groupBoxOutput_BAA.Size = new Size(176, 100);
            groupBoxOutput_BAA.TabIndex = 2;
            groupBoxOutput_BAA.TabStop = false;
            groupBoxOutput_BAA.Text = "Вывод данных";
             
            // textBoxResult_BAA
             
            textBoxResult_BAA.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult_BAA.Location = new Point(6, 39);
            textBoxResult_BAA.Name = "textBoxResult_BAA";
            textBoxResult_BAA.ReadOnly = true;
            textBoxResult_BAA.Size = new Size(131, 23);
            textBoxResult_BAA.TabIndex = 0;
           
            // buttonStart_BAA
             
            buttonStart_BAA.Cursor = Cursors.Hand;
            buttonStart_BAA.FlatStyle = FlatStyle.Flat;
            buttonStart_BAA.Location = new Point(418, 319);
            buttonStart_BAA.Name = "buttonStart_BAA";
            buttonStart_BAA.Size = new Size(100, 30);
            buttonStart_BAA.TabIndex = 3;
            buttonStart_BAA.Text = "Выполнить";
            buttonStart_BAA.UseVisualStyleBackColor = true;
            buttonStart_BAA.Click += buttonStart_BAA_Click;
             
            // buttonHelp_BAA
           
            buttonHelp_BAA.Cursor = Cursors.Help;
            buttonHelp_BAA.FlatStyle = FlatStyle.Flat;
            buttonHelp_BAA.Location = new Point(387, 322);
            buttonHelp_BAA.Name = "buttonHelp_BAA";
            buttonHelp_BAA.Size = new Size(25, 25);
            buttonHelp_BAA.TabIndex = 4;
            buttonHelp_BAA.Text = "?";
            buttonHelp_BAA.UseVisualStyleBackColor = true;
            buttonHelp_BAA.Click += buttonHelp_BAA_Click;
             
            // FormMain
             
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(buttonHelp_BAA);
            Controls.Add(buttonStart_BAA);
            Controls.Add(groupBoxOutput_BAA);
            Controls.Add(groupBoxInput_BAA);
            Controls.Add(groupBoxCondition_BAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 1 | Березкин А. А.";
            groupBoxCondition_BAA.ResumeLayout(false);
            groupBoxCondition_BAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BAA).EndInit();
            groupBoxInput_BAA.ResumeLayout(false);
            groupBoxInput_BAA.PerformLayout();
            groupBoxOutput_BAA.ResumeLayout(false);
            groupBoxOutput_BAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_BAA;
        private GroupBox groupBoxInput_BAA;
        private GroupBox groupBoxOutput_BAA;
        private TextBox textBoxWrite_BAA;
        private Label labelGoal_BAA;
        private PictureBox pictureBoxFormula_BAA;
        private Label labelVariable_BAA;
        private TextBox textBoxResult_BAA;
        private Button buttonStart_BAA;
        private Button buttonHelp_BAA;
    }
}