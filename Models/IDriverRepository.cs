using System.Collections.Generic;

namespace TrafikSkola.Models
{
    public interface IDriverRepository
    {
        IEnumerable<Booking> AllBookings { get; }
        IEnumerable<Driver> AllDrivers { get; set; }

        Booking GetAppointmentsById(int BookingId);
    }
}
