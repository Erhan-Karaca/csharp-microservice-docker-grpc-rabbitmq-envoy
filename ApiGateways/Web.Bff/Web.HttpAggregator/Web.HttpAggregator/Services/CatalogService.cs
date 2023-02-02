using GrpcCatalog;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.HttpAggregator.Models;

namespace Web.HttpAggregator.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly Catalog.CatalogClient _catalogClient;
        private readonly ILogger<CatalogService> _logger;

        public CatalogService(Catalog.CatalogClient catalogClient, ILogger<CatalogService> logger)
        {
            _catalogClient = catalogClient;
            _logger = logger;
        }

        public async Task<CatalogData> GetById(string id)
        {
            _logger.LogDebug("grpc catalogService client created, request = {@id}", id);
            var response = await _catalogClient.GetCatalogByIdAsync(new CatalogRequest { Id = id });
            _logger.LogDebug("grpc catalogService response {@response}", response);
            return MapToBasketData(response);
        }

        private CatalogData MapToBasketData(CatalogResponse catalogResponse)
        {
            if(catalogResponse == null)
            {
                return null;
            }

            var map = new CatalogData
            {
                Id = catalogResponse.Id,
                Name = catalogResponse.Name
            };

            return map;
        }

    }
}
