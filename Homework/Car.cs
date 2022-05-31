using System;
namespace Homework
{
	public class Car: Vehicle
	{
		public Car()
		{
		}
		public double FuelCapacity;
		public double CurrentFuel;
		public void AddFuel()
        {
            Console.WriteLine("Ne qeder benzin daxil etmek isteyirsen?");
			double wantedFuel = int.Parse(Console.ReadLine());
            if ((CurrentFuel + wantedFuel) <= FuelCapacity)
            {
				CurrentFuel = CurrentFuel + wantedFuel;

            }
            else
            {
                Console.WriteLine("Gas tank limitine catmisan");
            }
        }
	}
}

