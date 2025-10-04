using agdata.Domain.Entities.Event;
using agdata.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Infrastructure
{
    public class InMemoryEventRepository : IEventRepository
    {
        public void Add(Event e)
        {
            if (e == null) throw new ArgumentNullException(nameof(e));
            InMemoryDatabase.Events.Add(e);
        }

        public Event GetById(Guid eventId)
        {
            foreach (var ev in InMemoryDatabase.Events)
            {
                if (ev != null && ev.GetType().GetProperty("Id")?.GetValue(ev) is Guid id && id == eventId)
                    return ev;
            }
            return null;
        }

        public IEnumerable<Event> GetAll()
        {
            return InMemoryDatabase.Events;
        }
    }
}
