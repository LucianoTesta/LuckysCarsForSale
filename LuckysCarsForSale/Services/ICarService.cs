using LuckysCarsForSale.Dtos;

namespace LuckysCarsForSale.Services
{
    public interface ICarService
    {
        Task<List<CarDTO?>> GetAllCars();
    }
}
