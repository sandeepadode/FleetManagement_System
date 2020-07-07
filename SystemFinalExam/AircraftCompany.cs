using System;
using System.Collections.Generic;
using System.Text;

namespace SystemFinalExam
{
    /// <summary>
    /// The 'AircraftCompany' class is implement the Composite Design Pattern which can treat groups of the objects in the hierarchy equally.
    /// Note: 'AircraftCompany' class is Component abstract class
    /// </summary>
    public abstract class AircraftCompany
    {
        private string name;
        private int quantity;
        private List<AircraftCompany> listOfAircraft;
        public string Name
        {
            get => this.name; set => this.name = value;
        }
        public int Quantity
        {
            get => this.quantity; set => this.quantity = value;
        }
        public List<AircraftCompany> ListOfAircraft
        {
            get => this.listOfAircraft; set => this.listOfAircraft = value;
        }

        public AircraftCompany(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
            this.listOfAircraft = new List<AircraftCompany>();
        }
        /// <summary>
        /// The DisplayAllItem function let user to list certain groups of the objects in the hierarchy.
        /// </summary>
        public void DisplayAllItem()
        {
            Console.WriteLine(this.GetType().Name + " |" + this.Name.ToString() + " |Quantity:" + this.Quantity);
            foreach (var item in this.listOfAircraft)
            {
                item.DisplayAllItem();
            }
        }
    }
    /// <summary>
    /// Leaf class in Composite Pattern
    /// </summary>
    public class Airbus: AircraftCompany
    {
        public Airbus(string name, int quantity) : base(name, quantity) { }
    }
    /// <summary>
    /// Leaf class in Composite Pattern
    /// </summary>
    public class Boeing : AircraftCompany
    {
        public Boeing(string name, int quantity) : base(name, quantity) { }
    }
    /// <summary>
    /// Leaf class in Composite Pattern
    /// </summary>
    public class Bombardier : AircraftCompany
    {
        public Bombardier(string name, int quantity) : base(name, quantity) { }
    }
    /// <summary>
    /// Leaf class in Composite Pattern
    /// </summary>
    public class Embraer : AircraftCompany
    {
        public Embraer(string name, int quantity) : base(name, quantity) { }
    }
    /// <summary>
    /// Composite class
    /// </summary>
    public class AirCondor : AircraftCompany
    {
        public AirCondor(string name, int quantity) : base(name, quantity) { }
    }
    /// <summary>
    /// Composite class
    /// </summary>
    public class AirCondorExpress : AircraftCompany
    {
        public AirCondorExpress(string name, int quantity) : base(name, quantity) { }
    }
    /// <summary>
    /// Composite class
    /// </summary>
    public class AirCondorRed : AircraftCompany
    {
        public AirCondorRed(string name, int quantity) : base(name, quantity) { }
    }
}