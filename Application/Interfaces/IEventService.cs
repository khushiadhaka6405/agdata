using agdata.Domain.Entities.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Application.Interfaces
{
    public interface IEventService
    {
        Event CreateEvent(string name, DateTime date, int points);
        IEnumerable<Event> GetAllEvents();
        Event GetEventById(Guid id);
    }
}
