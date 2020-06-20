using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApi.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public string Phone { get; set; }
        public DateTime ReservationTime { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; } 
    }
}
