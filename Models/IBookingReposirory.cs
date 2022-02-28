using System.Collections.Generic;

namespace TrafikSkola.Models
{
     interface IBookingReposirory
    {
        IEnumerable<Booking> AllBookings { get; }
    }
}
