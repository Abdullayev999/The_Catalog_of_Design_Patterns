using System;

namespace Facade_Pattern
{
    enum HotelType
    {
        ThreeStars, FourStars, FiveStars
    }

    class HotelBooking
    {
        public int BookHotel(HotelType type, int days)
        {
            switch (type)
            {
                case HotelType.ThreeStars:
                    return 100 * days;
                case HotelType.FourStars:
                    return 200 * days;
                case HotelType.FiveStars:
                    return 300 * days;
                default:
                    return 0;
            }
        }
    }

    enum TripType
    {
        Bus, Train, Flight
    }

    class TripBooking
    {
        static private Random rand = new Random();

        public double BookTrip(TripType type, string from, string to)
        {
            int distance = rand.Next(100, 5000);
            //Console.WriteLine($"Distance: {distance}km");

            switch (type)
            {
                case TripType.Bus:
                    return distance * 0.5;
                case TripType.Train:
                    return distance * 1.5;
                case TripType.Flight:
                    return distance * 2.5;
                default:
                    return 0;
            }
        }
    }

    enum GuideType
    {
        None, Audio, Person
    }

    class GuideBooking
    {
        public int BookGuide(GuideType type, int days)
        {
            switch (type)
            {
                case GuideType.None:
                    return 0;
                case GuideType.Audio:
                    return 25 * days;
                case GuideType.Person:
                    return 50 * days;
                default:
                    return 0;
            }
        }
    }

    //Facade
    class TravelAgency
    {
        public double BuildTrip(string fromCity, string toCity, int days, HotelType hotelType, TripType tripType, GuideType guideType)
        {
            double price = 0;

            var hotelBooking = new HotelBooking();
            price += hotelBooking.BookHotel(hotelType, days);

            var tripBooking = new TripBooking();
            price += tripBooking.BookTrip(tripType, fromCity, toCity);

            var guideBooking = new GuideBooking();
            price += guideBooking.BookGuide(guideType, days);

            //Console.WriteLine("Tour info:");
            //Console.WriteLine($"From: {fromCity}");
            //Console.WriteLine($"To: {toCity}");
            //Console.WriteLine($"Hotel type: {hotelType}");
            //Console.WriteLine($"Trip type: {tripType}");
            //Console.WriteLine($"Guide type: {guideType}");
            //Console.WriteLine($"Total price: {price}");

            return price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var travelAgency = new TravelAgency();
            var price1 = travelAgency.BuildTrip("Baku", "Rome", 5, HotelType.FourStars, TripType.Flight, GuideType.Audio);
            Console.WriteLine($"Baku - Rome  : {price1} $");

            Console.WriteLine();

            var price2 = travelAgency.BuildTrip("Baku", "Sumgait", 3, HotelType.FiveStars, TripType.Bus, GuideType.None);
            Console.WriteLine($"Baku - Genja : {price2} $");
        }
    }
} 
