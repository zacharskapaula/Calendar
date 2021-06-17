using System;

namespace Calendar
{
    partial class DayControl
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayUserControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayUserControl
            // 
            this.dayUserControl.AutoSize = true;
            this.dayUserControl.Location = new System.Drawing.Point(45, 15);
            this.dayUserControl.Name = "dayUserControl";
            this.dayUserControl.Size = new System.Drawing.Size(29, 15);
            this.dayUserControl.TabIndex = 1;
            this.dayUserControl.Text = "DAY";
            this.dayUserControl.Click += new System.EventHandler(this.label2_Click);
            // 
            // DayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dayUserControl);
            this.Name = "DayControl";
            this.Size = new System.Drawing.Size(104, 100);
            this.Load += new System.EventHandler(this.DayControl_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dayUserControl;
    }
}
