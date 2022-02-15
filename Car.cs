using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_HW
{
    internal class Car
    {

        public string Brand { get; set; }

        public bool TotalLost { get; set; }

        public bool NeedsRepair { get; set; }


        public Car(string brand, bool totalLost, bool needsRepair)
        {
            if (totalLost == true && needsRepair == false)
            {
                throw new RepairMismatchException("Cant be repaired");
            }
            this.Brand = brand;
            this.TotalLost = totalLost;
            this.NeedsRepair = needsRepair;
        }

    }
}
