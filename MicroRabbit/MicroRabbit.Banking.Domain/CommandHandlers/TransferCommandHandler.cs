using MediatR;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Domain.Core.Bus.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            var transfer = new TransferCreatedEvent(request.From, request.To, request.Amount);

            _bus.Publish(transfer);

            return Task.FromResult(true);
        }
    }
}
