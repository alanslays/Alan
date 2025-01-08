namespace AlansProject5
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
            textName = new TextBox();
            buttonStart = new Button();
            textProgress = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBooks = new TextBox();
            buttonAsk = new Button();
            listHand = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 9);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 1;
            label2.Text = "Ręka";
            // 
            // textName
            // 
            textName.Location = new Point(12, 37);
            textName.Name = "textName";
            textName.Size = new Size(248, 31);
            textName.TabIndex = 2;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(302, 37);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(217, 31);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Rozpocznij grę!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textProgress
            // 
            textProgress.BorderStyle = BorderStyle.FixedSingle;
            textProgress.Location = new Point(12, 130);
            textProgress.Multiline = true;
            textProgress.Name = "textProgress";
            textProgress.ReadOnly = true;
            textProgress.Size = new Size(507, 380);
            textProgress.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 5;
            label3.Text = "Postępy gry";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 534);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 6;
            label4.Text = "Grupy";
            // 
            // textBooks
            // 
            textBooks.BorderStyle = BorderStyle.FixedSingle;
            textBooks.Location = new Point(12, 576);
            textBooks.Multiline = true;
            textBooks.Name = "textBooks";
            textBooks.ReadOnly = true;
            textBooks.Size = new Size(507, 214);
            textBooks.TabIndex = 7;
            // 
            // buttonAsk
            // 
            buttonAsk.Location = new Point(572, 756);
            buttonAsk.Name = "buttonAsk";
            buttonAsk.Size = new Size(216, 34);
            buttonAsk.TabIndex = 8;
            buttonAsk.Text = "Zażądaj karty";
            buttonAsk.UseVisualStyleBackColor = true;
            buttonAsk.Click += buttonAsk_Click;
            // 
            // listHand
            // 
            listHand.FormattingEnabled = true;
            listHand.Location = new Point(572, 37);
            listHand.Name = "listHand";
            listHand.Size = new Size(216, 704);
            listHand.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 802);
            Controls.Add(listHand);
            Controls.Add(buttonAsk);
            Controls.Add(textBooks);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textProgress);
            Controls.Add(buttonStart);
            Controls.Add(textName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Idż na ryby!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textName;
        private Button buttonStart;
        private TextBox textProgress;
        private Label label3;
        private Label label4;
        private TextBox textBooks;
        private Button buttonAsk;
        private ListBox listHand;
    }
}
