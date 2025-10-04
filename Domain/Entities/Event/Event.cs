using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.Event
{
    public class Event
    {
        public string Name { get; private set; }
        public DateTime Date { get; private set; }
        public int PointsAwarded { get; private set; }

        public Event(string name, DateTime date, int pointsAwarded)
        {
            if (pointsAwarded <= 0) throw new ArgumentException("Points must be positive.");
            Name = name;
            Date = date;
            PointsAwarded = pointsAwarded;
        }
    }
}
