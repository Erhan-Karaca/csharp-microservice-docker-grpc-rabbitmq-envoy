using AutoMapper;
using MediatR;
using Catalog.API.Application.Interfaces.Repository;
using Catalog.API.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.API.Application.Features.Commands
{
    public class CreateCatalogCommand : IRequest<ServiceResponse<Guid>>
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public class CreateCatalogCommandHandler : IRequestHandler<CreateCatalogCommand, ServiceResponse<Guid>>
        {
            ICatalogRepository catalogRepository;
            private readonly IMapper mapper;

            public CreateCatalogCommandHandler(ICatalogRepository catalogRepository, IMapper mapper)
            {
                this.catalogRepository = catalogRepository;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<Guid>> Handle(CreateCatalogCommand request, CancellationToken cancellationToken)
            {
                var catalog = mapper.Map<Domain.Entities.Catalogg>(request);
                await catalogRepository.AddAsync(catalog);
                return new ServiceResponse<Guid>(catalog.Id);
            }
        }
    }
}
