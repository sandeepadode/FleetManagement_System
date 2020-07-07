using System;
using System.Collections.Generic;
using System.Text;

namespace SystemFinalExam
{
    /// <summary>
    /// The 'Fleet' class is is used to return the list of flights in a fleet.
    /// </summary>
    public class Fleet
    {
        private List<Flight> flightList;
        public List<Flight> FlightList
        {
            get => flightList;set => flightList = value;
        }
        public Fleet()
        {
            this.FlightList = null;
        }        
    }
}
