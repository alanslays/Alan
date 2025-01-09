namespace AlanProject10
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            moveToDeck2 = new Button();
            moveToDeck1 = new Button();
            shuffle1 = new Button();
            reset1 = new Button();
            shuffle2 = new Button();
            reset2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(21, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 454);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(454, 43);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 454);
            listBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 15);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 2;
            label1.Text = "Zestaw 1. (10 kart)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 15);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 3;
            label2.Text = "Zestaw 2. (52 kart)";
            // 
            // moveToDeck2
            // 
            moveToDeck2.Location = new Point(269, 195);
            moveToDeck2.Name = "moveToDeck2";
            moveToDeck2.Size = new Size(112, 34);
            moveToDeck2.TabIndex = 4;
            moveToDeck2.Text = ">>";
            moveToDeck2.UseVisualStyleBackColor = true;
            // 
            // moveToDeck1
            // 
            moveToDeck1.Location = new Point(269, 267);
            moveToDeck1.Name = "moveToDeck1";
            moveToDeck1.Size = new Size(112, 34);
            moveToDeck1.TabIndex = 5;
            moveToDeck1.Text = "<<";
            moveToDeck1.UseVisualStyleBackColor = true;
            // 
            // shuffle1
            // 
            shuffle1.Location = new Point(21, 512);
            shuffle1.Name = "shuffle1";
            shuffle1.Size = new Size(180, 34);
            shuffle1.TabIndex = 6;
            shuffle1.Text = "Przywróc zestaw 1";
            shuffle1.UseVisualStyleBackColor = true;
            // 
            // reset1
            // 
            reset1.Location = new Point(21, 563);
            reset1.Name = "reset1";
            reset1.Size = new Size(180, 34);
            reset1.TabIndex = 7;
            reset1.Text = "Wymieszaj zestaw 1";
            reset1.UseVisualStyleBackColor = true;
            // 
            // shuffle2
            // 
            shuffle2.Location = new Point(454, 512);
            shuffle2.Name = "shuffle2";
            shuffle2.Size = new Size(180, 34);
            shuffle2.TabIndex = 8;
            shuffle2.Text = "Przywróć zestaw 2";
            shuffle2.UseVisualStyleBackColor = true;
            // 
            // reset2
            // 
            reset2.Location = new Point(454, 563);
            reset2.Name = "reset2";
            reset2.Size = new Size(180, 34);
            reset2.TabIndex = 9;
            reset2.Text = "Wymieszaj zestaw 2";
            reset2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 626);
            Controls.Add(reset2);
            Controls.Add(shuffle2);
            Controls.Add(reset1);
            Controls.Add(shuffle1);
            Controls.Add(moveToDeck1);
            Controls.Add(moveToDeck2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Dwie talie";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Button moveToDeck2;
        private Button moveToDeck1;
        private Button shuffle1;
        private Button reset1;
        private Button shuffle2;
        private Button reset2;
    }
}
