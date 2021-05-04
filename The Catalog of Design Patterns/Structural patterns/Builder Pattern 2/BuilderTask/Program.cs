namespace BuilderTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new CarBuilder("Maybach")
                .EquipBody(new Sedan())
                .EquipBrand(new MercedesBenz())
                .EquipSalon(new Full())
                .EquipMotor(new BusinessClass())
                .Build();

            car.Info();
        }
    }
}
