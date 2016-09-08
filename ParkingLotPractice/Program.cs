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
                Console.WriteLine("Press \n 1: for Motorcycle \n 2: for Car \n 3: for Van \n 4: for Bus \n 5: for Truck\n 6: To enter the Reports Menu\n Press 0 to exit.\n");
                if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out UserType) == true)
                {
                    if (UserType != 0)
                    {
                        switch (UserType)
                        {
                            case 1:
                                y = new Motorcycle();
                                Console.WriteLine("\nYou want to park a Motorcycle, the cost would be " + y.Cost);
                                break;
                            case 2:
                                y = new Car();
                                Console.WriteLine("\nYou want to park a Car, the cost would be " + y.Cost);
                                break;
                            case 3:
                                y = new Van();
                                Console.WriteLine("\nYou want to park a Van, the cost would be " + y.Cost);
                                break;
                            case 4:
                                y = new Bus();
                                Console.WriteLine("\nYou want to park a Bus, the cost would be " + y.Cost);
                                break;
                            case 5:
                                y = new Truck();
                                Console.WriteLine("\nYou want to park a Truck, the would be " + y.Cost);
                                break;
                            case 6:
                                Console.WriteLine("\n");
                                PLot.ReportMenu();
                                break;
                            default:
                                Console.WriteLine("\n Input error");
                                break;
                        }
                    }

                    if (UserType != 6)
                    {
                        if (y != null)
                        {
                            int slot = PLot.GetParkingSlot(UserType);
                            if (slot != -1)
                            {
                                Console.WriteLine("\nPlease type in your license plate to proceed, minimum of 1 character and a maximum of 8 characters. ");
                                License = Console.ReadLine().ToString();
                                while ((License.Length > 8) || License.Length < 1)
                                {
                                    Console.WriteLine("    Invalid License Plate. Must be longer than 1 character and shorter than 8.\nType in license plate:");
                                    License = Console.ReadLine().ToString();
                                }
                                if (PLot.LicensePlatesExists(License) != true)
                                {
                                    y.LicensePlate = License;
                                    PLot.InsertVehicle(y, slot);
                                    Console.WriteLine("\nYour vehicle has been parked\n");
                                }
                                else
                                {
                                    Console.WriteLine("\n   License plate already exixts.\n");
                                }

                            }
                            else
                            {
                                Console.WriteLine("    But we have no available spots for this type of vehicle, please select a different type\n");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nInput error");
                    UserType = -1;
                }
                 
            }
        }
    }
}


