using System;
namespace Profile.Api.Services.Factories
{
    public interface IProfileServiceFactory
    {
        IProfileService Create();
    }
}
