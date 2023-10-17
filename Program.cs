using GraphQLHotChocolate.Query;

var builder = WebApplication.CreateBuilder(args);

// Add services required by Hot Chocolate
builder.Services.AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();



app.MapGet("/", () => "Hello World!");

// Add GraphQL endpoint
app.MapGraphQL();

app.Run();
