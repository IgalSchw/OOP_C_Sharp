using System;

namespace Lesson4_DLL
{

    internal sealed class Building
    {
        private static int uniqueBuildingId = 0;
        private int buildingId;
        private double height;
        private int floors;
        private int apartments;
        private int entrances;

        private Building(double height, int floors, int apartments, int entrances) : this() // any way call default constructor
        {

        }

        private Building()  // build from static class creator
        {
            buildingId = GenerateUniqueBuildingId();
        }

        private int GenerateUniqueBuildingId()
        {
            uniqueBuildingId++;

            return uniqueBuildingId;
        }

        public int GetNumApartmentsInEachEntrances()
        {
            return apartments / entrances;
        }

        public int GetNumApartmentsInEachFloor()
        {
            return apartments / floors;
        }

        public double GetFloorHeight()
        {
            return height / floors;
        }


        public int UniqeBuildingId
        {
            get => uniqueBuildingId;
        }

        public int BuildingId
        {
            get => buildingId;
        }

        public int Entrances
        {
            get => entrances;

            set
            {
                if (value < 0)
                    throw new BuildingExceptions("Wrong parameter of entrances");
                else
                    entrances = value;
            }
        }

        public int Apartments
        {
            get => apartments;

            set
            {
                if (value < 0)
                    throw new BuildingExceptions("Wrong parameter of apartments");
                else
                    apartments = value;
            }
        }

        public double Height
        {

            get => height;

            set
            {
                if (value < 0)
                    throw new BuildingExceptions("Wrong parameter of height");
                else
                    height = value;
            }
        }

        public int Floors
        {

            get => floors;

            set
            {
                if (value < 0)
                    throw new BuildingExceptions("Wrong parameter of floors");
                else
                    floors = value;
            }
        }

        public override string ToString()
        {
            return "Building description: Bulding ID: " + UniqeBuildingId + ",Floors: " + Floors + ", Height: " + Height + ", Apartments: " + Apartments + ", Entrance: " + Entrances;
        }

        public static class Creator
        {
            public static Building Create(double height, int floors, int apartments, int entrances)
            {
                return new Building()
                {
                    Height = height,
                    Floors = floors,
                    Apartments = apartments,
                    Entrances = entrances
                };
            }

            public static Building Create()
            {
                return new Building();
            }
        }
    }

}
