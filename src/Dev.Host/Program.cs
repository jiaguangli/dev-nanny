using Dev.Host;

var builder = WebApplication.CreateBuilder(args);


builder.Services.ReplaceConfiguration(builder.Configuration);

builder.Services.AddApplication<DevHostModule>();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.InitializeApplication();

app.Run();