using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserType=-1;
            string License;
            Vehicle y=null;
            ParkingLot PLot = new ParkingLot();
            

            while (UserType!=0)
            {
                Console.WriteLine("Press \n 1: for Motorcycle \n 2: for Car \n 3: for Van \n 4: for Bus \n 5: for Truck\nPress 0 to exit.");

                int.TryParse(Console.ReadKey().KeyChar.ToString(), out UserType);
                           
                switch (UserType)
                {
                    case 1:
                        Console.WriteLine("\nYou've chosen a Motorcycle");
                        y = new Motorcycle();
                        break;
                    case 2:
                        Console.WriteLine("\nYou've chosen a Car");

                        break;
                    case 3:
                        Console.WriteLine("\nYou've chosen a Van");
                        break;
                    case 4:
                        Console.WriteLine("\nYou've chosen a Bus");
                        break;
                    case 5:
                        Console.WriteLine("\nYou've chosen a Truck");
                        break;
                    default:
                        Console.WriteLine("\n Input error");
                        break;
                }

                Console.WriteLine("\nType in license plate, can't be longer than 8 characters");

                License = Console.ReadLine().ToString();
                while (License.Length > 8)
                {
                    Console.WriteLine("License plate too long, must be shorter than 8 characters\nType in license plate:");
                    License = Console.ReadLine().ToString();
                }
                y.LicensePlate = License;
                if (y!=null)
                { 
                    if (PLot.InsertVehicle(y, UserType)==true)
                    {
                        Console.WriteLine("Your vehicle has been parked"); 
                    }
                    else
                    {
                        Console.WriteLine("No available spots for this type of vehicle, please select a different type");
                    }
                    
                }
                

            }
            
                     


        }
    }
}
