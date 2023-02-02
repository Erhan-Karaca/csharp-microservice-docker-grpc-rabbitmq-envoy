using Catalog.API.Application.Interfaces.Repository;
using Catalog.API.Domain.Entities;
using Catalog.API.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.API.Persistence.Repositories
{
    public class CatalogRepository : GenericRepository<Catalogg>, ICatalogRepository
    {
        public CatalogRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
