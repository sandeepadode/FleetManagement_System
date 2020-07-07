using System;
using System.Collections.Generic;
using System.Text;

namespace SystemFinalExam
{
    /// <summary>
    /// Using Controller Pattern to represents the overall system or represents the overall
    /// business logic or a system handler which is responsible for all the system operations.
    /// </summary>
    public class TicketHandler
    {
        /// <summary>
        /// Firstly, this is one of the controller we have designed for processing ticket related operation.
        /// All these are the operations related to systems operations.
        /// 
        /// Secondly, The class TicketHandler also acheive the High Cohesion, to keep all ticket related operation in the same class.
        /// The functionality which includes 'CancelTicket', 'ReserveTicket', 'SelectMeal', 'ModifySeat' , 'UpgradeSeat', 'ExtraBaggageRequest' and 'WebCheckIn'
        /// </summary>
        /// <param name="myTicket"></param>
        public Ticket BookTicket(Ticket myTicket)
        {
            Console.WriteLine("---Successfully Purchased the Ticket---");
            return myTicket;
        }
        /// <summary>
        /// Customer cancel thier tickect by using Tickect Handler Controller.
        /// </summary>
        /// <param name="myTicket"></param>
        public void CancelTicket(Ticket myTicket)
        {
            myTicket = null;
            Console.WriteLine("---Successfully Cancelled the Ticket---");
        }
        /// <summary>
        /// Customer reserve thier ticket by using Tickect Handler Controller.
        /// </summary>
        /// <param name="myTicket"></param>
        public void ReserveTicket(Ticket myTicket)
        {
            Random random = new Random();
            myTicket.TicketId = random.Next(0, 1000000);
            Console.WriteLine("---Successfully Reserved the Ticket---");
            Console.WriteLine("Your ticket ID is :'{0}'", myTicket.TicketId);
            Console.WriteLine("-------------------------------------");
        }
        /// <summary>
        /// Customer select thier meal by using Tickect Handler Controller.
        /// </summary>
        /// <param name="myTicket"></param>
        public void SelectMeal(Ticket myTicket, MealType mealType)
        {
            myTicket.Meal = mealType;
            Console.WriteLine("---Successfully Selected the Meal---");
            Console.WriteLine("Your meal is '{0}'.", mealType.ToString());
            Console.WriteLine("-------------------------------------");
        }
        /// <summary>
        /// Customer can modify thier seat by using Tickect Handler Controller.
        /// </summary>
        /// <param name="myTicket"></param>
        public void ModifySeat(Ticket myTicket, string mySeat)
        {
            myTicket.Seat = mySeat;
            Console.WriteLine("---Successfully Modified the Seat---");
            Console.WriteLine("Your Seat now is '{0}'.", myTicket.Seat);
            Console.WriteLine("-------------------------------------");
        }
        /// <summary>
        /// Customer can upgrade thier seat by using Tickect Handler Controller.
        /// </summary>
        /// <param name="myTicket"></param>
        public void UpgradeTicket(Ticket myTicket, string typeOfTicket)
        {
            TicketFactory ticketProvider = null;
            Ticket myNewTicket = null;
            switch (typeOfTicket)
            {
                case "Economy":
                    ticketProvider = new EconomyTicketFactory();
                    break;
                case "PremiunEconomy":
                    ticketProvider = new PremiumEconomyTicketFactory();
                    break;
                case "Business":
                    ticketProvider = new BusinessTicketFactory();
                    break;

            }
            myNewTicket = ticketProvider.GetTicket();
            myTicket.TicketType = myNewTicket.TicketType;
            myTicket.IsCancellationInsuranceApplied = myNewTicket.IsCancellationInsuranceApplied;
            myTicket.CancellationDuration = myNewTicket.CancellationDuration;
            myTicket.UserInsurance = myNewTicket.UserInsurance;
            Console.WriteLine("---Successfully Upgraded the seat---");
            Console.WriteLine("Your Seat Level now is '{0}'.", myTicket.TicketType);
            Console.WriteLine("-------------------------------------");

        }
        /// <summary>
        /// Customer can request the extra baggage by using Tickect Handler Controller.
        /// </summary>
        public void ExtraBaggageRequest()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Customer can check in through web by using Tickect Handler Controller.
        /// </summary>
        public void WebCheckIn()
        {
            throw new NotImplementedException();
        }
    }
}
