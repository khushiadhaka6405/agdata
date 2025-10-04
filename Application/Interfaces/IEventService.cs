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
        Event Create(string name, DateTime date, int pointsAwarded);
        IEnumerable<Event> GetAll();
        Event GetById(Guid id);
        void AwardPoints(Guid eventId, Guid userId);
    }
}
