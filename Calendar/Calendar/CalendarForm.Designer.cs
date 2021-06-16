
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
            
            
        }




        //private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel caledarNet;
        
        private System.Windows.Forms.Button commitButton;
        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.Label mondayLabel;
        private System.Windows.Forms.Label tuesdayLabel;
        private System.Windows.Forms.Label wednesdayLabel;
        private System.Windows.Forms.Label thursdayLabel;
        private System.Windows.Forms.Label fridayLabel;
        private System.Windows.Forms.Label saturdayLabel;
        private System.Windows.Forms.Label sundayLabel;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label monthLabel;
    }
}

