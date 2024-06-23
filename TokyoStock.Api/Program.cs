using TokyoStock.Core.Business;
using TokyoStock.Core.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<VentaRepository>();
builder.Services.AddScoped<VentaBusiness>();
builder.Services.AddScoped<CompraRepository>();
builder.Services.AddScoped<CompraBusiness>();
builder.Services.AddScoped<UsuarioRepository>();
builder.Services.AddScoped<UsuarioBusiness>();
builder.Services.AddScoped<ProductoRepository>();
builder.Services.AddScoped<ProductoBusiness>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
