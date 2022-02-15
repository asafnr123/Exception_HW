using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_HW
{
    internal class Garage : IGarage
    {

        const string GARAGE_NAME = "GarageLand";

        int counter = 0;
        public static Car[] myCars { get; set; }
        public string[] carType { get; set; }
       



        public Garage(string[] carType)
        {
            this.carType = carType;
        }

        static Garage()
        {
            myCars = new Car[5];
        }


        public void AddCar(Car car)
        {

            if (car == null)
            {
                throw new ArgumentNullException();
            }

            else if (myCars.Contains(car))
            {
                throw new CarAlreadyHereException("Your car is already in ");
            }

            else if (car.NeedsRepair == false)
            {
                throw new RepairMismatchException("Your car doesn't need repair");
            }

            else if(car.TotalLost == true)
            {
                throw new WeDoNotFixTotalLostException("We dont repair total lost cars");
            }

            else if(!carType.Contains(car.Brand))
            {
                throw new WrongGarageException($"We dont repair {car.Brand} cars");
            }

            else
            {
                Console.WriteLine($"Welcome to {GARAGE_NAME}");
                myCars[counter++] = car;
            }

        }

        public void FixCar(Car car)
        {

            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            else if (myCars.Contains(car) == false)
            {
                throw new CarNotInGarageException("Your car is not in the garage");
            }

            if (car.NeedsRepair == false)
            {
                throw new CarNotReadyException("Car not ready yet");
            }

            else
            {
                Console.WriteLine("Your car is ready now");
                car.NeedsRepair = false;
                TakeOurCar(car);
            }

        }

        public void TakeOurCar(Car car)
        {

            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            else if (myCars.Contains(car) == false)
            {
                throw new CarNotInGarageException("Your car is not in the garage");
            }

            if (car.NeedsRepair == true)
            {
                throw new CarNotReadyException("Car not ready yet");
            }

            else
            {
                Console.WriteLine($"Thank you for choosing {GARAGE_NAME}");
                counter--;
                myCars[counter] = null;

            }
            
        }
    }
}
