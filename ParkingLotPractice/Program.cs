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
                Console.WriteLine("Press \n 1: for Motorcycle \n 2: for Car \n 3: for Van \n 4: for Bus \n 5: for Truck\nPress anything other key to exit.");

                int.TryParse(Console.ReadKey().KeyChar.ToString(), out UserType);

                if (UserType != 0)
                {
                    switch (UserType)
                    {
                        case 1:
                            y = new Motorcycle();
                            Console.WriteLine("\nYou want to park a Motorcycle, the cost is " + y.Cost);
                            break;
                        case 2:
                            y = new Car();
                            Console.WriteLine("\nYou want to park a Car, the cost is " + y.Cost);
                            break;
                        case 3:
                            y = new Van();
                            Console.WriteLine("\nYou want to park a Van, the cost is " + y.Cost);
                            break;
                        case 4:
                            y = new Bus();
                            Console.WriteLine("\nYou want to park a Bus, the cost is " + y.Cost);
                            break;
                        case 5:
                            y = new Truck();
                            Console.WriteLine("\nYou want to park a Motorcycle, the cost is " + y.Cost);
                            break;
                        default:
                            Console.WriteLine("\n Input error");
                            break;
                    }
                }

                if (y!=null)
                {
                    int slot = PLot.GetParkingSlot(UserType);
                    Console.WriteLine("\nWe have spots available. Please type in your license plate, can't be longer than 8 characters");

                    License = Console.ReadLine().ToString();
                    while (License.Length > 8)
                    {
                        Console.WriteLine("License plate too long, must be shorter than 8 characters\nType in license plate:");
                        License = Console.ReadLine().ToString();
                    }
                    if (PLot.LicensePlatesExists(License) != true)
                    {
                        y.LicensePlate = License;
                        PLot.InsertVehicle(y, UserType);
                        Console.WriteLine("Your vehicle has been parked");
                    }

                       
                       
                }
                else
                {
                    Console.WriteLine("No available spots for this type of vehicle, please select a different type");
                }
            }
        }
    }
}

