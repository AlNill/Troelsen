var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseMvcWithDefaultRoute();
app.Run();
