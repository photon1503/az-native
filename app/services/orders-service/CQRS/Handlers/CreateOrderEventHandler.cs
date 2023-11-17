using MediatR;

namespace FoodApp
{
    public class CreateOrderEventHandler : IRequestHandler<CreateOrderEventCommand, OrderEventResponse>
    {
        private readonly IOrderEventsStore orderEventsStore;

        public CreateOrderEventHandler(IOrderEventsStore eventStore)
        {
            orderEventsStore = eventStore;
        }

        public async Task<OrderEventResponse> Handle(CreateOrderEventCommand request, CancellationToken cancellationToken)
        {                        
            var evt = new OrderEvent
            {
                OrderId = Guid.NewGuid().ToString(),
                CustomerId = request.order.Customer.Id,
                EventType = "Created",
                Data = request.order,
            };
            request.order.Id = evt.OrderId;
            return await orderEventsStore.CreateOrderEventAsync(evt);
        }        
    }
}