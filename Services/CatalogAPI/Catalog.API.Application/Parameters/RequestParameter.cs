﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.API.Application.Parameters
{
    public class RequestParameter
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public RequestParameter(int pageSize, int pageNumber)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
        }
    }
}
