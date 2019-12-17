using System;
using System.Threading.Tasks;
using AutoMapper;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;
using PerfectOnion.Core.PerfectOnion.Entities;
using PerfectOnion.Core.PerfectOnion.Interfaces;
using PerfectOnion.Services.PerfectOnion;
using Xunit;

namespace PerfectOnion.Tests.Unit.Services
{
    public class OrderServiceTests : TestBase
    {
        private readonly IOrderService _orderService;
        private readonly Mock<IPerfectOnionUnitOfWork> _unitOfWorkMock;

        public OrderServiceTests()
        {
            var loggerMock = new Mock<ILogger<OrderService>>();
            var mapper = ServiceProvider.GetService<IMapper>();
            
            _unitOfWorkMock = new Mock<IPerfectOnionUnitOfWork>();
            _orderService = new OrderService(_unitOfWorkMock.Object, loggerMock.Object, mapper);
        }
        
        [InlineData(-10)]
        [InlineData(0)]
        [Theory]
        public void GetAsync_InvalidId_ShouldThrowArgumentException(int id)
        {
            Func<Task> act = async () => { await _orderService.GetAsync(id);};

            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public async Task GetAsync_ValidId_ShouldReturnOrder()
        {
            const int orderId = 1;
            
            _unitOfWorkMock
                .Setup(e => e.Orders.GetAsync(orderId))
                .ReturnsAsync(() => new Order
                {
                    Id = orderId
                });

            var order = await _orderService.GetAsync(orderId);

            order.Should().NotBeNull();
            order.Id.Should().Be(orderId);
        }

        [Fact]
        public async Task GetAsync_ValidIdOrderNotExist_ShouldReturnNull()
        {
            const int orderId = 1;
            
            _unitOfWorkMock
                .Setup(e => e.Orders.GetAsync(orderId))
                .ReturnsAsync(() => null);
            
            var order = await _orderService.GetAsync(orderId);

            order.Should().BeNull();
        }

        [Fact]
        public async Task GetAllAsync_2OrdersInDb_ShouldReturn2Orders()
        {
            _unitOfWorkMock.Setup(e => e.Orders.GetAllAsync())
                .ReturnsAsync(() => new[]
                {
                    new Order
                    {
                        Id = 1
                    }, 
                    new Order
                    {
                        Id = 2
                    }
                });
            
            var orders = await _orderService.GetAllAsync();

            orders.Should().NotBeNull();
            orders.Should().HaveCount(2);
        }

        [Fact]
        public async Task GetAllAsync_NoOrdersInDb_ShouldReturnEmptyCollection()
        {
            _unitOfWorkMock.Setup(e => e.Orders.GetAllAsync())
                .ReturnsAsync(() => null);
            
            var orders = await _orderService.GetAllAsync();

            orders.Should().NotBeNull();
            orders.Should().HaveCount(0);
        }
    }
}