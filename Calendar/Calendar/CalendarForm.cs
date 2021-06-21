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
        /// <summary>
        /// List of 42 days of month control.
        /// </summary>
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
            UpdateCurrentMonthText();
        }
        /// <summary>
        /// The inferface ICalendarEventData creates new class InMemoryCalendarEventData
        /// </summary>
        /// <returns></returns>
        public ICalendarEventData GetDataProvider()
        {
            return new InMemoryCalendarEventData();
        }

        /// <summary>
        /// Designation of the first day of each month and the number of days in the displayed month.
        /// </summary>
        private void UpdateCalendarView()
        {
            var firstOfMonth = new DateTime(_currentDate.Year, _currentDate.Month, 1);
            int startIndex = firstOfMonth.DayOfWeek != DayOfWeek.Sunday ? (int)firstOfMonth.DayOfWeek - 1 : 6;
            int adddaystoControl = 0;

            for (int i = startIndex - 1; i >= 0; --i)
            {
                _days[i].Clear();
                _days[i].Date = firstOfMonth.AddDays(i - startIndex);
            }

            for (int i = startIndex; i < _days.Count; ++i)
            {
                _days[i].Clear();
                _days[i].Date = firstOfMonth.AddDays(adddaystoControl++);
                _days[i].DayEvents = _calendarData.GetEventsByMonth(_currentDate)
                    .Where(dayEvent => dayEvent.Date.Date == _days[i].Date.Date).ToList();
            }
        }
        /// <summary>
        /// Updates month and year in monthLabel depending on the currentDate value.
        /// </summary>
        public void UpdateCurrentMonthText()
        {
            monthLabel.Text = _currentDate.ToString("MMMM yyyy");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Displays next month in calendar view. Sets currentDate to next month and updates the view
        /// </summary>
        public void NextMonth()
        {
            _currentDate = _currentDate.AddMonths(+1);
            UpdateCalendarView();
            UpdateCurrentMonthText();
        }

        /// <summary>
        /// Displays previous month in calendar view. Sets currentDate to previous month and updates the view
        /// </summary>
        public void PreviousMonth()
        {
            _currentDate = _currentDate.AddMonths(-1);
            UpdateCalendarView();
            UpdateCurrentMonthText();
        }

        /// <summary>
        /// Creates 42 controls for days of the month, 7 column and 6 rows. 
        /// </summary>
        public void InitializeDaysControls()
        {
            int column = 0, row = 0;
            for (int i = 0; i <= 42; ++i)
            {
                var day = new DayControl();
                _days.Add(day);
                caledarNet.Controls.Add(day, column, row);
                day.DayClicked += OnDayClicked;
                day.DoubleClick += OnDayDoubleClicked;
                column += 1;
                if (column >= 7)
                {
                    column = 0;
                    row += 1;
                }

            }
        }
        /// <summary>
        /// After pressing the control with the day of the month, only the last pressed control will light up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// After double-clicking the control with the day of the month, the CreateEvent window is displayed. Saving the event is carried out by the OK button.
        /// Event is added to the list and displayed on it after clicked on that day.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDayDoubleClicked(object sender, EventArgs e)
        {
            DayControl selectedDay = sender as DayControl;
            if (selectedDay == null)
            {
                return;
            }

            using (var eventCreationDialog = new EventCreationDialog(selectedDay.Date))
            {
                if (eventCreationDialog.ShowDialog(this) == DialogResult.OK)
                {
                    var dayEvents = selectedDay.DayEvents;
                    dayEvents.Add(eventCreationDialog.CreatedEvent);
                    selectedDay.DayEvents = dayEvents;
                    listBoxDayEvents.DataSource = null;
                    listBoxDayEvents.DataSource = selectedDay.DayEvents;
                    _calendarData.CreateEvent(eventCreationDialog.CreatedEvent);
                }
            }
        }
        /// <summary>
        /// The function NextMonth() starts after clicking the nextButton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            NextMonth();
        }
        /// <summary>
        /// The function PreviousMonth() starts after clicking the prevoiusButton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


