using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class InMemoryCalendarEventData : ICalendarEventData
    {
        public List<Event> _calendarEvents;
        public InMemoryCalendarEventData()
        {
            _calendarEvents = new List<Event>
            {
                new Event { Title = "First short", Description = "First note description for test purposes", Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)},
                new Event { Title = "Second long text title test", Description = "dlfsdajfslkdfjsdklfjlkdsfjklsdkljfsdjflksdjk", Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15)},
                new Event { Title = "Third", Description = "Regular descirption", Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 20)}
            };
        }
        public List<Event> GetEventsByMonth(DateTime dateEvent)
        {
            return _calendarEvents.Where(ev => ev.Date.Year == dateEvent.Year && ev.Date.Month == dateEvent.Month).ToList();
        }
        public void GetSettings()
        {

        }
        public void CreateEvent(Event newEvent)
        {
            _calendarEvents.Add(newEvent);
        }
        public void DeleteEvent(Event eventToDelete)
        {
            _calendarEvents.Remove(eventToDelete);
        }
        public void Save()
        {

        }
    }
}
