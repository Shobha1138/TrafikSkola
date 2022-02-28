﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrafikSkola.Models
{
    public class Booking
    {
        public Booking()
        {
        }

        public Booking(DateTime dateTime, Driver driver, Learner learner, DateTime start, DateTime end)
        {

            Start = start;
            End = end;

            Driver = driver;

            Learner = learner;
        }


        public int BookingId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        [Display(Name = "Driver")]
        public int DriverId { get; set; }


        [ForeignKey("DriverId")]
        public Driver Driver { get; set; }

        [Display(Name = "Learner")]
        public int LearnerId { get; set; }

        [ForeignKey("LearnerId")]
        public Learner Learner { get; set; }
    }
}
