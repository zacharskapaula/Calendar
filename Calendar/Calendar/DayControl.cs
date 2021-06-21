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
    public partial class DayControl : UserControl
    {
        public event EventHandler DayClicked;
        private List<Event> _dayEvents = new List<Event>(0);
        public List<Event> DayEvents
        {
            get => _dayEvents;
            set
            {
                _dayEvents = value;
                EventsChanged();
            }
        }
       
        public DayControl()
        {
            InitializeComponent();
            lblEventMarker.DoubleClick += (s, e) => OnDoubleClick(e);
            lblDayOfMonth.DoubleClick += (s, e) => OnDoubleClick(e);
        }

      
        public DateTime _date;
        /// <summary>
        /// Get the date, then assign the appropriate date and write on the control only the day .
        /// </summary>
        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                lblDayOfMonth.Text = _date.ToString("dd");
            }
        }
        /// <summary>
        ///  Control's color change to same as the background color when clicked on another day.
        /// </summary>
        public void ClearSelection()
        {
            BackColor = Color.ForestGreen;
        }
        /// <summary>
        /// Update the view of the day when event collection of this day changed. 
        /// </summary>
        private void EventsChanged()
        {
            lblEventMarker.Visible = _dayEvents?.Count > 0;
        }

        internal void Clear()
        {
            _dayEvents.Clear();
            lblEventMarker.Visible = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DayControl_Load(object sender, EventArgs e)
        {

        }

        private void DayControl_MouseDown(object sender, MouseEventArgs e)
        {
            
        }


        /// <summary>
        /// Color change to light blue when day is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DayControl_MouseClick(object sender, MouseEventArgs e)
        {
            BackColor = Color.LightBlue;
            DayClicked?.Invoke(this, new EventArgs());


        }
    }
}
