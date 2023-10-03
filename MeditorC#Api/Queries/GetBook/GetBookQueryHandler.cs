using MediatR;
using MeditorC_Api.Entites;

namespace MeditorC_Api.Queries.GetBook
{
    public class GetBookQueryHandler : IRequestHandler<GetBookQuery,Book>
    {
        public Task<Book> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            //find book by name in the database
            return Task.FromResult(new Book(request.Name));
        }
    }
}
