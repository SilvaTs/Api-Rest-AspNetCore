using Aula2.Adapter;
using Aula2.Bordas.Adapter;
using Aula2.Bordas.Repositorios;
using Aula2.Bordas.UseCase;
using Aula2.Context;
using Aula2.DTO.Carro.AtualizarCarro;
using Aula2.Repositorios;
using Aula2.Services;
using Aula2.UseCase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Aula2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddEntityFrameworkNpgsql().AddDbContext<LocalDbContext>(opt => opt.UseNpgsql
           (Configuration.GetConnectionString("urlDaniel")));


            services.AddScoped<ICarroService, CarroService>();

            services.AddScoped<IAdicionarCarroUseCase, AdicionarCarroUseCase>();
            services.AddScoped<IAtualizarCarroUseCase, AtualizarCarroUseCase>();
            services.AddScoped<IRemoverCarroUseCase, RemoverCarroUseCase>();
            services.AddScoped<IRetornarListadeCarrosUseCase, RetornarListadeCarrosUseCase>();
            services.AddScoped<IRetornarCarrosPorIdUseCase, RetornarCarrosPorIdUseCase>();

            services.AddScoped<IRepositorioCarros, RepositorioCarros>();
            services.AddScoped<IAdicionarCarroAdapter, AdicionarCarroAdapter>();
            services.AddScoped<IAtualizarCarroAdapter, AtualizarCarroAdapter>();


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
