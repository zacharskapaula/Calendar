using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
      public interface ICalendarEventData
    {
        public void GetSettings();
        public void GetEventsByMonth();
        public void CreateEvent(Event newEvent);
        public void DeleteEvent(Event eventToDelete);
        public void Save();
    }
}
