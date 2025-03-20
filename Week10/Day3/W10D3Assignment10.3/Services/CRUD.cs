using W10D3Assignment10._3.Data;
using W10D3Assignment10._3.Models;

namespace W10D3Assignment10._3.Services {
    public class CRUD {
        public void AddRecord(Car car) {
            Records.carContext.Cars.Add(car);
            Records.carContext.SaveChanges();
        }

        public void DeleteRecord(int carID) {
            var car = Records.carContext.Cars.Find(carID);
            if (car != null) Records.carContext.Remove(car);
            Records.carContext.SaveChanges();
        }

        public void UpdateRecord(int carID, Car car) {
            var carToUpdate = Records.carContext.Cars.Find(carID);

            if (carToUpdate != null) {
                carToUpdate.CarID = car.CarID;
                carToUpdate.Vin = car.Vin;
                carToUpdate.Make = car.Make;
                carToUpdate.Model = car.Model;
                carToUpdate.Price = car.Price;
            }
        }

        public int GetMaxId() {
            return Records.carContext.Cars.Max(car => car.CarID);
        }

        public ICollection<Car> GetCars() {
            return Records.carContext.Cars.ToList();
        }

        public Car FindCar(int carID) {
            return Records.carContext.Cars.Find(carID);
        }
    }
}
