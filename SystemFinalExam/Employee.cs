using System;
using System.Collections.Generic;
using System.Text;

namespace SystemFinalExam
{
    enum Roles
    { 
        Admin = 1,
        CustomerServiceAgent = 2
    }

    /// <summary>
    /// The 'Employee' class is Concrete Observers. Whenever the flight is change or modify, the customer should know.
    /// That is the reason why we implement the Observer Pattern at this class.
    /// </summary>
    class Employee : User, IEmployee
    {
        private string employeeId;
        private Roles employeeRole;
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public Roles EmployeeRole
        {
            get => this.employeeRole; set => this.employeeRole = value;
        }

        public Employee()
        {
            this.EmployeeId = "";
            this.EmployeeRole = 0;
        }
        /// <summary>
        /// The ScheduleFlight function let employee can schedule the flight.
        /// </summary>
        /// <param name="flight"></param>
        public void ScheduleFlight(Flight flight)
        {
            flight.Notify("The Flight" + " -" + flight.FlightId.ToString() + " has been scheduled");
        }
        /// <summary>
        /// The 'AddAircraftsToFleet' function provides the employee can add aircrafts to Fleet.
        /// </summary>
        /// <param name="flight"></param>
        public void AddAircraftsToFleet(Flight flight) 
        {
            flight.Notify("The aircrafts" + " -" + flight.FlightId.ToString() + " have been added to fleet.");
        }
        /// <summary>
        /// The function 'AddingFlightBetweenTwoLocations' provides the employee can adding flight between two locations.
        /// </summary>
        public void AddingFlightBetweenTwoLocations() 
        {
            throw new NotImplementedException();
        }

        public void AddClassesToFlight(Flight flight)
        {
            flight.Notify("The classes Economy, Premium Economy and Business have been added to the flight");
        }

    }
}
