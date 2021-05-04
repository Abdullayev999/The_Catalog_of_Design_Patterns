using System;
using System.Collections.Generic;
using System.IO;

namespace Visitor_Pattern
{
    interface IExport
    {
        void Export(MapObjectExporter exporter);
    }

    abstract class MapObject : IExport
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }

        public abstract void Export(MapObjectExporter exporter);

        public override string ToString()
        {
            var str = $"Name: {Name}\n";
            str += $"Coordinates: {Latitude}, {Longitude}";
            return str;
        }
    }

    class Hotel : MapObject
    {
        public int Stars { get; set; }

        public override string ToString()
        {
            var str = "Hotel\n";
            str += base.ToString() + '\n';
            str += $"Stars: {Stars}";
            return str;
        }

        public override void Export(MapObjectExporter exporter)
        {
            exporter.ExportHotel(this);
        }
    }

    enum Cuisine { Italian, Georgian, Russian }

    class Restaurant : MapObject
    {
        public Cuisine Cuisine { get; set; }

        public override string ToString()
        {
            var str = "Restaurant\n";
            str += base.ToString() + '\n';
            str += $"Cuisine: {Cuisine}";
            return str;
        }

        public override void Export(MapObjectExporter exporter)
        {
            exporter.ExportRestaurant(this);
        }
    }

    class BusStation : MapObject
    {
        public List<int> BusNumbers { get; set; } = new List<int>();

        public override string ToString()
        {
            var str = "Bus station\n";
            str += base.ToString() + '\n';
            str += $"Bus numbers: ";
            foreach (var item in BusNumbers)
            {
                str += $"{item} ";
            }
            return str;
        }

        public override void Export(MapObjectExporter exporter)
        {
            exporter.ExportBusStation(this);
        }
    }

    class MapObjectExporter
    {
        public void ExportHotel(Hotel obj)
        {
            if (!Directory.Exists("hotels"))
                Directory.CreateDirectory("hotels");

            using (var writer = new StreamWriter($"hotels\\{obj.Name}.txt"))
            {
                writer.WriteLine(obj.ToString());
            }
        }

        public void ExportRestaurant(Restaurant obj)
        {
            if (!Directory.Exists("restaurants"))
                Directory.CreateDirectory("restaurants");

            using (var writer = new StreamWriter($"restaurants\\{obj.Name}.txt"))
            {
                writer.WriteLine(obj.ToString());
            }
        }

        public void ExportBusStation(BusStation obj)
        {
            if (!Directory.Exists("busstations"))
                Directory.CreateDirectory("busstations");

            using (var writer = new StreamWriter($"busstations\\{obj.Name}.txt"))
            {
                writer.WriteLine(obj.ToString());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<MapObject>
            {
                new Hotel { Name = "Hilton", Latitude = 34.4, Longitude = 27.8, Stars = 5 },
                new Restaurant { Name = "Italia", Latitude = 36.7, Longitude = 30.1, Cuisine = Cuisine.Italian },
                new BusStation { Name = "28 May", Latitude = 15.1, Longitude = 27.5, BusNumbers = { 175, 88, 5, 125 } }
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            var exporter = new MapObjectExporter();
            foreach (var item in list)
            {
                item.Export(exporter);
            }

            //var exporter = new MapObjectExporter();
            //foreach (var item in list)
            //{
            //    if (item is Hotel)
            //        exporter.ExportHotel(item as Hotel);

            //    if (item is Restaurant)
            //        exporter.ExportRestaurant(item as Restaurant);

            //    if (item is BusStation)
            //        exporter.ExportBusStation(item as BusStation);
            //}
        }
    }
}
