using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class CalendarForm : Form
    {
        public CalendarForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dayControl1 = new Calendar.DayControl();
            this.dayControl2 = new Calendar.DayControl();
            this.dayControl3 = new Calendar.DayControl();
            this.dayControl4 = new Calendar.DayControl();
            this.dayControl5 = new Calendar.DayControl();
            this.dayControl6 = new Calendar.DayControl();
            this.dayControl7 = new Calendar.DayControl();
            this.dayControl8 = new Calendar.DayControl();
            this.dayControl9 = new Calendar.DayControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.40712F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.59288F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.Controls.Add(this.dayControl5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dayControl3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dayControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dayControl2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dayControl4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dayControl6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.dayControl7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dayControl8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dayControl9, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.75439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.24561F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(976, 558);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dayControl1
            // 
            this.dayControl1.Location = new System.Drawing.Point(135, 3);
            this.dayControl1.Name = "dayControl1";
            this.dayControl1.Size = new System.Drawing.Size(120, 109);
            this.dayControl1.TabIndex = 0;
            // 
            // dayControl2
            // 
            this.dayControl2.Location = new System.Drawing.Point(271, 3);
            this.dayControl2.Name = "dayControl2";
            this.dayControl2.Size = new System.Drawing.Size(120, 109);
            this.dayControl2.TabIndex = 1;
            // 
            // dayControl3
            // 
            this.dayControl3.Location = new System.Drawing.Point(414, 3);
            this.dayControl3.Name = "dayControl3";
            this.dayControl3.Size = new System.Drawing.Size(120, 109);
            this.dayControl3.TabIndex = 2;
            // 
            // dayControl4
            // 
            this.dayControl4.Location = new System.Drawing.Point(560, 3);
            this.dayControl4.Name = "dayControl4";
            this.dayControl4.Size = new System.Drawing.Size(120, 109);
            this.dayControl4.TabIndex = 3;
            // 
            // dayControl5
            // 
            this.dayControl5.Location = new System.Drawing.Point(705, 3);
            this.dayControl5.Name = "dayControl5";
            this.dayControl5.Size = new System.Drawing.Size(120, 109);
            this.dayControl5.TabIndex = 4;
            // 
            // dayControl6
            // 
            this.dayControl6.Location = new System.Drawing.Point(835, 3);
            this.dayControl6.Name = "dayControl6";
            this.dayControl6.Size = new System.Drawing.Size(120, 109);
            this.dayControl6.TabIndex = 5;
            // 
            // dayControl7
            // 
            this.dayControl7.Location = new System.Drawing.Point(3, 132);
            this.dayControl7.Name = "dayControl7";
            this.dayControl7.Size = new System.Drawing.Size(120, 109);
            this.dayControl7.TabIndex = 6;
            // 
            // dayControl8
            // 
            this.dayControl8.Location = new System.Drawing.Point(135, 132);
            this.dayControl8.Name = "dayControl8";
            this.dayControl8.Size = new System.Drawing.Size(120, 109);
            this.dayControl8.TabIndex = 7;
            // 
            // dayControl9
            // 
            this.dayControl9.Location = new System.Drawing.Point(271, 132);
            this.dayControl9.Name = "dayControl9";
            this.dayControl9.Size = new System.Drawing.Size(120, 109);
            this.dayControl9.TabIndex = 8;
            // 
            // CalendarForm
            // 
            this.ClientSize = new System.Drawing.Size(1105, 615);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CalendarForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void dayControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
