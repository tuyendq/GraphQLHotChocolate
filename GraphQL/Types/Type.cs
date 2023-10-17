using GraphQLHotChocolate.Query;

namespace GraphQLHotChocolate.Type;
public class Book
{
    public required string Title { get; set; }
    public Author? Author { get; set; }
}

public class Author
{
    public required string Name { get; set; }
}