﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bangazon.Data;
using Bangazon.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bangazon.Models.ProductViewModels
{
    public class ProductSellViewModel
    {
        public Product Product { get; set; }

        public List<SelectListItem> ProductTypes { get; set; }

        public ProductSellViewModel(ApplicationDbContext context)
        {
            ProductTypes = context.ProductType.Select(productType =>
            new SelectListItem { Text = productType.Label, Value = productType.ProductTypeId.ToString() }).ToList();
        }

    }
}
