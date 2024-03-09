using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{

    public class ParkingRecord
    {
        // Attributes
        public string PlateNumber { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Driver { get; set; }
        public string Phone { get; set; }
        public string ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        public String DepartureDate { get; set; }
        public String DepartureTime { get; set; }
        public double Hours { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }

        // Constructor
        public ParkingRecord()
        {
            // Default constructor
        }

        // Additional constructor with parameters
        public ParkingRecord(string plateNumber, string type, string model,
                             string driver, string phone, string arrivalDate, string arrivalTime, string departureDate, string departureTime,
                             double hours, double amount, string status)
        {
            PlateNumber = plateNumber;
            Type = type;
            Model = model;
             Driver = driver;
            Phone = phone;
            ArrivalDate = arrivalDate;
            ArrivalTime = arrivalTime;
            Hours = hours;
            Amount = amount;
            Status = status;
            DepartureDate = departureDate;
            DepartureTime = departureTime;
        }

        // Additional methods can be added as needed
    }

    public class ParkingRecordsManager
    {
        private static ParkingRecordsManager instance;
        public static ParkingRecordsManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ParkingRecordsManager();
                return instance;
            }
        }

         private List<ParkingRecord> parkingRecords;


        // Constructor
        public ParkingRecordsManager()
        {
            parkingRecords = new List<ParkingRecord>();
            AddDefaultValues();
        }

        private void AddDefaultValues()
        {
            // Create some default parking records and add them to the list
            parkingRecords.Add(new ParkingRecord("ABC123", "Car", "Toyota", "John Doe", "123456789", ""+DateTime.Now,""+ TimeSpan.FromHours(10),"" +DateTime.Now, ""+TimeSpan.FromHours(10), 10.5, 50.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("DEF456", "Truck", "Ford", "Jane Doe", "987654321",""+ DateTime.Now.AddDays(-1), ""+TimeSpan.FromHours(5),""+ DateTime.Now,""+ TimeSpan.FromHours(10), 5.5, 30.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("ABC123", "Car", "Toyota", "John Doe", "123456789", "" + DateTime.Now, "" + TimeSpan.FromHours(10), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 10.5, 50.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("DEF456", "Truck", "Ford", "Jane Doe", "987654321", "" + DateTime.Now.AddDays(-1), "" + TimeSpan.FromHours(5), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 5.5, 30.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("ABC123", "Car", "Toyota", "John Doe", "123456789", "" + DateTime.Now, "" + TimeSpan.FromHours(10), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 10.5, 50.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("DEF456", "Truck", "Ford", "Jane Doe", "987654321", "" + DateTime.Now.AddDays(-1), "" + TimeSpan.FromHours(5), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 5.5, 30.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("ABC123", "Car", "Toyota", "John Doe", "123456789", "" + DateTime.Now, "" + TimeSpan.FromHours(10), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 10.5, 50.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("DEF456", "Truck", "Ford", "Jane Doe", "987654321", "" + DateTime.Now.AddDays(-1), "" + TimeSpan.FromHours(5), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 5.5, 30.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("ABC123", "Car", "Toyota", "John Doe", "123456789", "" + DateTime.Now, "" + TimeSpan.FromHours(10), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 10.5, 50.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("DEF456", "Truck", "Ford", "Jane Doe", "987654321", "" + DateTime.Now.AddDays(-1), "" + TimeSpan.FromHours(5), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 5.5, 30.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("ABC123", "Car", "Toyota", "John Doe", "123456789", "" + DateTime.Now, "" + TimeSpan.FromHours(10), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 10.5, 50.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("DEF456", "Truck", "Ford", "Jane Doe", "987654321", "" + DateTime.Now.AddDays(-1), "" + TimeSpan.FromHours(5), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 5.5, 30.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("ABC123", "Car", "Toyota", "John Doe", "123456789", "" + DateTime.Now, "" + TimeSpan.FromHours(10), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 10.5, 50.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("DEF456", "Truck", "Ford", "Jane Doe", "987654321", "" + DateTime.Now.AddDays(-1), "" + TimeSpan.FromHours(5), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 5.5, 30.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("ABC123", "Car", "Toyota", "John Doe", "123456789", "" + DateTime.Now, "" + TimeSpan.FromHours(10), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 10.5, 50.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("DEF456", "Truck", "Ford", "Jane Doe", "987654321", "" + DateTime.Now.AddDays(-1), "" + TimeSpan.FromHours(5), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 5.5, 30.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("ABC123", "Car", "Toyota", "John Doe", "123456789", "" + DateTime.Now, "" + TimeSpan.FromHours(10), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 10.5, 50.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("DEF456", "Truck", "Ford", "Jane Doe", "987654321", "" + DateTime.Now.AddDays(-1), "" + TimeSpan.FromHours(5), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 5.5, 30.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("ABC123", "Car", "Toyota", "John Doe", "123456789", "" + DateTime.Now, "" + TimeSpan.FromHours(10), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 10.5, 50.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("DEF456", "Truck", "Ford", "Jane Doe", "987654321", "" + DateTime.Now.AddDays(-1), "" + TimeSpan.FromHours(5), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 5.5, 30.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("ABC123", "Car", "Toyota", "John Doe", "123456789", "" + DateTime.Now, "" + TimeSpan.FromHours(10), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 10.5, 50.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("DEF456", "Truck", "Ford", "Jane Doe", "987654321", "" + DateTime.Now.AddDays(-1), "" + TimeSpan.FromHours(5), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 5.5, 30.0, "PARKED"));
            parkingRecords.Add(new ParkingRecord("ABC123", "Car", "Toyota", "John Doe", "123456789", "" + DateTime.Now, "" + TimeSpan.FromHours(10), "" + DateTime.Now, "" + TimeSpan.FromHours(10), 10.5, 50.0, "PARKED"));
             // Add more default records as needed
        }

        // Method to add a parking record
        public void AddParkingRecord(ParkingRecord parkingRecord)
        {

         



            parkingRecords.Add(parkingRecord);
        }
        

        // Method to remove a parking record
        public void RemoveParkingRecord(ParkingRecord parkingRecord)
        {
            parkingRecords.Remove(parkingRecord);
        }

        // Method to get all parking records
        public List<ParkingRecord> GetAllParkingRecords()
        {
          return parkingRecords; 
        }

        // Additional methods can be added as needed
    }



    public class Vehicle {

        public string vehicleType { get; set; }   
        public double flagDown { get; set; }
        public double additionalAmtPerHour { get; set; }

       public Vehicle(string vType,double flagdown,double addAmtPerHOur)
        {
            vehicleType = vType;
            flagDown = flagdown;
            additionalAmtPerHour = addAmtPerHOur;
        }
    }

    public class VehicleManger {

        private List<Vehicle> vehiclePaymentMatrix;
        private static VehicleManger instance;
        public static VehicleManger Instance
        {
            get
            {
                if (instance == null)
                    instance = new VehicleManger();
                return instance;
            }
        }
        public VehicleManger()
        {
            vehiclePaymentMatrix = new List<Vehicle>();
            AddDefaultValues();
        }

       


        private void AddDefaultValues()
        {

            vehiclePaymentMatrix.Add(new Vehicle("MOTORBIKE", 20.00,5.00));
            vehiclePaymentMatrix.Add(new Vehicle("SUV",40.00,20.00));
            vehiclePaymentMatrix.Add(new Vehicle("VAN", 40.00, 20.00));
            vehiclePaymentMatrix.Add(new Vehicle("SEDAN", 30.00, 15.00));
        }

        public void addVPM(Vehicle vehicle)
        {
            vehiclePaymentMatrix.Add(vehicle);
        }


        public List<Vehicle> GetVPM()
        {
            return vehiclePaymentMatrix;
        }

    }

    public class VehicleBrand
    {

        public string vehicleType { get; set; }
        public string vBrand { get; set; }
    

        public VehicleBrand(string vType, string vehiclerand)
        {
            vehicleType = vType;
            vBrand = vehiclerand;        
        }
    }


    public class VehicleBrandMAnger
    {

        private List<VehicleBrand> vehicleBrand;
        private static VehicleBrandMAnger instance;
        public static VehicleBrandMAnger Instance
        {
            get
            {
                if (instance == null)
                    instance = new VehicleBrandMAnger();
                return instance;
            }
        }
        public VehicleBrandMAnger()
        {
            vehicleBrand = new List<VehicleBrand>();
            AddDefaultValues();
        }




        private void AddDefaultValues()
        {

            vehicleBrand.Add(new VehicleBrand("MOTORBIKE", "Honda"));
            vehicleBrand.Add(new VehicleBrand("MOTORBIKE", "Honda"));
            vehicleBrand.Add(new VehicleBrand("MOTORBIKE", "Yamaha"));
            vehicleBrand.Add(new VehicleBrand("MOTORBIKE", "Suzuki"));
            vehicleBrand.Add(new VehicleBrand("MOTORBIKE", "Kawasaki"));

            vehicleBrand.Add(new VehicleBrand("SUV", "Toyota"));
            vehicleBrand.Add(new VehicleBrand("SUV", "Honda"));
            vehicleBrand.Add(new VehicleBrand("SUV", "Ford"));
            vehicleBrand.Add(new VehicleBrand("SUV", "Chevrolet"));

            vehicleBrand.Add(new VehicleBrand("VAN", "Ford"));
            vehicleBrand.Add(new VehicleBrand("VAN", "Chevrolet"));
            vehicleBrand.Add(new VehicleBrand("VAN", "Mercedes-Benz"));
            vehicleBrand.Add(new VehicleBrand("VAN", "Volkswagen"));

            vehicleBrand.Add(new VehicleBrand("SEDAN", "BMW"));
            vehicleBrand.Add(new VehicleBrand("SEDAN", "Mercedes-Benz"));
            vehicleBrand.Add(new VehicleBrand("SEDAN", "Audi"));
            vehicleBrand.Add(new VehicleBrand("SEDAN", "Lexus"));
        }

        public void addVB(VehicleBrand vbrand)
        {
            vehicleBrand.Add(vbrand);
        }


        public List<VehicleBrand> GetVB()
        {
            return vehicleBrand;
        }

    }











    internal class ParkIinMain
    {
    }
}
