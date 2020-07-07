using System;
using System.Collections.Generic;
using System.Text;

namespace SystemFinalExam
{
    /// <summary>
    /// The Observer interface
    /// </summary>
    public interface IEmployee
    {
        void ScheduleFlight(Flight flight);
        void AddAircraftsToFleet(Flight flight);
        void AddingFlightBetweenTwoLocations();

    }
}
