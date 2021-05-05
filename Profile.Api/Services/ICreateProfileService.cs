using System.Threading.Tasks;

namespace Profile.Api.Services
{
    public interface ICreateProfileService : IProfileService
    {
        Task<bool> CreateProfileAsync(Finance.ApiModels.Models.Profile profile);
    }
}
