using StoreApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace StoreApi.Services
{
    public interface ICarPart
    {
        public Task<List<CarPart>> getCarParts();

        public Task<CarPart> getCarPart(int id);
        public Task<CarPart> addCarPart(CarPart user);
        public Task<bool> editCarPart(CarPart user);
        public Task<bool> deleteCarPart(int id);
    }
}
