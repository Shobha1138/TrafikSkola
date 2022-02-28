using System.Collections.Generic;

namespace TrafikSkola.Models
{
     interface ILearnerRepository
    {
        IEnumerable<Driver> AllDrivers { get; }
    }
}
