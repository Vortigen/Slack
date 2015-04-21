using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamDemo
{
    class Program
    {
        #region Public Methods

        static void Main(string[] args)
        {
            var carsCount = ReadCarsCount();

            var cars = new Car[carsCount];
            EnterCarsInformation(cars);

            DisplayCarsTable(cars);

            Console.ReadLine();
        }

        #endregion

        #region Private Methods

        private static int ReadCarsCount()
        {
            Console.Write("Въведете брой коли: ");
            return int.Parse(Console.ReadLine());
        }

        public static void EnterCarsInformation(IList<Car> cars)
        {
            for (int carIndex = 0; carIndex < cars.Count; carIndex++)
            {
                Console.WriteLine("Въведете информация за кола " + (carIndex + 1));
                Car newCar = new Car();
                newCar.EnterInformation();

                cars[carIndex] = newCar;
            }
        }

        private static void DisplayCarsTable(IList<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.GetFormattedInfo());
            }
        }

        #endregion
    }
}
