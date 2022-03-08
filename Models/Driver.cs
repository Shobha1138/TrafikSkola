using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrafikSkola.Models
{
    public class Driver
    {
        //public Driver(string driverName, string vechicalType, string fileName, byte[] file)
        //{
        //    DriverName = driverName;
        //    VechicalType = vechicalType;
        //    FileName = fileName;
        //    File = file;
        //}

        [Key]
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string VechicalType { get; set; }

        

        public string FileName { get; set; }
        public byte[] File { get; set; }

        [NotMapped]
        public IFormFile FileForm { get; set; }
        public List<Learner> Learners { get; set; }
    }
}

