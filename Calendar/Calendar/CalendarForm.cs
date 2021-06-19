using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Windows;

namespace Calendar
{

    public partial class CalendarForm : Form
    {

        private List<DayControl> _days = new List<DayControl>(42);
        private DateTime _currentDate;
        private ICalendarEventData _calendarData;
        public CalendarForm()
        {
            InitializeComponent();
            _currentDate = DateTime.Now;
            _calendarData = GetDataProvider();
            InitializeDaysControls();
            UpdateCalendarView();
            DisplayCurrentMonth();
        }

        public ICalendarEventData GetDataProvider()
        {
            return new InMemoryCalendarEventData();
        }
        private void UpdateCalendarView()
        {
            var firstOfMonth = new DateTime(_currentDate.Year, _currentDate.Month, 1);
            int startIndex = firstOfMonth.DayOfWeek != DayOfWeek.Sunday ? (int)firstOfMonth.DayOfWeek - 1 : 6;
            int adddaystoControl = 0;

            for (int i = startIndex - 1; i >= 0; --i)
            {
                _days[i].Date = firstOfMonth.AddDays(i - startIndex);
            }

            for (int i = startIndex; i < _days.Count; ++i)
            {
                _days[i].Date = firstOfMonth.AddDays(adddaystoControl++);
                _days[i].DayEvents = _calendarData.GetEventsByMonth(_currentDate)
                    .Where(dayEvent => dayEvent.Date.Date == _days[i].Date.Date).ToList();
            }
        }

        public void DisplayCurrentMonth()
        {
            monthLabel.Text = _currentDate.ToString("MMMM yyyy");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void NextMonth()
        {
            _currentDate = _currentDate.AddMonths(+1);
            UpdateCalendarView();
            DisplayCurrentMonth();
        }

        public void PreviousMonth()
        {
            _currentDate = _currentDate.AddMonths(-1);
            UpdateCalendarView();
            DisplayCurrentMonth();
        }
        public void InitializeDaysControls()
        {
            int column = 0, row = 0;
            for (int i = 0; i <= 42; ++i)
            {
                var day = new DayControl();
                _days.Add(day);
                caledarNet.Controls.Add(day, column, row);
                day.DayClicked += OnDayClicked;
                column += 1;
                if (column >= 7)
                {
                    column = 0;
                    row += 1;
                }

            }
        }
        private void OnDayClicked(object sender, EventArgs e)
        {
            DayControl selectedDay = sender as DayControl;
            foreach (DayControl day in _days)
            {
                if (day != selectedDay)
                {
                    day.ClearSelection();
                }
            }
            listBoxDayEvents.DataSource = selectedDay.DayEvents;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            NextMonth();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            PreviousMonth();
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


        private void monthLabel_Click(object sender, EventArgs e)
        {


        }
    }
}


