namespace Zadanie12
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            Checkbox1 = new NumericUpDown();
            Checkbox2 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)Checkbox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Checkbox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 0;
            label1.Text = "Początkowy stan licznika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 68);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 1;
            label2.Text = "Końcowy stan licznika";
            // 
            // Checkbox1
            // 
            Checkbox1.Location = new Point(260, 25);
            Checkbox1.Name = "Checkbox1";
            Checkbox1.Size = new Size(180, 31);
            Checkbox1.TabIndex = 2;
            // 
            // Checkbox2
            // 
            Checkbox2.Location = new Point(260, 66);
            Checkbox2.Name = "Checkbox2";
            Checkbox2.Size = new Size(180, 31);
            Checkbox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 133);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 4;
            label3.Text = "Kwota do zwrotu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(224, 133);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // button1
            // 
            button1.Location = new Point(31, 194);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Oblicz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(354, 194);
            button2.Name = "button2";
            button2.Size = new Size(153, 34);
            button2.TabIndex = 7;
            button2.Text = "Pokaż odległość";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 240);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Checkbox2);
            Controls.Add(Checkbox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Kalkulator odległości";
            ((System.ComponentModel.ISupportInitialize)Checkbox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Checkbox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown Checkbox1;
        private NumericUpDown Checkbox2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}
