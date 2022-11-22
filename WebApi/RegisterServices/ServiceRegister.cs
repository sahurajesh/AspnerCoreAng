namespace WebApi.RegisterServices
{
    using Microsoft.Extensions.DependencyInjection;
    using WebApi.Interfaces;
    using WebApi.Services;

    public static class ServiceRegister
    {
        /// <summary>
        /// Register Ogre Api Services
        /// </summary>
        /// <param name="serviceCollection"></param>
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUsers, UserServices>();
            
        }
    }
}
