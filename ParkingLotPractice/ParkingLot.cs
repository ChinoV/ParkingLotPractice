using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotPractice
{
    public class ParkingLot
    {

        #region Properties

        
        Vehicle[] ParkingLotArray { get; set; }

        #endregion


        #region Methods

        /// <summary>
        /// Constructor de ParkingLot
        /// </summary>
        public ParkingLot()
        {
            this.ParkingLotArray = new Vehicle[28];
        }

        /// <summary>
        /// Obtains empty spot on array based on range -begin-end- positions
        /// </summary>
        public int GetEmptySlot(int begin, int end)
        {
            for (int i = begin; i <= end; i++)
            {
                if (ParkingLotArray[i] == null)
                {
                    return i;
                }

            }

            return -1;
        }

        /// <summary>
        /// Gives the range to GetEmptySlot method and returns the slot as an int
        /// </summary>
        public int GetParkingSlot(int UserType)
        {
            int slot = -1;
            switch (UserType)
            {
                case 1:
                    slot = GetEmptySlot(0, 3);
                    break;
                case 2:
                    slot = GetEmptySlot(4, 8);
                    break;
                case 3:
                    slot = GetEmptySlot(9, 14);
                    break;
                case 4:
                    slot = GetEmptySlot(15, 20);
                    break;
                case 5:
                    slot = GetEmptySlot(21, 28);
                    break;
            }
            return slot;
        }

        /// <summary>
        /// returns True if it successfully inserts a Vehicle into a ParkingLot array, else returns False
        /// </summary>
        public bool InsertVehicle(Vehicle y, int slot)
        {
            if (slot != -1)
            {
                ParkingLotArray[slot] = y;
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Validates that License Plates dont repeat
        /// </summary>
        public bool LicensePlatesExists(string ULicense)
        {
            for (int i = 0; i < ParkingLotArray.Length; i++)
            {
                if (ParkingLotArray[i] != null)
                {
                    if (ParkingLotArray[i].LicensePlate.Equals(ULicense))
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        /// <summary>
        /// Displays license plates in parking lot array
        /// </summary>
        /// <returns></returns>
        public string LPReport()
        {
            string Report= "\nLicense Plates report: \n";
            for (int i = 0; i < ParkingLotArray.Length; i++)
            {
                if (ParkingLotArray[i]!=null && !ParkingLotArray[i].LicensePlate.Equals(""))
                {
                    Report += i+": "+ParkingLotArray[i].LicensePlate+"\n";
                }

                else
                {
                    Report += i + ": No vehicle in this slot \n";
                }
                
            }
            return Report;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string IndividualEarningsReport()
        {
            string Report = "\nCost report: \n";
            for (int i = 0; i < ParkingLotArray.Length; i++)
            {
                if (ParkingLotArray[i] != null && ParkingLotArray[i].Cost!= 0)
                {
                    Report += i + ": " + ParkingLotArray[i].Cost + "\n";
                }

                else
                {
                    Report += i + ": No vehicle in this slot \n";
                }

            }
            return Report;
        }

        /// <summary>
        /// Sums up all cost values in array, giving a total.
        /// </summary>
        /// <returns></returns>
        public string TotalEarningsReport()
        {
            string TxtTotal = "\nTotal produced: \n";
            int numTotal = 0;
            for (int i = 0; i < ParkingLotArray.Length; i++)
            {
                if (ParkingLotArray[i] != null && ParkingLotArray[i].Cost != 0)
                {
                    numTotal += ParkingLotArray[i].Cost;
                }
                
            }
            TxtTotal += numTotal+"\n";
            return TxtTotal;
        }

        /// <summary>
        /// Returns how many slots are available in array between begin variable and end variable
        /// </summary>
        /// <returns></returns>
        public int AmountEmptyPerType(int begin, int end)
        {
            int numTotal = 0;

            for (int i = begin; i <= end; i++)
            {
                if (ParkingLotArray[i] == null)
                {
                    numTotal++;
                }

            }
            return numTotal;
        }

        /// <summary>
        /// 
        /// </summary>
        public string EmptySlotsTypes()
        {
            return "\nSpots available for " +
                "\nMotorcycles: " + AmountEmptyPerType(0, 3) +
                "\nCars: " + AmountEmptyPerType(4, 8) +
                "\nVans: " + AmountEmptyPerType(9, 14) +
                "\nBuses: " + AmountEmptyPerType(15, 20) +
                "\nTrucks: " + AmountEmptyPerType(21, 27);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string TotalEmptySlots()
        {
            string TxtTotal = "\nTotal spots available: \n";
            int numTotal = 0;
            for (int i = 0; i < ParkingLotArray.Length; i++)
            {
                if (ParkingLotArray[i] == null)
                {
                    numTotal++;
                }
                
            }
            TxtTotal += numTotal+"\n";
            return TxtTotal;
        }

        /// <summary>
        /// Method with the report menu switch
        /// </summary>
        public void ReportMenu()
        {
            int UserType;
            Console.WriteLine("Press \n 1: for License Plates Report \n 2: for Earnings Report \n 3: for Empty Slots");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out UserType);

            if (UserType != 0)
            {
                switch (UserType)
                {
                    case 1:
                        Console.WriteLine(LPReport());
                        break;
                    case 2:
                        Console.WriteLine(IndividualEarningsReport());
                        Console.WriteLine(TotalEarningsReport());
                        break;
                    case 3:
                        Console.WriteLine(EmptySlotsTypes());
                        Console.WriteLine(TotalEmptySlots());
                        break;
                    default:
                        Console.WriteLine("\n Input error");
                        break;
                }
            }
        }


        #endregion


    }
}
