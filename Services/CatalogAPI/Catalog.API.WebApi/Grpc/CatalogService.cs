using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcCatalog
{
    public class CatalogService: Catalog.CatalogBase
    {
        public CatalogService()
        {

        }

        public override async Task<CatalogResponse> GetCatalogById(CatalogRequest request, ServerCallContext context)
        {
            CatalogResponse result = new CatalogResponse()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Test Catalog Response"
            };
            return result;
        }

    }
}
