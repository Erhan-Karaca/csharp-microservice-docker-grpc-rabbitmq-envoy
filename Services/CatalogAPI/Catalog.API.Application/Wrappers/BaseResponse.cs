using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.API.Application.Wrappers
{
    public class BaseResponse
    {
        public Guid Id { get; set; }
        public bool Success { get; set; }
        public String Message { get; set; }
    }
}
