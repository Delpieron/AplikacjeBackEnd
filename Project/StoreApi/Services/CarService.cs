using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreApi.Services
{
    public class CarService : ICar
    {
        public CarService(DataContext dbcontext)
        {
            DbContext = dbcontext;
        }
        public DataContext DbContext { get; set; }

        public async Task<Car> addCar(Car car)
        {
            await DbContext.Car.AddAsync(car);
            await DbContext.SaveChangesAsync();
            var newSser = await getCar(car.Id);
            return newSser;
        }

        public async Task<Car> getCar(int id)
        {
            return await DbContext.Car.SingleOrDefaultAsync((x) => x.Id == id);
        }
        public async Task<bool> editCar(Car car)
        {
            DbContext.Car.Update(car);
            return await DbContext.SaveChangesAsync() >= 0;
        }
        public async Task<bool> deleteCar(int id)
        {
            var car = await getCar(id);
            if (car == null) return false;
            DbContext.Car.Remove(car);
            int result = await DbContext.SaveChangesAsync();
            return result >= 0;
        }

        public async Task<List<Car>> getCars()
        {
            return await DbContext.Car.ToListAsync();
        }
    }
}
