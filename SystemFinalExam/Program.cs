using System;
using System.Collections.Generic;

namespace SystemFinalExam
{
    class Program
    {   
        static void Main(string[] args)
        {
            User user = new User();            
            List<Customer> customerList = new List<Customer>();
            Employee employee = new Employee();
            Flight flight = new Flight();

            user.Register("dalibor@conestoga.ca", "dvorski");
            user.Login("dalibor", "dvorski");

            initializePassenger(customerList);
            initializeFlight(flight, customerList);
            ShowCustomerTicketDetails(customerList);

            //Simulate single customer change their ticket's detail.
            ChangeTicketInfo(customerList[0].MyTicket);
            
            //Simulate when the employee do some action that relates to the aircraft, and it will broacast to whole passenger.
            employee.AddAircraftsToFleet(flight);
            employee.ScheduleFlight(flight);
            employee.AddClassesToFlight(flight);

            ShowListOfAircraftCompanyOwns();
            Console.Read();
        }
        /// <summary>
        /// Initialize the Passenger List
        /// </summary>
        /// <param name="customersList"></param>
        private static void initializePassenger(List<Customer> customersList)
        {
            //TicketHandler deals with all the functionalities which related to the ticket.
            TicketHandler ticketHandler = new TicketHandler();
            //High Cohesion and low coupling between TicketHandler, TicketFactory, Ticket and Customer classes.
            InsuranceFactory insuranceCompany = new AdvancedInsuranceProvider(200, "Comprehensive Coverage");
            Insurance myInsurance = insuranceCompany.GetInsurance();
            TicketFactory ticketProvider = new PremiumEconomyTicketFactory(48, true, myInsurance);
            Ticket myTicket = ticketProvider.GetTicket();

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();
            customersList.Add(customer1);
            customersList.Add(customer2);
            customersList.Add(customer3);

            foreach (Customer customer in customersList)
            {
                Random rd = new Random();
                customer.CustomerId = rd.Next(0, 100000);
                customer.CustomerName = "Customer" + rd.Next(1, 100).ToString();
                customer.MyTicket = ticketHandler.BookTicket(myTicket);
            }
        }
        /// <summary>
        /// Initialize Flight Information
        /// </summary>
        /// <param name="myFlight"></param>
        /// <param name="customersList"></param>
        private static void initializeFlight(Flight myFlight, List<Customer> customersList)
        {
            myFlight.FlightId = 123456789;
            myFlight.FlightType = FlightType.Airbus;
            myFlight.MakeYear = "2019";
            myFlight.FleetIdentificationNumber = 2020;
            myFlight.Destination = "YYZ";
            myFlight.ObserverList = customersList;
            foreach (Customer customer in customersList)
            {
                customer.MyTicket.Flight = myFlight;
            }
        }
        /// <summary>
        /// Simulate the user try to change the ticket's detail.
        /// </summary>
        /// <param name="myTicket"></param>
        public static void ChangeTicketInfo(Ticket myTicket)
        {
            TicketHandler ticketHandler = new TicketHandler();
            ticketHandler.UpgradeTicket(myTicket, "Business");
            ticketHandler.ModifySeat(myTicket, "Seat C1");
            ticketHandler.SelectMeal(myTicket, MealType.Vegetarian);
            ticketHandler.ReserveTicket(myTicket);
            Console.WriteLine("----After Modify the ticket----");
            Console.WriteLine("My Ticket Detail is here:");
            Console.WriteLine("Ticket Type: {0}\n---------------", myTicket.TicketType);
            Console.WriteLine("My Ticket ID: {0}\nMy meal: {1}\nMy Seat: {2}", myTicket.TicketId, myTicket.Meal, myTicket.Seat);
        }
        private static void ShowCustomerTicketDetails(List<Customer> customersList)
        {
            foreach (Customer customer in customersList)
            {
                Console.WriteLine("----------Ticket Detail----------");
                Console.WriteLine("Customer Name -{0}| Customer ID-{1}", customer.CustomerName, customer.CustomerId);
                Console.WriteLine("Ticket Type: {0}\nInsurance Purchasing: {1}.\nCancelation Duration: {2}.\n---------------", customer.MyTicket.TicketType, customer.MyTicket.IsCancellationInsuranceApplied, customer.MyTicket.CancellationDuration);
                Console.WriteLine("Insurance Detail\n------------------\n" +
                "Insurance Type: {0}\nInsurance Price: {1}\nFeature: {2}\n", customer.MyTicket.UserInsurance.InsuranceType, customer.MyTicket.UserInsurance.Price, customer.MyTicket.UserInsurance.Feature);
                Console.WriteLine("Flight Detail\n------------------");
                Console.WriteLine("Flight Type-{0} | Flight ID-{1} |\nDestination-{2}\nFleet Identification-{3}\n", customer.MyTicket.Flight.FlightType, customer.MyTicket.Flight.FlightId, customer.MyTicket.Flight.Destination, customer.MyTicket.Flight.FleetIdentificationNumber);
            }
        }

        /// <summary>
        /// Initialize the all aircrafts that company owns and print out the list.
        /// </summary>
        private static void ShowListOfAircraftCompanyOwns()
        {
            var airCondor = new AirCondor("", 1);
            airCondor.ListOfAircraft.Add(new Boeing(" Model: 777-300ER", 19));
            airCondor.ListOfAircraft.Add(new Boeing(" Model: 777-200LR", 15));
            airCondor.ListOfAircraft.Add(new Boeing(" Model: 787-9", 8));
            airCondor.ListOfAircraft.Add(new Boeing(" Model: 787-8", 6));
            airCondor.ListOfAircraft.Add(new Airbus(" Model: A330-300", 22));

            var airCondorExpress = new AirCondorExpress("", 1);
            airCondorExpress.ListOfAircraft.Add(new Bombardier(" Model: RCJ200", 25));
            airCondorExpress.ListOfAircraft.Add(new Bombardier(" Model: Q400", 21));
            airCondorExpress.ListOfAircraft.Add(new Bombardier(" Model: CRJ705", 16));
            airCondorExpress.ListOfAircraft.Add(new Embraer(" Model: E175", 15));

            var airCondorRed = new AirCondorRed("", 1);
            airCondorRed.ListOfAircraft.Add(new Airbus(" Model: A319-100", 20));
            airCondorRed.ListOfAircraft.Add(new Boeing(" Model: 767-300ER", 9));

            Console.WriteLine("----Air Condor's Aircrafts----");
            airCondor.DisplayAllItem();
            Console.WriteLine("----Air Condor Express' Aircrafts----");
            airCondorExpress.DisplayAllItem();
            Console.WriteLine("----Air Condor Red's Aircrafts----");
            airCondorRed.DisplayAllItem();
        }
    }
}
