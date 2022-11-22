namespace API.Services
{
    using API.Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceRegister
    {   

        /// <summary>
        /// Register Ogre Api Services
        /// </summary>
        /// <param name="serviceCollection"></param>
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            //serviceCollection.AddScoped<IPurchaseOrderService, PurchaseOrderService>();
            //serviceCollection.AddScoped<IReferenceService, ReferenceService>();
            //serviceCollection.AddScoped<IVendorService, VendorService>();
            //serviceCollection.AddScoped<IProductService, ProductService>();
            //serviceCollection.AddScoped<IPoActivityService, PoActivityService>();

            //serviceCollection.AddScoped<ICvsIntegrationService, CvsIntegrationService>();
        }
    }
}
