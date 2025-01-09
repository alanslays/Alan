namespace AlansProject7
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
            groupBox1 = new GroupBox();
            assignJob = new Button();
            shifts = new NumericUpDown();
            comboBox1 = new ComboBox();
            label1 = new Label();
            report = new TextBox();
            nextShift = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shifts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(assignJob);
            groupBox1.Controls.Add(shifts);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 199);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Przydział prac";
            // 
            // assignJob
            // 
            assignJob.Location = new Point(15, 130);
            assignJob.Name = "assignJob";
            assignJob.Size = new Size(328, 34);
            assignJob.TabIndex = 3;
            assignJob.Text = "Przypisz pracę pszczole";
            assignJob.UseVisualStyleBackColor = true;
            // 
            // shifts
            // 
            shifts.Location = new Point(214, 66);
            shifts.Name = "shifts";
            shifts.Size = new Size(129, 31);
            shifts.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Zbieranie nektaru" });
            comboBox1.Location = new Point(15, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 36);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // report
            // 
            report.Location = new Point(12, 218);
            report.Multiline = true;
            report.Name = "report";
            report.Size = new Size(643, 220);
            report.TabIndex = 0;
            // 
            // nextShift
            // 
            nextShift.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 238);
            nextShift.Location = new Point(400, 12);
            nextShift.Name = "nextShift";
            nextShift.Size = new Size(254, 187);
            nextShift.TabIndex = 1;
            nextShift.Text = "Przepracuj następną godzinę";
            nextShift.UseVisualStyleBackColor = true;
            nextShift.Click += nextShift_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 450);
            Controls.Add(nextShift);
            Controls.Add(report);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "System zarządzania ulem";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shifts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button assignJob;
        private NumericUpDown shifts;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox report;
        private Button nextShift;
    }
}
