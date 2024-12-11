
namespace WinFormsApp1
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
            button1 = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 34);
            button1.Name = "button1";
            button1.Size = new Size(307, 34);
            button1.TabIndex = 0;
            button1.Text = "Kliknięcie zmienia etykietę";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(483, 38);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(231, 29);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Włącza zmnianę etykiety";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += checkBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(187, 343);
            label1.Name = "label1";
            label1.Size = new Size(367, 25);
            label1.TabIndex = 2;
            label1.Text = "Możliwość zmiany tekstu została wyłacznona";
            label1.DragOver += label1_DragOver;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 386);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Pierwsza Apka";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_DragOver(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private Label label1;
    }
}
