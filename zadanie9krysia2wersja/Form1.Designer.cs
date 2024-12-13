namespace zadanie9krysia2wersja
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numberBirthday = new NumericUpDown();
            fancyBirthday = new CheckBox();
            label5 = new Label();
            cakeWriting = new TextBox();
            label6 = new Label();
            birthdayCost = new Label();
            tooLongLabel = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberBirthday).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(468, 296);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(460, 258);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Impreza okolicznościowa";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tooLongLabel);
            tabPage2.Controls.Add(birthdayCost);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(cakeWriting);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(fancyBirthday);
            tabPage2.Controls.Add(numberBirthday);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(460, 258);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Przyjęcie urodzinowe";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(16, 44);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 1;
            label1.Text = "Ilość osób";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 93);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(201, 29);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Dekoracje fantazyjne";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(16, 128);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(147, 29);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Opcja zdrowa";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(16, 188);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 4;
            label2.Text = "Koszt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(124, 185);
            label3.Name = "label3";
            label3.Size = new Size(72, 30);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 15);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 0;
            label4.Text = "Ilość osób";
            // 
            // numberBirthday
            // 
            numberBirthday.Location = new Point(19, 43);
            numberBirthday.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberBirthday.Name = "numberBirthday";
            numberBirthday.Size = new Size(180, 31);
            numberBirthday.TabIndex = 1;
            numberBirthday.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // fancyBirthday
            // 
            fancyBirthday.AutoSize = true;
            fancyBirthday.Location = new Point(19, 89);
            fancyBirthday.Name = "fancyBirthday";
            fancyBirthday.Size = new Size(201, 29);
            fancyBirthday.TabIndex = 2;
            fancyBirthday.Text = "Dekoracje fantazyjne";
            fancyBirthday.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 121);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 3;
            label5.Text = "Napis na torcie";
            // 
            // cakeWriting
            // 
            cakeWriting.Location = new Point(19, 149);
            cakeWriting.Name = "cakeWriting";
            cakeWriting.Size = new Size(293, 31);
            cakeWriting.TabIndex = 4;
            cakeWriting.Text = "Sto lat!";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(19, 203);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 1;
            label6.Text = "Koszt";
            // 
            // birthdayCost
            // 
            birthdayCost.AutoSize = true;
            birthdayCost.BorderStyle = BorderStyle.Fixed3D;
            birthdayCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 238);
            birthdayCost.Location = new Point(127, 200);
            birthdayCost.Name = "birthdayCost";
            birthdayCost.Size = new Size(72, 30);
            birthdayCost.TabIndex = 5;
            birthdayCost.Text = "label7";
            // 
            // tooLongLabel
            // 
            tooLongLabel.AutoSize = true;
            tooLongLabel.BackColor = Color.Red;
            tooLongLabel.Location = new Point(207, 121);
            tooLongLabel.Name = "tooLongLabel";
            tooLongLabel.Size = new Size(105, 25);
            tooLongLabel.TabIndex = 6;
            tooLongLabel.Text = "ZBYT DŁUGI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 287);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Planista przyjęć 2.0";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberBirthday).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private Label label2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private TabPage tabPage2;
        private NumericUpDown numberBirthday;
        private Label label4;
        private TextBox cakeWriting;
        private Label label5;
        private CheckBox fancyBirthday;
        private Label birthdayCost;
        private Label label6;
        private Label tooLongLabel;
    }
}
