using MediatR;
using MeditorC_Api.Entites;

namespace MediatorC_.Commands.AddBook
{
    public class AddBookCommand : IRequest<AddBookCommandResponse>
    {
        public string Name { get;set; }
    }

    public class AddBookCommandResponse
    {
        public int Id { get; set; }
    }
}
