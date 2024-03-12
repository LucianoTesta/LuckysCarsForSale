using LuckysCarsForSale.Data;
using LuckysCarsForSale.Dtos;
using Microsoft.EntityFrameworkCore;

namespace LuckysCarsForSale.Services
{
    public class CarService : ICarService
    {
        private readonly LuckysCarsForSaleDbContext _dbContext;

        public CarService(LuckysCarsForSaleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CarDTO>> GetAllCars()
        {
            var query = from car in _dbContext.Cars
                        join quote in _dbContext.Quotes on car.CarId equals quote.CarId into carQuotes
                        from cq in carQuotes.Where(q => q.IsCurrent).DefaultIfEmpty()
                        join buyer in _dbContext.Buyers on cq.BuyerId equals buyer.BuyerId into carBuyers
                        from cb in carBuyers.DefaultIfEmpty()
                        join statusHistory in _dbContext.StatusHistory on car.CarId equals statusHistory.CarId into carStatuses
                        from cs in carStatuses.Where(sh => sh.StatusDate == carStatuses.Max(x => x.StatusDate)).DefaultIfEmpty()
                        join status in _dbContext.Statuses on cs.StatusId equals status.StatusId into carStatusNames
                        from csn in carStatusNames.DefaultIfEmpty()
                        select new CarDTO
                        {
                            CarYear = car.CarYear,
                            Make = car.Make,
                            Model = car.Model,
                            Submodel = car.Submodel,
                            CarLocation = car.CarZipCode,
                            CurrentBuyerName = cb.BuyerName,
                            CurrentQuote = cq.Amount,
                            CurrentStatus = csn.StatusName,
                            StatusDate = cs.StatusDate
                        };

            return await query.ToListAsync();
        }
    }
}
