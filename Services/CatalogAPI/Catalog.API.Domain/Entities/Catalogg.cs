using Catalog.API.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.API.Domain.Entities
{
    public class Catalogg: BaseEntity
    {
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
