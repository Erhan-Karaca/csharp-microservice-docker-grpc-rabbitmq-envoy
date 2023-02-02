using MediatR;
using Catalog.API.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.API.Application.Features.Queries.GetCatalogById
{
    public class GetCatalogByIdQuery : IRequest<ServiceResponse<GetCatalogByIdViewModel>>
    {
        public Guid Id { get; set; }
    }
}
