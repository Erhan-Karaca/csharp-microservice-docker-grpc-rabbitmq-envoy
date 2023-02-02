using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Catalog.API.Application.Interfaces.Repository;
using Catalog.API.Persistence.Context;
using Catalog.API.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.API.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));

            serviceCollection.AddTransient<ICatalogRepository, CatalogRepository>();
        }
    }
}
