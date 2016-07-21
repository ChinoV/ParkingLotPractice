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
        /// 
        /// </summary>
        /// <param name="y"></param>
        /// <param name="UserType"></param>
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
        /// 
        /// </summary>
        /// <param name="ULicense"></param>
        /// <returns></returns>
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

    
  //else
  //                      {
  //                          Console.Writeline("We already have a vehicle with that license plate")
  //                      }


    #endregion


}
}
