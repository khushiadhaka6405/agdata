using agdata.Application.Interfaces;
using agdata.Domain.Entities.Event;
using agdata.Infrastructure;
using System;
using System.Collections.Generic;

namespace Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository; // repository for storing events

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository; // inject event repository
        }

        // Create a new event
        public Event CreateEvent(string name, DateTime date, int points)
        {
            var e = new Event
            {
                Id = Guid.NewGuid(), // generate unique event ID
                Name = name,         // set event name
                Date = date,         // set event date
                PointsAwarded = points      // set points for event
            };

            _eventRepository.Add(e); // store event
            return e;
        }

        // Get all events
        public IEnumerable<Event> GetAllEvents() => _eventRepository.GetAll();

        // Get a specific event by ID
        public Event GetEventById(Guid id)
        {
            var e = _eventRepository.GetById(id);
            if (e == null) throw new Exception("Event not found"); // throw error if not found
            return e;
        }
    }
}

