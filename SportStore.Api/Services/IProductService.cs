﻿using SportStore.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Api.Services
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> GetProductsAsync();
    }
}
