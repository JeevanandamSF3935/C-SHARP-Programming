
namespace Exercise2
{
    public class ShiftDezire:car, IBrand
    {
        private static int s_id = 1000;

        public string MakingID { get; set; }

        public int EngineNumber { get; set; }

        public int ChasisNumber { get; set; }

        public string BrandName { get; set; }

        public string ModelName { get; set; }

        public ShiftDezire(int engine, int chasis, string brand, string model, Fuel type, int seats, string color, int capacity, int km):base(type, seats, color, capacity, km)
        {
            s_id++;
            MakingID = "SID" + s_id;
            EngineNumber = engine;
            ChasisNumber = chasis;
            BrandName = brand;
            ModelName = model;
             
        }

        public void ShowDetails()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("< ------- SHIFT DEZIRE -------->");
            System.Console.WriteLine();

            System.Console.WriteLine($"Making ID: {MakingID}");
            System.Console.WriteLine($"EngineNumber: {EngineNumber}");
            System.Console.WriteLine($"ChasisNumber: {ChasisNumber}");
            System.Console.WriteLine($"BrandName: {BrandName}");
            System.Console.WriteLine($"ModelName: {ModelName}");
            System.Console.WriteLine($"Fuel type: {FuelType}");
            System.Console.WriteLine($"Seats: {NoOfSeats}");
            System.Console.WriteLine($"Color: {Color}");
            System.Console.WriteLine($"capacity: {TankCapacity}");
            System.Console.WriteLine($"Km Driven: {KmDriven}");

        }

    }
}