using ATOM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOM.Core.Services
{
    public interface IGatheringCenterService : IGenericService<GatheringCenter>
    {
        Task<(BaseCenter, float distance)> NearGatheringCenter(float longitude, float latitude);
        Task<List<BaseCenter>> ListNearGatheringCenters(float longitude, float latitude);

    }
}
