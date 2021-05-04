using System;

namespace BuilderTask
{
    class Car
    {
        public string Model { get; set; }
        public Motor Motor { get; set; }
        public Brand Brand { get; set; }
        public Body Body { get; set; }
        public Salon Salon { get; set; }


        public void Info()
        {

            Console.WriteLine("Brand : " + Brand.brand +
                "\nModel : " + Model+
                "\nMotor :" +
                "\n - Horsepower : " + Motor.Horsepower +
                "\n - Cylinder   : " + Motor.Cylinder +
                "\nBody  : " + Body.body +
                "\nSalon : " + Salon.salon);
        }
    }
}
