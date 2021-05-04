namespace BuilderTask
{
    class CarBuilder
    {
        public Car Car { get; set; }

        public CarBuilder(string model)
        {
            Car = new Car();
            Car.Model = model;
        }
        public CarBuilder EquipBrand(Brand brand)
        {
            Car.Brand = brand;
            return this;
        }
        public CarBuilder EquipBody(Body body)
        {
            Car.Body = body;
            return this;
        }
        public CarBuilder EquipSalon(Salon salon)
        {
            Car.Salon = salon;
            return this;
        }
        public CarBuilder EquipMotor(Motor motor)
        {
            Car.Motor = motor;
            return this;
        }

        public Car Build()
        {
            return Car;
        }
    }
}
