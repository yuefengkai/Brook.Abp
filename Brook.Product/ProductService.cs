﻿using Brook.Product.Contracts;
using Brook.Product.Contracts.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Brook.Product
{
    public class ProductService : ApplicationService, IProductService
    {
        private List<ProductDto> products { get; set; }

        public ProductService()
        {
            products = new List<ProductDto>();
            products.Add(new ProductDto() { Id = "1", Name = "Apple" });
            products.Add(new ProductDto() { Id = "2", Name = "Orange" });
        }

        public Task<ProductDto> CreateAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> GetListAsync(ProductQueryDto query)
        {
            var task = await Task.Run(() =>
            {
                Thread.Sleep(100);
                return products.AsEnumerable();
            });
            return task;
        }
    }
}
