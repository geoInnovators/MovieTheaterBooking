// Models/BookingManager.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieTheaterBooking.Models
{
    public class BookingManager : IBookingManager
    {

        public void Init(int rowsCount, int columnsCount)
        {
            throw new NotImplementedException();
        }

        public Result CreateBooking(int k, BookingRequestType type)
        {
            throw new NotImplementedException();
        }

        public Result DeleteBooking(string bookingNumber)
        {
            throw new NotImplementedException();
        }

        public List<string> GetBoard()
        {
            return new List<string>();
        }

        public List<string> GetCurrentBookings()
        {
            return new List<string>();
        }
    }
}
