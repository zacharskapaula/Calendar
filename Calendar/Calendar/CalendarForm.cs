﻿using System;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            this.caledarNet = new System.Windows.Forms.TableLayoutPanel();
            this.dayControl3 = new Calendar.DayControl();
            this.dayControl4 = new Calendar.DayControl();
            this.dayControl1 = new Calendar.DayControl();
            this.dayControl2 = new Calendar.DayControl();
            this.dayControl5 = new Calendar.DayControl();
            this.dayControl6 = new Calendar.DayControl();
            this.dayControl7 = new Calendar.DayControl();
            this.dayControl13 = new Calendar.DayControl();
            this.dayControl9 = new Calendar.DayControl();
            this.dayControl10 = new Calendar.DayControl();
            this.dayControl11 = new Calendar.DayControl();
            this.dayControl12 = new Calendar.DayControl();
            this.dayControl8 = new Calendar.DayControl();
            this.dayControl14 = new Calendar.DayControl();
            this.dayControl15 = new Calendar.DayControl();
            this.dayControl16 = new Calendar.DayControl();
            this.dayControl17 = new Calendar.DayControl();
            this.dayControl18 = new Calendar.DayControl();
            this.dayControl19 = new Calendar.DayControl();
            this.dayControl20 = new Calendar.DayControl();
            this.dayControl21 = new Calendar.DayControl();
            this.dayControl22 = new Calendar.DayControl();
            this.dayControl23 = new Calendar.DayControl();
            this.dayControl24 = new Calendar.DayControl();
            this.dayControl25 = new Calendar.DayControl();
            this.dayControl26 = new Calendar.DayControl();
            this.dayControl27 = new Calendar.DayControl();
            this.dayControl28 = new Calendar.DayControl();
            this.dayControl32 = new Calendar.DayControl();
            this.dayControl33 = new Calendar.DayControl();
            this.dayControl29 = new Calendar.DayControl();
            this.dayControl34 = new Calendar.DayControl();
            this.dayControl30 = new Calendar.DayControl();
            this.dayControl35 = new Calendar.DayControl();
            this.dayControl31 = new Calendar.DayControl();
            this.commitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.caledarNet.SuspendLayout();
            this.SuspendLayout();
            // 
            // caledarNet
            // 
            this.caledarNet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.caledarNet.ColumnCount = 7;
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.40712F));
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.59288F));
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.caledarNet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.caledarNet.Controls.Add(this.dayControl3, 2, 0);
            this.caledarNet.Controls.Add(this.dayControl4, 4, 0);
            this.caledarNet.Controls.Add(this.dayControl1, 0, 0);
            this.caledarNet.Controls.Add(this.dayControl2, 1, 0);
            this.caledarNet.Controls.Add(this.dayControl5, 3, 0);
            this.caledarNet.Controls.Add(this.dayControl6, 5, 0);
            this.caledarNet.Controls.Add(this.dayControl7, 6, 0);
            this.caledarNet.Controls.Add(this.dayControl13, 0, 1);
            this.caledarNet.Controls.Add(this.dayControl9, 1, 1);
            this.caledarNet.Controls.Add(this.dayControl10, 2, 1);
            this.caledarNet.Controls.Add(this.dayControl11, 3, 1);
            this.caledarNet.Controls.Add(this.dayControl12, 4, 1);
            this.caledarNet.Controls.Add(this.dayControl8, 5, 1);
            this.caledarNet.Controls.Add(this.dayControl14, 6, 1);
            this.caledarNet.Controls.Add(this.dayControl15, 0, 2);
            this.caledarNet.Controls.Add(this.dayControl16, 1, 2);
            this.caledarNet.Controls.Add(this.dayControl17, 2, 2);
            this.caledarNet.Controls.Add(this.dayControl18, 3, 2);
            this.caledarNet.Controls.Add(this.dayControl19, 4, 2);
            this.caledarNet.Controls.Add(this.dayControl20, 5, 2);
            this.caledarNet.Controls.Add(this.dayControl21, 6, 2);
            this.caledarNet.Controls.Add(this.dayControl22, 0, 3);
            this.caledarNet.Controls.Add(this.dayControl23, 1, 3);
            this.caledarNet.Controls.Add(this.dayControl24, 2, 3);
            this.caledarNet.Controls.Add(this.dayControl25, 3, 3);
            this.caledarNet.Controls.Add(this.dayControl26, 4, 3);
            this.caledarNet.Controls.Add(this.dayControl27, 5, 3);
            this.caledarNet.Controls.Add(this.dayControl28, 6, 3);
            this.caledarNet.Controls.Add(this.dayControl32, 3, 4);
            this.caledarNet.Controls.Add(this.dayControl33, 4, 4);
            this.caledarNet.Controls.Add(this.dayControl29, 0, 4);
            this.caledarNet.Controls.Add(this.dayControl34, 4, 4);
            this.caledarNet.Controls.Add(this.dayControl30, 1, 4);
            this.caledarNet.Controls.Add(this.dayControl35, 6, 4);
            this.caledarNet.Controls.Add(this.dayControl31, 2, 4);
            this.caledarNet.Location = new System.Drawing.Point(58, 45);
            this.caledarNet.Name = "caledarNet";
            this.caledarNet.RowCount = 5;
            this.caledarNet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.35622F));
            this.caledarNet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.64378F));
            this.caledarNet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.caledarNet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.caledarNet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.caledarNet.Size = new System.Drawing.Size(977, 592);
            this.caledarNet.TabIndex = 0;
            this.caledarNet.Paint += new System.Windows.Forms.PaintEventHandler(this.caledarNet_Paint);
            // 
            // dayControl3
            // 
            this.dayControl3.Location = new System.Drawing.Point(272, 3);
            this.dayControl3.Name = "dayControl3";
            this.dayControl3.Size = new System.Drawing.Size(120, 109);
            this.dayControl3.TabIndex = 2;
            // 
            // dayControl4
            // 
            this.dayControl4.Location = new System.Drawing.Point(561, 3);
            this.dayControl4.Name = "dayControl4";
            this.dayControl4.Size = new System.Drawing.Size(120, 109);
            this.dayControl4.TabIndex = 3;
            // 
            // dayControl1
            // 
            this.dayControl1.Location = new System.Drawing.Point(3, 3);
            this.dayControl1.Name = "dayControl1";
            this.dayControl1.Size = new System.Drawing.Size(120, 109);
            this.dayControl1.TabIndex = 0;
            this.dayControl1.Load += new System.EventHandler(this.dayControl1_Load_1);
            this.dayControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dayControl1_MouseDown);
            // 
            // dayControl2
            // 
            this.dayControl2.Location = new System.Drawing.Point(136, 3);
            this.dayControl2.Name = "dayControl2";
            this.dayControl2.Size = new System.Drawing.Size(120, 109);
            this.dayControl2.TabIndex = 1;
            // 
            // dayControl5
            // 
            this.dayControl5.Location = new System.Drawing.Point(415, 3);
            this.dayControl5.Name = "dayControl5";
            this.dayControl5.Size = new System.Drawing.Size(120, 109);
            this.dayControl5.TabIndex = 4;
            // 
            // dayControl6
            // 
            this.dayControl6.Location = new System.Drawing.Point(706, 3);
            this.dayControl6.Name = "dayControl6";
            this.dayControl6.Size = new System.Drawing.Size(120, 109);
            this.dayControl6.TabIndex = 5;
            // 
            // dayControl7
            // 
            this.dayControl7.Location = new System.Drawing.Point(836, 3);
            this.dayControl7.Name = "dayControl7";
            this.dayControl7.Size = new System.Drawing.Size(120, 109);
            this.dayControl7.TabIndex = 6;
            // 
            // dayControl13
            // 
            this.dayControl13.Location = new System.Drawing.Point(3, 120);
            this.dayControl13.Name = "dayControl13";
            this.dayControl13.Size = new System.Drawing.Size(120, 109);
            this.dayControl13.TabIndex = 12;
            // 
            // dayControl9
            // 
            this.dayControl9.Location = new System.Drawing.Point(136, 120);
            this.dayControl9.Name = "dayControl9";
            this.dayControl9.Size = new System.Drawing.Size(120, 109);
            this.dayControl9.TabIndex = 8;
            // 
            // dayControl10
            // 
            this.dayControl10.Location = new System.Drawing.Point(272, 120);
            this.dayControl10.Name = "dayControl10";
            this.dayControl10.Size = new System.Drawing.Size(120, 109);
            this.dayControl10.TabIndex = 9;
            // 
            // dayControl11
            // 
            this.dayControl11.Location = new System.Drawing.Point(415, 120);
            this.dayControl11.Name = "dayControl11";
            this.dayControl11.Size = new System.Drawing.Size(120, 109);
            this.dayControl11.TabIndex = 10;
            // 
            // dayControl12
            // 
            this.dayControl12.Location = new System.Drawing.Point(561, 120);
            this.dayControl12.Name = "dayControl12";
            this.dayControl12.Size = new System.Drawing.Size(120, 109);
            this.dayControl12.TabIndex = 11;
            // 
            // dayControl8
            // 
            this.dayControl8.Location = new System.Drawing.Point(706, 120);
            this.dayControl8.Name = "dayControl8";
            this.dayControl8.Size = new System.Drawing.Size(120, 109);
            this.dayControl8.TabIndex = 7;
            // 
            // dayControl14
            // 
            this.dayControl14.Location = new System.Drawing.Point(836, 120);
            this.dayControl14.Name = "dayControl14";
            this.dayControl14.Size = new System.Drawing.Size(120, 109);
            this.dayControl14.TabIndex = 13;
            // 
            // dayControl15
            // 
            this.dayControl15.Location = new System.Drawing.Point(3, 241);
            this.dayControl15.Name = "dayControl15";
            this.dayControl15.Size = new System.Drawing.Size(120, 109);
            this.dayControl15.TabIndex = 14;
            // 
            // dayControl16
            // 
            this.dayControl16.Location = new System.Drawing.Point(136, 241);
            this.dayControl16.Name = "dayControl16";
            this.dayControl16.Size = new System.Drawing.Size(120, 109);
            this.dayControl16.TabIndex = 15;
            // 
            // dayControl17
            // 
            this.dayControl17.Location = new System.Drawing.Point(272, 241);
            this.dayControl17.Name = "dayControl17";
            this.dayControl17.Size = new System.Drawing.Size(120, 109);
            this.dayControl17.TabIndex = 16;
            // 
            // dayControl18
            // 
            this.dayControl18.Location = new System.Drawing.Point(415, 241);
            this.dayControl18.Name = "dayControl18";
            this.dayControl18.Size = new System.Drawing.Size(120, 109);
            this.dayControl18.TabIndex = 17;
            // 
            // dayControl19
            // 
            this.dayControl19.Location = new System.Drawing.Point(561, 241);
            this.dayControl19.Name = "dayControl19";
            this.dayControl19.Size = new System.Drawing.Size(120, 109);
            this.dayControl19.TabIndex = 18;
            // 
            // dayControl20
            // 
            this.dayControl20.Location = new System.Drawing.Point(706, 241);
            this.dayControl20.Name = "dayControl20";
            this.dayControl20.Size = new System.Drawing.Size(120, 109);
            this.dayControl20.TabIndex = 19;
            // 
            // dayControl21
            // 
            this.dayControl21.Location = new System.Drawing.Point(836, 241);
            this.dayControl21.Name = "dayControl21";
            this.dayControl21.Size = new System.Drawing.Size(120, 109);
            this.dayControl21.TabIndex = 20;
            // 
            // dayControl22
            // 
            this.dayControl22.Location = new System.Drawing.Point(3, 365);
            this.dayControl22.Name = "dayControl22";
            this.dayControl22.Size = new System.Drawing.Size(120, 109);
            this.dayControl22.TabIndex = 21;
            // 
            // dayControl23
            // 
            this.dayControl23.Location = new System.Drawing.Point(136, 365);
            this.dayControl23.Name = "dayControl23";
            this.dayControl23.Size = new System.Drawing.Size(120, 109);
            this.dayControl23.TabIndex = 22;
            // 
            // dayControl24
            // 
            this.dayControl24.Location = new System.Drawing.Point(272, 365);
            this.dayControl24.Name = "dayControl24";
            this.dayControl24.Size = new System.Drawing.Size(120, 109);
            this.dayControl24.TabIndex = 23;
            // 
            // dayControl25
            // 
            this.dayControl25.Location = new System.Drawing.Point(415, 365);
            this.dayControl25.Name = "dayControl25";
            this.dayControl25.Size = new System.Drawing.Size(120, 109);
            this.dayControl25.TabIndex = 24;
            // 
            // dayControl26
            // 
            this.dayControl26.Location = new System.Drawing.Point(561, 365);
            this.dayControl26.Name = "dayControl26";
            this.dayControl26.Size = new System.Drawing.Size(120, 109);
            this.dayControl26.TabIndex = 25;
            // 
            // dayControl27
            // 
            this.dayControl27.Location = new System.Drawing.Point(706, 365);
            this.dayControl27.Name = "dayControl27";
            this.dayControl27.Size = new System.Drawing.Size(120, 109);
            this.dayControl27.TabIndex = 26;
            // 
            // dayControl28
            // 
            this.dayControl28.Location = new System.Drawing.Point(836, 365);
            this.dayControl28.Name = "dayControl28";
            this.dayControl28.Size = new System.Drawing.Size(120, 109);
            this.dayControl28.TabIndex = 27;
            // 
            // dayControl32
            // 
            this.dayControl32.Location = new System.Drawing.Point(415, 481);
            this.dayControl32.Name = "dayControl32";
            this.dayControl32.Size = new System.Drawing.Size(120, 108);
            this.dayControl32.TabIndex = 31;
            // 
            // dayControl33
            // 
            this.dayControl33.Location = new System.Drawing.Point(561, 481);
            this.dayControl33.Name = "dayControl33";
            this.dayControl33.Size = new System.Drawing.Size(120, 108);
            this.dayControl33.TabIndex = 32;
            // 
            // dayControl29
            // 
            this.dayControl29.Location = new System.Drawing.Point(3, 481);
            this.dayControl29.Name = "dayControl29";
            this.dayControl29.Size = new System.Drawing.Size(120, 108);
            this.dayControl29.TabIndex = 28;
            // 
            // dayControl34
            // 
            this.dayControl34.Location = new System.Drawing.Point(706, 481);
            this.dayControl34.Name = "dayControl34";
            this.dayControl34.Size = new System.Drawing.Size(120, 108);
            this.dayControl34.TabIndex = 33;
            // 
            // dayControl30
            // 
            this.dayControl30.Location = new System.Drawing.Point(136, 481);
            this.dayControl30.Name = "dayControl30";
            this.dayControl30.Size = new System.Drawing.Size(120, 108);
            this.dayControl30.TabIndex = 29;
            // 
            // dayControl35
            // 
            this.dayControl35.Location = new System.Drawing.Point(836, 481);
            this.dayControl35.Name = "dayControl35";
            this.dayControl35.Size = new System.Drawing.Size(120, 108);
            this.dayControl35.TabIndex = 34;
            // 
            // dayControl31
            // 
            this.dayControl31.Location = new System.Drawing.Point(272, 481);
            this.dayControl31.Name = "dayControl31";
            this.dayControl31.Size = new System.Drawing.Size(120, 108);
            this.dayControl31.TabIndex = 30;
            // 
            // commitButton
            // 
            this.commitButton.Location = new System.Drawing.Point(728, 701);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(99, 24);
            this.commitButton.TabIndex = 1;
            this.commitButton.Text = "COMMIT";
            this.commitButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 701);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 673);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add an event or reminder";
            // 
            // CalendarForm
            // 
            this.ClientSize = new System.Drawing.Size(1087, 771);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.caledarNet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalendarForm";
            this.Text = "Calendar";
            this.caledarNet.ResumeLayout(false);
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
            
        }
    }
}
