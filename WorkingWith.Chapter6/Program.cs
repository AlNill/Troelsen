var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

var app = builder.Build();

//Exceptions on the browser page
app.UseDeveloperExceptionPage();
//Include wwwroot
app.UseStaticFiles();
//Include Mvc
app.UseMvcWithDefaultRoute();
app.Run();
