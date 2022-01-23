using Lesson4_DLL;
using System;
using System.Collections;


namespace Lesson4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Building buildingDescription = new Building();

            //buildingDescription.Height = 100;
            //buildingDescription.Floors = 5;
            //buildingDescription.Apartments = 30;
            //buildingDescription.Entrances = 2;

            //Console.WriteLine("Height of each floor: " + Math.Round(buildingDescription.GetFloorHeight(),2,MidpointRounding.AwayFromZero) + " M");
            //Console.WriteLine("Number of apartments in each floor: " + buildingDescription.GetNumApartmentsInEachFloor());
            //Console.WriteLine("Number of apartments in each entrance: " + buildingDescription.GetNumApartmentsInEachEntrances());
            //// Details of building
            //Console.WriteLine(buildingDescription);

            Building build1 = Building.Creator.Create();

            Building build2 = Building.Creator.Create();

            Building build3 = Building.Creator.Create(100, 5, 30, 2);


            Hashtable catalog = new Hashtable();

            catalog.Add(build1.BuildingId, build1);
            catalog.Add(build2.BuildingId, build2);
            catalog.Add(build3.BuildingId, build3);

            catalog.Remove(4);
        }
    }
}
