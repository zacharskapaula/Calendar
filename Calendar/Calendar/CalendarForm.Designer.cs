
namespace Calendar
{
    partial class CalendarForm
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

        public partial class DayContol : CalendarForm
        {
            DayContol day1 = new DayContol();
            
        }




        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel caledarNet;
        private DayControl dayControl5;
        private DayControl dayControl3;
        private DayControl dayControl1;
        private DayControl dayControl2;
        private DayControl dayControl4;
        private DayControl dayControl6;
        private DayControl dayControl7;
        private DayControl dayControl8;
        private DayControl dayControl9;
    }
}

