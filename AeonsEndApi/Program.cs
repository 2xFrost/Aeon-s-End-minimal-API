using AeonsEndApi.Utilites.Endpoints;
using AeonsEndApi.Utilites;
using AeonsEndApi.Data.SeederData;

var builder = WebApplication.CreateBuilder(args);
builder.BuilderServices();

var app = builder.Build();

app.DatabaseCheck();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.EndpointsHub();

app.Run();
