using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrafikSkola.Models
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string VechicalType { get; set; }

        //public string ImageUrl { get; set; }

        public string FileName { get; set; }
        public byte[] File { get; set; }

        [NotMapped]
        public IFormFile FileForm { get; set; }
        public List<Learner> Learners { get; set; }
    }
}

