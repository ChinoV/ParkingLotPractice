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
        public bool InsertVehicle(Vehicle y, int UserType)
        {
            int slot=-1;
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

            #endregion



           




            


    }
}
