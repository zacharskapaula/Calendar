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
            this.lblDayOfMonth = new System.Windows.Forms.Label();
            this.lblEventMarker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDayOfMonth
            // 
            this.lblDayOfMonth.AutoSize = true;
            this.lblDayOfMonth.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDayOfMonth.Location = new System.Drawing.Point(22, 29);
            this.lblDayOfMonth.Name = "lblDayOfMonth";
            this.lblDayOfMonth.Size = new System.Drawing.Size(47, 25);
            this.lblDayOfMonth.TabIndex = 1;
            this.lblDayOfMonth.Text = "DAY";
            this.lblDayOfMonth.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEventMarker
            // 
            this.lblEventMarker.AutoSize = true;
            this.lblEventMarker.ForeColor = System.Drawing.Color.Red;
            this.lblEventMarker.Location = new System.Drawing.Point(27, 54);
            this.lblEventMarker.Name = "lblEventMarker";
            this.lblEventMarker.Size = new System.Drawing.Size(42, 15);
            this.lblEventMarker.TabIndex = 2;
            this.lblEventMarker.Text = "_______";
            // 
            // DayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEventMarker);
            this.Controls.Add(this.lblDayOfMonth);
            this.Name = "DayControl";
            this.Size = new System.Drawing.Size(97, 91);
            this.Load += new System.EventHandler(this.DayControl_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDayOfMonth;
        private System.Windows.Forms.Label lblEventMarker;
    }
}
