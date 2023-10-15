using ATOM.Core.Entities;
using ATOM.Core.Repositories;
using ATOM.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOM.Repository.Repositories
{
    public class WreckPopRepository : GenericRepository<WreckPopulation>, IWreckPopRepository
    {
        WreckDemand wreckDemand;
        public WreckPopRepository(AppDbContext dbContext) : base(dbContext)
        {
            
        }
        
        public async Task Test(string districtName)
        {
            var district = await _dbContext.Districts.FirstOrDefaultAsync(x=>x.Name == districtName);
            var districtId = district.Id;

            var wrackPop = await _dbContext.WreckPopulations.FirstOrDefaultAsync(x => x.DistrictId == districtId);

            if (wrackPop == null)
            {
                WreckPopulation newWreck = new WreckPopulation
                {
                    DistrictId = districtId,
                    Latitude = wreckDemand.Latitude,
                    Longitude = wreckDemand.Longitude,
                    People = 1
                };
                await _dbContext.WreckPopulations.AddAsync(newWreck);
            }
            else
            {
                // Mahalleye ait kayıt var, enlem ve boylamı güncelle
                wrackPop.Latitude = ((wrackPop.Latitude * wrackPop.People) + wreckDemand.Latitude) / (wrackPop.People + 1);
                wrackPop.Longitude = ((wrackPop.Longitude * wrackPop.People) + wreckDemand.Longitude) / (wrackPop.People + 1);

                // People sayısını artır
                wrackPop.People++;
            }
            await _dbContext.SaveChangesAsync();
        }
    }
}
