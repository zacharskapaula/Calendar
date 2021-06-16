﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Calendar
{
    public partial class CalendarForm : Form
    {

        private List<DayControl> _days = new List<DayControl>(35);
        private DateTime currentDate;
        public CalendarForm()
        {
            InitializeComponent();
            UpdateCalendarView();
            DisplayCurrentMonth();
            AddMonth();
            MinMonth();
        }
        public void DisplayCurrentMonth()
        {
            monthLabel.Text = currentDate.ToString("MMMM");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void AddMonth()
        {
            currentDate = currentDate.AddMonths(+1);
            DisplayCurrentMonth();
        }

        public void MinMonth()
        {
            currentDate = currentDate.AddMonths(-1);
            DisplayCurrentMonth();
        }
       
        public void UpdateCalendarView ()
        {
            int column=0, row = 0;
            for(int i = 0; i <= 35; ++i)
{
                var day = new DayControl();
                _days.Add(day);
                caledarNet.Controls.Add(day, column, row);
                column += 1;
                if(column >= 7)
  {
                    column = 0;
                    row += 1;
                }

            }
            var firstOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //var lastDayOfMonth = firstOfMonth.AddMonths(1).AddDays(-1);

            int daysInMonth = DateTime.DaysInMonth(firstOfMonth.Year, firstOfMonth.Month);

            int startIndex = (int)firstOfMonth.DayOfWeek - 1;
            int adddaystoControl = 0;

            

            for (int i = startIndex - 1; i >= 0; --i)
{
                _days[i].Date = firstOfMonth.AddDays(i - startIndex);
}

            for(int i = startIndex; i < _days.Count; ++i)
{
                _days[i].Date = firstOfMonth.AddDays(adddaystoControl++);
                if (adddaystoControl >= daysInMonth)
                {
                    currentDate = currentDate.AddMonths(1);
                    DisplayCurrentMonth();

                }
            }

        
         
    }



    private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            this.caledarNet = new System.Windows.Forms.TableLayoutPanel();
            this.commitButton = new System.Windows.Forms.Button();
            this.eventTextBox = new System.Windows.Forms.TextBox();
            this.eventLabel = new System.Windows.Forms.Label();
            this.mondayLabel = new System.Windows.Forms.Label();
            this.tuesdayLabel = new System.Windows.Forms.Label();
            this.wednesdayLabel = new System.Windows.Forms.Label();
            this.thursdayLabel = new System.Windows.Forms.Label();
            this.fridayLabel = new System.Windows.Forms.Label();
            this.saturdayLabel = new System.Windows.Forms.Label();
            this.sundayLabel = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.monthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caledarNet
            // 
            this.caledarNet.BackColor = System.Drawing.Color.ForestGreen;
            this.caledarNet.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.caledarNet.ColumnCount = 7;
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28594F));
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28438F));
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28594F));
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28594F));
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28594F));
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28594F));
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28594F));
            this.caledarNet.Location = new System.Drawing.Point(87, 114);
            this.caledarNet.Name = "caledarNet";
            this.caledarNet.RowCount = 5;
            this.caledarNet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.94863F));
            this.caledarNet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.20548F));
            this.caledarNet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.94863F));
            this.caledarNet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.94863F));
            this.caledarNet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.94863F));
            this.caledarNet.Size = new System.Drawing.Size(877, 570);
            this.caledarNet.TabIndex = 0;
            this.caledarNet.Paint += new System.Windows.Forms.PaintEventHandler(this.caledarNet_Paint);
            // 
            // commitButton
            // 
            this.commitButton.Location = new System.Drawing.Point(728, 736);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(99, 24);
            this.commitButton.TabIndex = 1;
            this.commitButton.Text = "COMMIT";
            this.commitButton.UseVisualStyleBackColor = true;
            // 
            // eventTextBox
            // 
            this.eventTextBox.Location = new System.Drawing.Point(330, 736);
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.Size = new System.Drawing.Size(382, 23);
            this.eventTextBox.TabIndex = 2;
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.Location = new System.Drawing.Point(330, 706);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(142, 15);
            this.eventLabel.TabIndex = 3;
            this.eventLabel.Text = "Add an event or reminder";
            // 
            // mondayLabel
            // 
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mondayLabel.Location = new System.Drawing.Point(123, 96);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(58, 15);
            this.mondayLabel.TabIndex = 4;
            this.mondayLabel.Text = "MONDAY";
            // 
            // tuesdayLabel
            // 
            this.tuesdayLabel.AutoSize = true;
            this.tuesdayLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tuesdayLabel.Location = new System.Drawing.Point(243, 96);
            this.tuesdayLabel.Name = "tuesdayLabel";
            this.tuesdayLabel.Size = new System.Drawing.Size(55, 15);
            this.tuesdayLabel.TabIndex = 5;
            this.tuesdayLabel.Text = "TUESDAY";
            // 
            // wednesdayLabel
            // 
            this.wednesdayLabel.AutoSize = true;
            this.wednesdayLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.wednesdayLabel.Location = new System.Drawing.Point(359, 96);
            this.wednesdayLabel.Name = "wednesdayLabel";
            this.wednesdayLabel.Size = new System.Drawing.Size(75, 15);
            this.wednesdayLabel.TabIndex = 6;
            this.wednesdayLabel.Text = "WEDNESDAY";
            // 
            // thursdayLabel
            // 
            this.thursdayLabel.AutoSize = true;
            this.thursdayLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.thursdayLabel.Location = new System.Drawing.Point(491, 96);
            this.thursdayLabel.Name = "thursdayLabel";
            this.thursdayLabel.Size = new System.Drawing.Size(65, 15);
            this.thursdayLabel.TabIndex = 7;
            this.thursdayLabel.Text = "THURSDAY";
            // 
            // fridayLabel
            // 
            this.fridayLabel.AutoSize = true;
            this.fridayLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.fridayLabel.Location = new System.Drawing.Point(626, 96);
            this.fridayLabel.Name = "fridayLabel";
            this.fridayLabel.Size = new System.Drawing.Size(45, 15);
            this.fridayLabel.TabIndex = 8;
            this.fridayLabel.Text = "FRIDAY";
            // 
            // saturdayLabel
            // 
            this.saturdayLabel.AutoSize = true;
            this.saturdayLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saturdayLabel.Location = new System.Drawing.Point(740, 96);
            this.saturdayLabel.Name = "saturdayLabel";
            this.saturdayLabel.Size = new System.Drawing.Size(63, 15);
            this.saturdayLabel.TabIndex = 9;
            this.saturdayLabel.Text = "SATURDAY";
            // 
            // sundayLabel
            // 
            this.sundayLabel.AutoSize = true;
            this.sundayLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sundayLabel.Location = new System.Drawing.Point(870, 96);
            this.sundayLabel.Name = "sundayLabel";
            this.sundayLabel.Size = new System.Drawing.Size(52, 15);
            this.sundayLabel.TabIndex = 10;
            this.sundayLabel.Text = "SUNDAY";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(87, 29);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(99, 24);
            this.previousButton.TabIndex = 11;
            this.previousButton.Text = "PREVIOUS";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(865, 29);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(99, 24);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(506, 38);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(51, 15);
            this.monthLabel.TabIndex = 13;
            this.monthLabel.Text = "MONTH";
            this.monthLabel.Click += new System.EventHandler(this.monthLabel_Click);
            // 
            // CalendarForm
            // 
            this.ClientSize = new System.Drawing.Size(1087, 771);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.sundayLabel);
            this.Controls.Add(this.saturdayLabel);
            this.Controls.Add(this.fridayLabel);
            this.Controls.Add(this.thursdayLabel);
            this.Controls.Add(this.wednesdayLabel);
            this.Controls.Add(this.tuesdayLabel);
            this.Controls.Add(this.mondayLabel);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.eventTextBox);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.caledarNet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalendarForm";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dayControl1_Load(object sender, EventArgs e)
        {

        }

        private void caledarNet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dayControl1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void dayControl1_MouseDown(object sender, MouseEventArgs e)
        {
            //dayControl1.BackColor = Color.White;
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            AddMonth();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            MinMonth();
        }

        private void monthLabel_Click(object sender, EventArgs e)
        {
            

        }
    }
}
