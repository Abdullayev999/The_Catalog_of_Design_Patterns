using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class CarCalculetor
    {
        public float CalculetPrice(string brand, string model,int year, EngineType engineType, GearType gearType)
        {
            float price = 0;
            Car car = new Car { Brand = brand, Model = model, Year = year };
            if (brand.Equals("BMW")) price += 5000;
            else if (brand.Equals("Toyota")) price += 2000;
            price += (year - 2000) * 500;
            switch (engineType)
            {
                case EngineType.R4:
                    car.Engine = new Engine { CountPiston = 4, HorsePower = 120 };
                    price += 2000;
                    break;
                case EngineType.V6:
                    car.Engine = new Engine { CountPiston = 6, HorsePower = 180 };
                    price += 3200;
                    break;
                case EngineType.V8:
                    car.Engine = new Engine { CountPiston = 8, HorsePower = 260 };
                    price += 4500;
                    break;
            }
            switch (gearType)
            {
                case GearType.Mechanic:
                    car.GearBox = new GearBox { CountGear = 6 };
                    price += 1000;
                    break;
                case GearType.Automatic:
                    car.GearBox = new GearBox { CountGear = 8 };
                    price += 2000;
                    break;
            }
            return price;
        }
    }
}
