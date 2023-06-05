using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Sisongs.Application.Services;
using Sisongs.Data.Repositories;
using Sisongs.Infrastructure.Data;
using System.Net;
using Microsoft.Extensions.Logging;

namespace API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SisongsDbContext>(options =>
                options.UseNpgsql("Server=containers-us-west-165.railway.app;Port=6507;Database=railway;User Id=postgres;Password=J8AtcXbLGlLzXGbSYLWh;"));

            
            services.AddScoped<IOngRepository, OngRepository>();
            services.AddScoped<IProjetoRepository, ProjetoRepository>();

            services.AddScoped<IOngService, OngService>();
            services.AddScoped<IProjetoService, ProjetoService>();

            services.AddControllers();

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Nome da sua API", Version = "v1" });

            //    // Configurar o suporte a versões da API
            //    // c.OperationFilter<ApiVersionOperationFilter>();
            //});

            services.Configure<KestrelServerOptions>(options =>
            {
                options.Listen(IPAddress.Parse("0.0.0.0"), Convert.ToInt32(5001));
            });

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin()//("http://localhost:4200") // Substitua com a origem permitida do seu frontend
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
               app.UseDeveloperExceptionPage();
            //}
            app.UseCors();
            app.UseRouting();

            // Middleware do Swagger
            //app.UseSwagger();
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Nome da sua API v1");
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }






    }
}
