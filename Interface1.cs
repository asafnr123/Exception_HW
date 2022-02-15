using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_HW
{
    internal interface IGarage
    {

        public void FixCar(Car car);

        public void TakeOurCar(Car car);

        public void AddCar(Car car);
        
    }
}
