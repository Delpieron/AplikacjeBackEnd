using Microsoft.EntityFrameworkCore;
using StoreApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreApi.Services
{
    public class CarPartService : ICarPart
    {
        public CarPartService(DataContext dbcontext)
        {
            DbContext = dbcontext;
        }
        public DataContext DbContext { get; set; }

        public async Task<CarPart> addCarPart(CarPart carPart)
        {
            await DbContext.CarParts.AddAsync(carPart);
            await DbContext.SaveChangesAsync();
            var newSser = await getCarPart(carPart.Id);
            return newSser;
        }

        public async Task<CarPart> getCarPart(int id)
        {
            return await DbContext.CarParts.SingleOrDefaultAsync((x) => x.Id == id);
        }
        public async Task<bool> editCarPart(CarPart carPart)
        {
            DbContext.CarParts.Update(carPart);
            return await DbContext.SaveChangesAsync() >= 0;
        }
        public async Task<bool> deleteCarPart(int id)
        {
            var carPart = await getCarPart(id);
            if (carPart == null) return false;
            DbContext.CarParts.Remove(carPart);
            int result = await DbContext.SaveChangesAsync();
            return result >= 0;
        }

        public async Task<List<CarPart>> getCarParts()
        {
            return await DbContext.CarParts.ToListAsync();
        }
    }
}
