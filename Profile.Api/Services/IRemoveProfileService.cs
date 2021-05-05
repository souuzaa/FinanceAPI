using System;
using System.Threading.Tasks;

namespace Profile.Api.Services
{
    public interface IRemoveProfileService : IProfileService
    {
        Task<bool> RemoveProfileAsync(int id);
    }
}
