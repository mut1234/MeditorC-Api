using MediatorC_.Commands.AddBook;
using MediatR;
using MeditorC_Api.Entites;
using MeditorC_Api.Queries.GetBook;
using Microsoft.AspNetCore.Mvc;

namespace MediatorC_.Controllers
{
    public class BookController
    {
        private readonly IMediator _meditor;

        public BookController(IMediator mediator)
        {
            _meditor = mediator;
        }

        [HttpPost]
        public Task<Book > Get([FromBody] GetBookQuery query) {

            return _meditor.Send(query);
        }
        [HttpPost]
        public Task Add(AddBookCommand book)
        {
            return _meditor.Send(book);
        }


    }
}
