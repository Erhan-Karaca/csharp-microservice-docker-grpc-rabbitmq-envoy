using AutoMapper;
using MediatR;
using Catalog.API.Application.Interfaces.Repository;
using Catalog.API.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.API.Application.Features.Queries.GetCatalogById
{
    public class GetCatalogByIdHandler : IRequestHandler<GetCatalogByIdQuery, ServiceResponse<GetCatalogByIdViewModel>>
    {
        ICatalogRepository catalogRepository;
        private readonly IMapper mapper;

        public GetCatalogByIdHandler(ICatalogRepository catalogRepository, IMapper mapper)
        {
            this.catalogRepository = catalogRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<GetCatalogByIdViewModel>> Handle(GetCatalogByIdQuery request, CancellationToken cancellationToken)
        {
            var catalog = await catalogRepository.GetByIdAsync(request.Id);
            var dto = mapper.Map<GetCatalogByIdViewModel>(catalog);
            return new ServiceResponse<GetCatalogByIdViewModel>(dto);
        }
    }
}
