using System;
using System.Collections.Generic;
using System.Text;

namespace Booking
{
    public class Hotel
    {
        public Hotel()
        {
            Reservations = new List<Reservation>();
        }

        public List<Reservation> Reservations { get; set; }

        public void AddReservation(DateTime startDate, DateTime endDate)
        {
            CheckForOverlappingReservations(startDate, endDate);

            Reservations.Add(new Reservation()
            {
                Start = startDate,
                End = endDate
            });

        }

        private void CheckForOverlappingReservations(DateTime startDate, DateTime endDate)
        {
            foreach (var reservation in Reservations)
            {
                bool overlap = reservation.Start < endDate && startDate < reservation.End;

                if (overlap)
                {
                    throw new ArgumentException($"Hotel is already booked for {startDate} and {endDate}");
                }
            }
        }
    }
}
