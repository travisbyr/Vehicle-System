using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace VehicleSystem
{
    class Business
    {
        public const String fileName = "..\\..\\..\\VehicleSystem\\Save.dat";

        private static List<Vehicle> _vehicleList = new List<Vehicle>();

        public static List<Vehicle> VehicleList { get => _vehicleList;}

        public static void Save()
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create)) // Saves the user data in the file location provided.
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, VehicleList); 
            }
        }   

        public static void Retrieve()
        {
            if (File.Exists(fileName)) // If the file exists, open the doccument and retrieve the user data.
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    _vehicleList = (List<Vehicle>)formatter.Deserialize(fileStream);
                }
            }
        }

        public static void RemoveVehicle(string rego)
        {
            VehicleList.RemoveAll((x) => x.Rego == rego); // Remove a vehicle from the list, using the given registration number
        }

        public static void AddVehicle(Vehicle obj)
        {
            _vehicleList.Add(obj); // Add vehicle object created to the vehicle list.
        } 
    }
}
