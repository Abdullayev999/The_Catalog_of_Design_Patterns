using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new Map();
            var start = new Location { Lat = 1, Lon = 2 };
            var stop = new Location { Lat = 2, Lon = 3 };

            map.SetRouteBuilder(new BusRouteBuilder());
            map.BuildRoute(start, stop);

            map.SetRouteBuilder(new CarRouteBuilder());
            map.BuildRoute(start, stop);

            map.SetRouteBuilder(new WalkRouteBuilder());
            map.BuildRoute(start, stop);
        }
    }

    class Location
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    enum Trasport
    {
        Car, Bus, Walk
    }

    class Map
    {
        private IRouteBuilder routeBuilder;

        public void SetRouteBuilder(IRouteBuilder routeBuilder)
        {
            this.routeBuilder = routeBuilder;
        }

        public void BuildRoute(Location start, Location stop)
        {
            routeBuilder.BuildRoute(start, stop);
        }


        //public void BuildRoute(Location start, Location stop, Trasport trasport)
        //{
        //    if (trasport == Trasport.Car)
        //    {
        //        Console.WriteLine("15min");
        //    }
        //    else if (trasport == Trasport.Bus)
        //    {
        //        Console.WriteLine("30min");
        //    }
        //    else if (trasport == Trasport.Walk)
        //    {
        //        Console.WriteLine("45min");
        //    }
        //}
    }

    interface IRouteBuilder
    {
        void BuildRoute(Location start, Location stop);
    }

    class CarRouteBuilder : IRouteBuilder
    {
        public void BuildRoute(Location start, Location stop)
        {
            // Some algorithm
            Console.WriteLine("15min");
        }
    }

    class BusRouteBuilder : IRouteBuilder
    {
        public void BuildRoute(Location start, Location stop)
        {
            // Some algorithm
            Console.WriteLine("30min");
        }
    }

    class WalkRouteBuilder : IRouteBuilder
    {
        public void BuildRoute(Location start, Location stop)
        {
            // Some algorithm
            Console.WriteLine("45min");
        }
    }
}
