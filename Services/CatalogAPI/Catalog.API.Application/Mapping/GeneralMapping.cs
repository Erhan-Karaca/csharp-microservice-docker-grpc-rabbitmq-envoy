using AutoMapper;
using Catalog.API.Application.Features.Commands;
using Catalog.API.Application.Features.Queries.GetCatalogById;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.API.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Domain.Entities.Catalogg, Dto.CatalogViewDto>().ReverseMap();
            CreateMap<Domain.Entities.Catalogg, CreateCatalogCommand>().ReverseMap();
            CreateMap<Domain.Entities.Catalogg, GetCatalogByIdViewModel>().ReverseMap();
        }
    }
}
