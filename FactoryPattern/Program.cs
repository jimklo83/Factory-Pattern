namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels are on the vehicle you drive most?");
            var userVehicle = Console.ReadLine();
            var vehicle = VehicleFactory.GetVehicle(userVehicle);

            vehicle.Drive();
        }
    }
}
