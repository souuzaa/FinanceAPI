using System;
using System.Threading.Tasks;

namespace Profile.Api.Services
{
    public class CreateProfileService : ICreateProfileService
    {
        public CreateProfileService()
        {
        }

        public Task<bool> CreateProfileAsync(Finance.ApiModels.Models.Profile profile)
        {
            throw new NotImplementedException();
        }
    }
}
