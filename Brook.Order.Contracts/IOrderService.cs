using Brook.Order.Contracts.Models.Dtos;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Brook.Order.Contracts
{
    public interface IOrderService : IApplicationService
    {
        Task<OrderDto> CreateAsync(OrderDto product);

        Task<OrderDto> GetAsync(string id);
    }
}
