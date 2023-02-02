using AutoMapper;
using MediatR;
using Catalog.API.Application.Dto;
using Catalog.API.Application.Interfaces.Repository;
using Catalog.API.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.API.Application.Features.Queries.GetAllCatalogs
{
    public class GetAllCatalogsQuery : IRequest<ServiceResponse<List<CatalogViewDto>>>
    {
        public class GetAllCatalogsQueryHandler : IRequestHandler<GetAllCatalogsQuery, ServiceResponse<List<CatalogViewDto>>>
        {
            private readonly ICatalogRepository catalogRepository;
            private readonly IMapper mapper;

            public GetAllCatalogsQueryHandler(ICatalogRepository catalogRepository, IMapper mapper)
            {
                this.catalogRepository = catalogRepository;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<List<CatalogViewDto>>> Handle(GetAllCatalogsQuery request, CancellationToken cancellationToken)
            {
                var catalogs = await catalogRepository.GetAllAsync();
                var viewModel = mapper.Map<List<CatalogViewDto>>(catalogs);
                return new ServiceResponse<List<CatalogViewDto>>(viewModel);
            }
        }
    }
}
