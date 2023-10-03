using MediatR;
using MeditorC_Api.Entites;

namespace MeditorC_Api.Queries.GetBook
{
    public class GetBookQuery :IRequest<Book>
    {
        public string Name { get; set; }

        public  GetBookQuery(string name)
        {
            Name = name;
        }
    }
}
