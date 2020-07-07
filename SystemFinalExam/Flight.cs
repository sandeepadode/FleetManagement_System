using System;
using System.Collections.Generic;
using System.Text;

namespace SystemFinalExam
{   
    public enum FlightType 
    { 
        Airbus=1,
        Boeing,
        Bombardier,
        Embraer
    }
    public class Flight
    {
        private int flightId;
        private String makeYear;
        private int fleetIdentificationNumber;
        private string source;
        private string destination;
        private DateTime operationDateTime;
        private FlightType flightType;
        private int numberOfAvailableSeats;
        static private List<Customer> observerList = new List<Customer>();
        public Flight()
        {
            this.FlightId = 0;
            this.MakeYear = "";
            this.FleetIdentificationNumber = 0;
            this.Source = "";
            this.Destination = "";
            this.OperationDateTime = default;
            this.FlightType = 0;
            this.NumberOfAvailableSeats = 0;
            this.ObserverList = null;
        }

        public List<Customer> ObserverList 
        { 
            get => observerList; set => observerList = value; 
        }
        public void Attach(Customer customer)
        {
            observerList.Add(customer);
        }
        public void Notify(string notification)
        {
            Console.WriteLine("---Broadcast Start---");
            foreach (Customer customer in observerList)
            {
                Console.WriteLine("-Notification- Customer:{0} {1}", customer.CustomerName, notification);
            }
            Console.WriteLine("---Broadcast End---");
        }
        public int FlightId
        {
            get => this.flightId; set => this.flightId = value;
        }
        public String MakeYear
        {
            get => this.makeYear; set => this.makeYear = value;
        }
        public int FleetIdentificationNumber
        {
            get => this.fleetIdentificationNumber; set => this.fleetIdentificationNumber = value;
        }
        public string Source
        {
            get => this.source; set => this.source = value;
        }
        public string Destination
        {
            get => this.destination; set => this.destination = value;
        }
        public DateTime OperationDateTime
        {
            get => this.operationDateTime; set => this.operationDateTime = value;
        }
        public FlightType FlightType
        {
            get => this.flightType; set => this.flightType = value;
        }
        public int NumberOfAvailableSeats
        {
            get => this.numberOfAvailableSeats; set => this.numberOfAvailableSeats = value;
        }
    }
}
