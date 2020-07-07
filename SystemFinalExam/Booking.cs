using System;
using System.Collections.Generic;
using System.Text;

namespace SystemFinalExam
{
    public class Booking:IPaymentGateway
    {
        private int bookingId;
        private DateTime bookingDate;
        private string bookingStatus;
        private Customer customer;

        public int BookingId 
        {
            get => this.bookingId; set => this.bookingId = value;
        }
        public DateTime BookingDate
        {
            get => this.bookingDate; set => this.bookingDate = value;
        }
        public string BookingStatus
        {
            get => this.bookingStatus; set => this.bookingStatus = value;
        }
        public Customer Customer
        {
            get => this.customer; set => this.customer = value;
        }

        public Booking()
        {
            this.BookingId = 0;
            this.BookingDate = default;
            this.BookingStatus = "";
            this.Customer = null;
        }

        public void PayForTicket(Booking booking) 
        {
            throw new NotImplementedException();
        }      

    }
}
