using Brook.Order.Contracts;
using Brook.Order.Contracts.Models.Dtos;
using Brook.Product.Contracts;
using Brook.Product.Contracts.Models.Dtos;
using System;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Brook.Order
{
    public class OrderService : ApplicationService, IOrderService
    {
        private IProductService productService { get; set; }
        public OrderService(IProductService productService)
        {
            this.productService = productService;
        }

        public Task<OrderDto> CreateAsync(OrderDto Order)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderDto> GetAsync(string id)
        {
            var items = await this.productService.GetListAsync(new ProductQueryDto());
            var task = await Task.Run(() =>
            {
                Thread.Sleep(100);
                return new OrderDto() { Id = id, OrderNo = "1234", ProductItems = items };
            });
            return task;
        }
    }
}
