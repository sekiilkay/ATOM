using ATOM.Core.Entities;
using ATOM.Core.Repositories;
using ATOM.Core.Services;
using ATOM.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOM.Service.Services
{
    public class WreckPopService : GenericService<WreckPopulation>, IWreckPopService
    {
        private readonly IWreckPopRepository _repository;
        public WreckPopService(IGenericRepository<WreckPopulation> genericRepository, IUnitOfWork unitOfWork, IWreckPopRepository repository) : base(genericRepository, unitOfWork)
        {
            _repository = repository;
        }

        public async Task Test(string districtName)
        {
            await _repository.Test(districtName); 
        }
    }
}
