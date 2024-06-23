using TokyoStock.Core.Business;
using TokyoStock.Core.Data;

namespace TokyoStock.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
