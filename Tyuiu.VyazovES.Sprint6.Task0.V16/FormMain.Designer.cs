namespace Tyuiu.VyazovES.Sprint6.Task0.V16
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBoxX = new TextBox();
            label2 = new Label();
            textBoxResult = new TextBox();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 57);
            label1.Name = "label1";
            label1.Size = new Size(385, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите значение x и нажмите кнопку чтобы рассчитатьвыражение:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(420, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 70);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(117, 108);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 112);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Введите x:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(117, 153);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(100, 23);
            textBoxResult.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 156);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "Ответ:";
            // 
            // button1
            // 
            button1.Location = new Point(250, 108);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 6;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 231);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBoxResult);
            Controls.Add(label2);
            Controls.Add(textBoxX);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBoxX;
        private Label label2;
        private TextBox textBoxResult;
        private Label label3;
        private Button button1;
    }
}
