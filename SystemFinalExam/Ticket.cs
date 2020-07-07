using System;
using System.Collections.Generic;
using System.Text;

namespace SystemFinalExam
{
    public enum Baggage 
    { 
        CheckIn=1,
        Cabin,
        HandLuggage
    }
    public enum MealType
    { 
        Vegetarian=1,
        NonVegetarian,
        VegetarianWithEggs
    }
    public enum TicketType
    { 
        Economy=1,
        PremiumEconomy,
        Business
    }
    /// <summary>
    /// 1. The 'Tickect' class implement the factory pattern which provide three different grade of ticket.
    /// 2. The 'Product' Abstract Class
    /// </summary>
    public abstract class Ticket
    {
        private int ticketId;
        private Baggage baggage;
        private string seat;
        private MealType meal;
        private Flight flight;
        private int duration;
        private List<Flight> connection;
        private DateTime departureTime;
        private DateTime arrivalTime;
        private Booking booking;       

        public int TicketId 
        {
            get => this.ticketId; set => this.ticketId = value;
        }
        public Booking Booking
        {
            get => this.booking; set => this.booking = value;
        }
        public Baggage Baggage 
        {
            get => this.baggage; set => this.baggage = value;
        }
        public string Seat
        {
            get => this.seat; set => this.seat = value;
        }
        public MealType Meal
        {
            get => this.meal; set => this.meal = value;
        }
        public Flight Flight
        {
            get => this.flight; set => this.flight = value;
        }
        public int Duration
        {
            get => this.duration; set => this.duration = value;
        }
        public List<Flight> Connection
        {
            get => this.connection; set => this.connection = value;
        }
        public DateTime DepartureTime
        {
            get => this.departureTime; set => this.departureTime = value;
        }
        public DateTime ArrivalTime
        {
            get => this.arrivalTime; set => this.arrivalTime = value;
        }
        public abstract TicketType TicketType
        {
            get; set;
        }
        public abstract int CancellationDuration
        {
            get; set;
        }
        public abstract bool IsCancellationInsuranceApplied
        {
            get; set;
        }
        public abstract Insurance UserInsurance
        {
            get; set;
        }

        public Ticket()
        {
            this.TicketId = 0;
            this.Booking = null;
            this.Baggage = 0;
            this.Seat = "";
            this.Meal = 0;
            this.Flight = null;
            this.Duration =0;
            this.Connection = null;
            this.DepartureTime = default;
            this.ArrivalTime = default;
            this.TicketType = 0;
            this.CancellationDuration = 0;
            this.IsCancellationInsuranceApplied = false;
            this.UserInsurance = null;
        }
        //public void PayForTicket()
        //{
        //    throw new NotImplementedException();
        //}
        public void InitiateRefund()
        {
            throw new NotImplementedException();
        }

        public void ApplyCancellationInsurance()
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// ConcreteProduct - EconomyTicket
    /// </summary>
    class EconomyTicket : Ticket
    {
        private TicketType tickectType;
        private bool isCancelationInsuranceApplied;
        private int cancelationDuration;
        private Insurance myInsurance;

        public EconomyTicket(bool isCancelationInsuranceApplied, int cancelationDuration, Insurance myInsurance)
        {
            this.TicketType = TicketType.Economy;
            this.IsCancellationInsuranceApplied = isCancelationInsuranceApplied;
            this.CancellationDuration = cancelationDuration;
            this.UserInsurance = myInsurance;
        }
        public EconomyTicket()
        {
            this.TicketType = TicketType.Economy;
            this.IsCancellationInsuranceApplied = false;
            this.CancellationDuration = 0;
            this.UserInsurance = null;
        }
        public override bool IsCancellationInsuranceApplied
        {
            get { return isCancelationInsuranceApplied; }
            set { isCancelationInsuranceApplied = value; }
        }
        public override int CancellationDuration
        {
            get { return cancelationDuration; }
            set { cancelationDuration = value; }
        }
        public override Insurance UserInsurance 
        {
            get { return myInsurance; }
            set { myInsurance = value; }
        }
        public override TicketType TicketType 
        {
            get { return tickectType; }
            set { tickectType = value; }
        }
    }
    /// <summary>
    /// ConcreteProduct - PremiunEconomyTicket
    /// </summary>
    class PremiunEconomyTicket : Ticket
    {
        private TicketType tickectType;
        private bool isCancelationInsuranceApplied;
        private int cancelationDuration;
        private Insurance myInsurance;
        public PremiunEconomyTicket(bool isCancelationInsuranceApplied, int cancelationDuration, Insurance myInsurance)
        {
            this.TicketType = TicketType.PremiumEconomy;
            this.IsCancellationInsuranceApplied = isCancelationInsuranceApplied;
            this.CancellationDuration = cancelationDuration;
            this.UserInsurance = myInsurance;
        }
        public PremiunEconomyTicket()
        {
            this.TicketType = TicketType.PremiumEconomy;
            this.IsCancellationInsuranceApplied = false;
            this.CancellationDuration = 0;
            this.UserInsurance = null;
        }
        public override bool IsCancellationInsuranceApplied
        {
            get { return isCancelationInsuranceApplied; }
            set { isCancelationInsuranceApplied = value; }
        }
        public override int CancellationDuration 
        {
            get { return cancelationDuration; }
            set { cancelationDuration = value; }
        }
        public override Insurance UserInsurance
        {
            get { return myInsurance; }
            set { myInsurance = value; }
        }
        public override TicketType TicketType
        {
            get { return tickectType; }
            set { tickectType = value; }
        }
    }
    /// <summary>
    /// ConcreteProduct - BusinessTicket
    /// </summary>
    class BusinessTicket : Ticket
    {
        private TicketType tickectType;
        private bool isCancelationInsuranceApplied;
        private int cancelationDuration;
        private Insurance myInsurance;

        public BusinessTicket(bool isCancelationInsuranceApplied, int cancelationDuration, Insurance myInsurance)
        {
            this.TicketType = TicketType.Business;
            this.IsCancellationInsuranceApplied = isCancelationInsuranceApplied;
            this.CancellationDuration = cancelationDuration;
            this.UserInsurance = myInsurance;
        }
        public BusinessTicket()
        {
            this.TicketType = TicketType.Business;
            this.IsCancellationInsuranceApplied = false;
            this.CancellationDuration = 0;
            this.UserInsurance = null;
        }
        public override bool IsCancellationInsuranceApplied
        {
            get { return isCancelationInsuranceApplied; }
            set { isCancelationInsuranceApplied = value; }
        }
        public override int CancellationDuration
        {
            get { return cancelationDuration; }
            set { cancelationDuration = value; }
        }
        public override Insurance UserInsurance
        {
            get { return myInsurance; }
            set { myInsurance = value; }
        }
        public override TicketType TicketType
        {
            get { return tickectType; }
            set { tickectType = value; }
        }
    }
    /// <summary>
    /// A 'Creator' Abstract Class for Factory Pattern
    /// </summary>
    abstract class TicketFactory
    {
        public abstract Ticket GetTicket();
    }
    /// <summary>
    /// A 'Concrete Creator' Class for Factory Pattern
    /// </summary>
    class EconomyTicketFactory : TicketFactory
    {
        private int cancelDuration;
        private bool isCancelationInsuranceApplied;
        private Insurance myInsurance;
        public int CancelDuration
        {
            get => cancelDuration;
            set => cancelDuration = value;
        }
        public bool IsCancelationInsuranceApplied
        {
            get => isCancelationInsuranceApplied;
            set => isCancelationInsuranceApplied = value;
        }
        public Insurance MyInsurance
        {
            get => myInsurance;
            set => myInsurance = value;
        }
        public EconomyTicketFactory(int cancelDuration, bool isCancelationInsuranceApplied, Insurance myInsurance)
        {
            this.CancelDuration = cancelDuration;
            this.IsCancelationInsuranceApplied = isCancelationInsuranceApplied;
            this.MyInsurance = myInsurance;
        }
        public EconomyTicketFactory()
        {
            this.IsCancelationInsuranceApplied = false;
            this.CancelDuration = 0;
            this.MyInsurance = null;
        }
        public override Ticket GetTicket()
        {
            return new EconomyTicket(this.IsCancelationInsuranceApplied, this.CancelDuration, this.MyInsurance);
        }
    }
    /// <summary>
    /// A 'Concrete Creator' Class for Factory Pattern
    /// </summary>
    class PremiumEconomyTicketFactory : TicketFactory
    {
        private int cancelDuration;
        private bool isCancelationInsuranceApplied;
        private Insurance myInsurance;

        public int CancelDuration
        {
            get => cancelDuration;
            set => cancelDuration = value;
        }
        public bool IsCancelationInsuranceApplied
        {
            get => isCancelationInsuranceApplied;
            set => isCancelationInsuranceApplied = value;
        }
        public Insurance MyInsurance
        {
            get => myInsurance;
            set => myInsurance = value;
        }

        public PremiumEconomyTicketFactory(int cancelDuration, bool isCancelationInsuranceApplied, Insurance myInsurance)
        {
            this.CancelDuration = cancelDuration;
            this.IsCancelationInsuranceApplied = isCancelationInsuranceApplied;
            this.MyInsurance = myInsurance;
        }
        public PremiumEconomyTicketFactory()
        {
            this.IsCancelationInsuranceApplied = false;
            this.CancelDuration = 0;
            this.MyInsurance = null;
        }
        public override Ticket GetTicket()
        {
            return new PremiunEconomyTicket(this.IsCancelationInsuranceApplied, this.CancelDuration, this.MyInsurance);
        }
    }
    /// <summary>
    /// A 'Concrete Creator' Class for Factory Pattern
    /// </summary>
    class BusinessTicketFactory : TicketFactory
    {
        private int cancelDuration;
        private bool isCancelationInsuranceApplied;
        private Insurance myInsurance;

        public int CancelDuration
        {
            get => cancelDuration;
            set => cancelDuration = value;
        }
        public bool IsCancelationInsuranceApplied
        {
            get => isCancelationInsuranceApplied;
            set => isCancelationInsuranceApplied = value;
        }
        public Insurance MyInsurance
        {
            get => myInsurance;
            set => myInsurance = value;
        }
        public BusinessTicketFactory(int cancelDuration, bool isCancelationInsuranceApplied, Insurance myInsurance)
        {
            this.CancelDuration = cancelDuration;
            this.IsCancelationInsuranceApplied = isCancelationInsuranceApplied;
            this.MyInsurance = myInsurance;
        }
        public BusinessTicketFactory()
        {
            this.IsCancelationInsuranceApplied = false;
            this.CancelDuration = 0;
            this.MyInsurance = null;
        }
        public override Ticket GetTicket()
        {
            return new BusinessTicket(this.IsCancelationInsuranceApplied, this.CancelDuration, this.MyInsurance);
        }
    }
}
