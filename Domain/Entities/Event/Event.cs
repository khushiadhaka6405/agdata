using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.Event
{
    public class Event
    {
        public Guid Id { get; set; } // added ID
        public string Name { get; set; } // changed to public setter
        public DateTime Date { get; set; } // changed to public setter
        public int PointsAwarded { get; set; } // changed to public setter

        public Event(string name, DateTime date, int pointsAwarded)
        {
            if (pointsAwarded <= 0) throw new ArgumentException("Points must be positive.");
            Name = name;
            Date = date;
            PointsAwarded = pointsAwarded;
        }

        public Event() { } // default constructor so initializer works
    }
}
