using System;
using System.Collections.Generic;
using System.Text;

namespace SystemFinalExam
{
    public class Customer : User
    {
        private int customerId;
        private string customerName;
        private int phoneNumber;
        private string nationalIdentity;
        private Ticket myTicket;

        public int CustomerId
        {
            get => this.customerId; set => this.customerId = value;
        }
        public string CustomerName
        {
            get => this.customerName; set => this.customerName = value;
        }
        public int PhoneNumber
        {
            get => this.phoneNumber; set => this.phoneNumber = value;
        }
        public string NationalIdentity
        {
            get => this.nationalIdentity; set => this.nationalIdentity = value;
        }
        public Ticket MyTicket
        {
            get => this.myTicket; set => this.myTicket = value;
        }

        public Customer()
        {
            this.CustomerId = 0;
            this.CustomerName = "";
            this.PhoneNumber = 0;
            this.NationalIdentity = "";
            this.MyTicket = null;
        }


        public List<Flight> SearchForFlight()
        {
            List<Flight> result = new List<Flight>();
            return result;
        }
        public List<Booking> ViewTravelHistory(Customer customer)
        {
            throw new NotImplementedException();
        }
    }    
}
