using System;
using System.Collections.Generic;
using Bogus;



class Program
{
    static void Main()
    {
        ParkingOnly garage1 = new ParkingOnly("Car Park 1", 2.00, 0.50);
        ParkingOnly garage2 = new ParkingOnly("Car Park 2", 2.00, 0.60);
        ParkingOnly garage3 = new ParkingOnly("Car Park 3", 2.00, 0.75);

        var faker = new Faker();
        List<int> parkedHoursGarage1 = ParkedHours(faker, 10);
        List<int> parkedHoursGarage2 = ParkedHours(faker, 6);
        List<int> parkedHoursGarage3 = ParkedHours(faker, 8);

        CalculateAndDisplayCharges(garage1, parkedHoursGarage1);
        CalculateAndDisplayCharges(garage2, parkedHoursGarage2);
        CalculateAndDisplayCharges(garage3, parkedHoursGarage3);
    }

    static List<int> ParkedHours(Faker faker, int numCars)
    {
        List<int> parkedHours = new List<int>();

    }
        for (int i = 0; i < numCars; i++)
        {
            int hours = faker.Random.Int(1, 8);
            parkedHours.Add(hours);
        }

        return parkedHours;

    static void CalculateAndDisplayCharges(ParkingOnly garage, List<int> parkedHours)
    {
        double totalReceipts = 0;

        for (int i = 0; i < parkedHours.Count; i++)
        {
            double charge = garage.CalculateCharge(parkedHours[i]);
            totalReceipts += charge;

            Console.WriteLine($"Customer {i + 1} in {garage.Name}: Charge = €{charge:F2}");
        }

        Console.WriteLine($"Total receipts for {garage.Name}: €{totalReceipts:F2}");
    }
}


