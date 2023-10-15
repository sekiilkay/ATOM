using ATOM.Core.DTOs.Request;
using ATOM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOM.Core.Repositories
{
    public interface IHelpDemandRepository : IGenericRepository<HelpDemand>
    {
        public Task AddHelpDemand(AddHelpDemandDto helpDemand);

        public Task<(float AverageLatitude, float AverageLongitude)> AverageHelpLocation(int id);

    }
}
