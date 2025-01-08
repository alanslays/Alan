namespace AlansProject3
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
            description = new TextBox();
            goHere = new Button();
            exists = new ComboBox();
            goThroughTheDoor = new Button();
            SuspendLayout();
            // 
            // description
            // 
            description.Location = new Point(12, 12);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(538, 281);
            description.TabIndex = 0;
            // 
            // goHere
            // 
            goHere.Location = new Point(12, 310);
            goHere.Name = "goHere";
            goHere.Size = new Size(158, 34);
            goHere.TabIndex = 1;
            goHere.Text = "Idż tutaj";
            goHere.UseVisualStyleBackColor = true;
            // 
            // exists
            // 
            exists.FormattingEnabled = true;
            exists.Location = new Point(234, 311);
            exists.Name = "exists";
            exists.Size = new Size(316, 33);
            exists.TabIndex = 2;
            exists.Visible = false;
            // 
            // goThroughTheDoor
            // 
            goThroughTheDoor.Location = new Point(12, 372);
            goThroughTheDoor.Name = "goThroughTheDoor";
            goThroughTheDoor.Size = new Size(538, 34);
            goThroughTheDoor.TabIndex = 3;
            goThroughTheDoor.Text = "Przejdż przez drzwi";
            goThroughTheDoor.UseVisualStyleBackColor = true;
            goThroughTheDoor.Click += goThroughTheDoor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 450);
            Controls.Add(goThroughTheDoor);
            Controls.Add(exists);
            Controls.Add(goHere);
            Controls.Add(description);
            Name = "Form1";
            Text = "Zbadaj dom";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox description;
        private Button goHere;
        private ComboBox exists;
        private Button goThroughTheDoor;
    }
}
