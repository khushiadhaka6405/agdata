using agdata.Domain.Entities.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Infrastructure
{
    public interface IEventRepository
    {
        void Add(Event ev);
        Event GetById(Guid id);
        IEnumerable<Event> GetAll();
    }
}
