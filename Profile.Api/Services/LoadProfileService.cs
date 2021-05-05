using System;
using System.Threading.Tasks;

namespace Profile.Api.Services
{
    public class LoadProfileService : ILoadProfileService
    {
        public LoadProfileService()
        {
        }

        public Task<Finance.ApiModels.Models.Profile> LoadProfileAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
