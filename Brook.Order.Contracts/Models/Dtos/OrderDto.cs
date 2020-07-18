using Brook.Product.Contracts.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brook.Order.Contracts.Models.Dtos
{
    public class OrderDto
    {
        public string Id { get; set; }

        public string OrderNo { get; set; }

        public IEnumerable<ProductDto> ProductItems { get; set; }
    }
}
