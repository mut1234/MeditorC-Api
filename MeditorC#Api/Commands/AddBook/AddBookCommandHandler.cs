using MediatR;
using MeditorC_Api.Entites;

namespace MediatorC_.Commands.AddBook
{
    public class AddBookCommandHandler : IRequestHandler<AddBookCommand, AddBookCommandResponse>
    {
        public async Task<AddBookCommandResponse> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book { Name = request.Name };
            return Task.FromResult(new AddBookCommandResponse { }).Result;
        }
    }
}
