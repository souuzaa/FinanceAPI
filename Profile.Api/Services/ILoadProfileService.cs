using System;
using System.Threading.Tasks;

namespace Profile.Api.Services
{
    public interface ILoadProfileService : IProfileService
    {
        Task<Finance.ApiModels.Models.Profile> LoadProfileAsync(int id);
    }
}
