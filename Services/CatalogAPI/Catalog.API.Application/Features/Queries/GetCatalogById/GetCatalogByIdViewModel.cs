using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.API.Application.Features.Queries.GetCatalogById
{
    public class GetCatalogByIdViewModel
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
