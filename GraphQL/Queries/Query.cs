using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Components.Web;
using GraphQLHotChocolate.Type;

namespace GraphQLHotChocolate.Query;

public class Query
{
    public Book GetBook() => 
    new Book
    {
        Title = "C# in depth.",
        Author = new Author
        {
            Name = "Jon Skeet"
        }
    };
}