using Booking;
using NUnit.Framework;
using System;

namespace BookingTests
{
    [TestFixture]
    public class HotelTest
    {
        private Hotel hotel;
        private DateTime startDate;
        private DateTime endDate;

        [SetUp]
        public void Setup()
        {
            hotel = new Hotel();
            startDate = new DateTime(2022, 11, 1);
            endDate = new DateTime(2022, 11, 5);
        }

        [Test]
        public void BookingWhenHotelAvailableShouldWork()
        {
            hotel.AddReservation(startDate, endDate);

            Assert.AreEqual(1, hotel.Reservations.Count, "Reservation has not been added correctly");
            Assert.IsTrue(startDate == hotel.Reservations[0].Start);
            Assert.AreEqual(endDate, hotel.Reservations[0].End);
        }

        [Test]
        public void MultipleBookingsWhenHotelAvailableShouldWork()
        {
            startDate = DateTime.Now;
            hotel.AddReservation(startDate, endDate);

            hotel.AddReservation(startDate.AddDays(10), endDate.AddDays(10));
            hotel.AddReservation(startDate.AddDays(25), endDate.AddDays(25));
            hotel.AddReservation(startDate.AddDays(56), endDate.AddDays(56));


            Assert.AreEqual(4, hotel.Reservations.Count, "Reservation has not been added correctly");
        }

        [Test]
        public void TryingToAddOverlappingReservationAtEndDateShouldThrow()
        {
            startDate = new DateTime(2022, 11, 10);
            endDate = new DateTime(2022, 11, 15);

            hotel.AddReservation(startDate, endDate);

            // end overlap
            DateTime secondStartDate = new DateTime(2022, 11, 14);
            DateTime secondEndDate = new DateTime(2022, 11, 17);

            Assert.Throws<ArgumentException>(() =>
            {
                hotel.AddReservation(secondStartDate, secondEndDate);
            });

            // start overlap
            startDate = new DateTime(2022, 11, 8);
            endDate = new DateTime(2022, 11, 13);

            Assert.Throws<ArgumentException>(() =>
            {
                hotel.AddReservation(startDate, endDate);
            }, "Start date overlap broken");

            // full overlap
            startDate = new DateTime(2020, 11, 5);
            endDate = new DateTime(2025, 11, 20);

            Assert.Throws<ArgumentException>(() =>
            {
                hotel.AddReservation(startDate, endDate);
            });
        }
    }
}