﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.DtoLayer.Dtos.ReservationDto
{
    public class ListReservationDto
    {
        public int ReservationID { get; set; }
        public string? PersonCount { get; set; }
        public DateTime ReservastionDate { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
