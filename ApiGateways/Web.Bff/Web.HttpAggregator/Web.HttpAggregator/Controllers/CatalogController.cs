using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.HttpAggregator.Models;
using Web.HttpAggregator.Services;

namespace Web.HttpAggregator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogService _catalog;
        private readonly ILogger<CatalogController> _logger;

        public CatalogController(ICatalogService catalogService, ILogger<CatalogController> logger)
        {
            _catalog = catalogService;
            _logger = logger;
        }

        [HttpGet]
        public Task<CatalogData> Get()
        {
            _logger.LogInformation("grpc catalogService start");
            _logger.LogDebug("grpc catalogService start");
            return _catalog.GetById("1");
        }
    }
}
