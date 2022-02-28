using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrafikSkola.Models
{
    public class Driver
    {
       
        
            public Driver()
            {
            }

            public Driver(string driverName, string skills, string imageUrl)
            {

                DriverName = driverName;
                Skills = skills;
                ImageUrl = imageUrl;

            }
            [Key]
            public int DriverId { get; set; }
            public string DriverName { get; set; }
            public string Skills{ get; set; }

            public string ImageUrl { get; set; }
            public List<Learner> Learners { get; set; }
        
    }
}
