using Brook.Product.Contracts.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Brook.Product.Contracts
{
    public interface IProductService: IApplicationService
    {
        Task<ProductDto> CreateAsync(ProductDto product);

        Task<IEnumerable<ProductDto>> GetListAsync(ProductQueryDto query);
    }
}
