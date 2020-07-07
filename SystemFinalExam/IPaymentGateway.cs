using System;
using System.Collections.Generic;
using System.Text;

namespace SystemFinalExam
{
    /// <summary>
    /// IPaymentGateway is an adapter that connect 'Booking' class and 'Ticket' class
    /// The Interface Payment Gateway which will stand as an interface to do PayForTicket functionality
    ///  , without actually impacting the current environment.
    /// </summary>
    interface IPaymentGateway
    {
        public void PayForTicket(Booking booking);
    }
}
