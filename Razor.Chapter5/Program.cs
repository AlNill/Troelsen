var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

var app = builder.Build();
app.UseMvcWithDefaultRoute();
app.Run();
