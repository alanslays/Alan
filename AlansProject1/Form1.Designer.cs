namespace AlansProject1
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
            button2 = new Button();
            label2 = new Label();
            shifts = new NumericUpDown();
            workerBeeJob = new ComboBox();
            label1 = new Label();
            report = new TextBox();
            nextShift = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shifts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(shifts);
            groupBox1.Controls.Add(workerBeeJob);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Przydział prac robotników";
            // 
            // button2
            // 
            button2.Location = new Point(15, 106);
            button2.Name = "button2";
            button2.Size = new Size(471, 34);
            button2.TabIndex = 4;
            button2.Text = "Przypisz tę pracę pszczole";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 29);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 3;
            label2.Text = "Zmiany";
            // 
            // shifts
            // 
            shifts.Location = new Point(306, 57);
            shifts.Name = "shifts";
            shifts.Size = new Size(180, 31);
            shifts.TabIndex = 2;
            // 
            // workerBeeJob
            // 
            workerBeeJob.FormattingEnabled = true;
            workerBeeJob.Items.AddRange(new object[] { "Raport zmiany numer 20", "Robotnica numer 1 zakończy \"Wytwarzanie miodu\" po tej zmianie", "Robotnica numer 2 robi \"Pielęgnacja jaj\" jeszcze przez 1 zmiany", "Robotnica numer 3 nie pracuje", "Robotnica numer 4 robi \"Zbieranie nektaru\" jeszcze przez 2 zmiany" });
            workerBeeJob.Location = new Point(15, 55);
            workerBeeJob.Name = "workerBeeJob";
            workerBeeJob.Size = new Size(182, 33);
            workerBeeJob.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 0;
            label1.Text = "Zadanie robotnicy";
            // 
            // report
            // 
            report.Location = new Point(12, 201);
            report.Multiline = true;
            report.Name = "report";
            report.Size = new Size(776, 237);
            report.TabIndex = 0;
            // 
            // nextShift
            // 
            nextShift.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            nextShift.Location = new Point(549, 37);
            nextShift.Name = "nextShift";
            nextShift.Size = new Size(239, 147);
            nextShift.TabIndex = 0;
            nextShift.Text = "Przepracuj następną zmianę";
            nextShift.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nextShift);
            Controls.Add(report);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "System zarządzania ulem";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shifts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Label label2;
        private NumericUpDown shifts;
        private ComboBox workerBeeJob;
        private Label label1;
        private TextBox report;
        private Button nextShift;
    }
}
