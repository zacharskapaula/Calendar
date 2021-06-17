using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class InMemoryCalendarEventData : ICalendarEventData
    {
        private List<Event> reminder = new List<Event>(35);
        public InMemoryCalendarEventData()
        {

        }
        public void GetEventsByMonth()
        {

        }
        public void GetSettings()
        {

        }
        public void CreateEvent(Event newEvent)
        {

        }
        public void DeleteEvent(Event eventToDelete)
        {

        }
        public void Save()
        {

        }
    }
}
