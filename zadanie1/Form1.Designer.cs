﻿using System;

namespace zadanie1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.enableCheckbox = new System.Windows.Forms.CheckBox();
            this.changeText = new System.Windows.Forms.Button();
            this.labelToChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enableCheckbox
            // 
            this.enableCheckbox.AutoSize = true;
            this.enableCheckbox.Checked = true;
            this.enableCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckbox.Location = new System.Drawing.Point(266, 27);
            this.enableCheckbox.Name = "enableCheckbox";
            this.enableCheckbox.Size = new System.Drawing.Size(200, 24);
            this.enableCheckbox.TabIndex = 0;
            this.enableCheckbox.Text = "Włącza zmianę etykiety";
            this.enableCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enableCheckbox.UseVisualStyleBackColor = true;
            // this.enableCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // changeText
            // 
            this.changeText.Location = new System.Drawing.Point(12, 25);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(216, 27);
            this.changeText.TabIndex = 1;
            this.changeText.Text = "Kliknięcie zmienia etykietę";
            this.changeText.UseVisualStyleBackColor = true;
            this.changeText.Click += new System.EventHandler(this.changeText_Click);
            // 
            // labelToChange
            // 
            this.labelToChange.Location = new System.Drawing.Point(-2, 106);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(481, 41);
            this.labelToChange.TabIndex = 4;
            this.labelToChange.Text = "Naciśnij przycisk, aby zmienić tekst";
            this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 144);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.changeText);
            this.Controls.Add(this.enableCheckbox);
            this.Name = "Form1";
            this.Text = "Moja aplikacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox enableCheckbox;
        private System.Windows.Forms.Button changeText;
        private System.Windows.Forms.Label labelToChange;
        private EventHandler checkBox1_CheckedChanged;
    }
}

