using Facade.Classes;

#region Initialize manager

Hotel hotel = new Hotel("Hilton");

Tour EgyptTour = new Tour("Pyramides", 400);
Tour ParisTour = new Tour("Eiffel Tower",320);

PlaneTicket TicketToUSA = new PlaneTicket("USA", 800);
PlaneTicket TicketToCanada = new PlaneTicket("Canada",1100);

Manager Manager = new Manager(hotel);

Manager.AddTicket(TicketToUSA);
Manager.AddTicket(TicketToCanada);

Manager.AddTour(ParisTour);
Manager.AddTour(EgyptTour);

#endregion


while (true)
{

    int MainChoice;
    Console.WriteLine("1.Hotel\n2.Tour\n3.Travel\n:");
    bool ISchoice = int.TryParse(Console.ReadLine(), out MainChoice);

    switch (MainChoice)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("1.Show all reserved rooms \n2.Book a hotel room\n3.Free a hotel room");
            int HotelChoice;
            bool ISchoiceHotel = int.TryParse(Console.ReadLine(), out HotelChoice);

            switch (HotelChoice)
            {
                case 1:
                    Manager.ShowReservedRooms();
                    Thread.Sleep(4000);
                    break;

                case 2:
                    Manager.ShowReservedRooms();
                    Console.WriteLine("Enter you'r name : ");
                    string name = Console.ReadLine();
                    int room;
                    Console.WriteLine("Enter number of hotel room : ");
                    bool ISroom = int.TryParse(Console.ReadLine(), out room);

                    Manager.RegisterPerson(name, room);
                    break;

                case 3:
                    int Tmproom;
                    Console.WriteLine("Enter number of hotel room : ");
                    bool TmpISroom = int.TryParse(Console.ReadLine(), out Tmproom);

                    Manager.UnregisterPerson(Tmproom);

                    break;
            }
            Console.Clear();
            break;

        case 2:
            Console.Clear();
            Console.WriteLine("1.Show all tours \n2.Buy tour\n");
            int TourChoice;
            bool ISTourChoise = int.TryParse(Console.ReadLine(),out TourChoice);

            switch (TourChoice)
            {
                case 1:
                    Console.Clear();
                    Manager.ShowAllTours();
                    Thread.Sleep(4000);
                    break;

                case 2:
                    Console.Clear();
                    Manager.ShowAllTours();

                    Console.WriteLine("Enter Place : ");
                    string place = Console.ReadLine();
                    int price;

                    Console.WriteLine("Enter price : ");
                    bool ISPrice = int.TryParse(Console.ReadLine(), out price);

                    Manager.BuyTour(place,price);

                    break;
             
            }

            Console.Clear();
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("1.Show all tours \n2.Buy tour\n");
            int TicketChoice;
            bool ISTicketChoise = int.TryParse(Console.ReadLine(), out TicketChoice);

            switch (TicketChoice)
            {
                case 1:
                    Console.Clear();
                    Manager.ShowAllTickets();
                    Thread.Sleep(4000);
                    break;

                case 2:
                    Console.Clear();
                    Manager.ShowAllTickets();

                    Console.WriteLine("Enter Country : ");
                    string Country = Console.ReadLine();
                    int price;

                    Console.WriteLine("Enter price : ");
                    bool ISPrice = int.TryParse(Console.ReadLine(), out price);

                    Manager.BuyTicket(Country, price);

                    break;

            }

            Console.Clear();
            break;


    }

}

