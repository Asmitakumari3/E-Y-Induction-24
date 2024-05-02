var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient(typeof(productsCollectionAPI.ProductDetails));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRouting(); //enable routing, or tell the runtime to make use of routing, create an internal index for URI (this take extra time while starting the application)

app.MapControllers();

app.Run();
