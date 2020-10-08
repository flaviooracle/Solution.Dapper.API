using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Solution.Dapper.Core.Services;
using Solution.Dapper.Core.Services.interfaces;
using Solution.Dapper.Domain.Contract;
using Solution.Dapper.Repository;
using Solution.Dapper.Repository.Repositories;

namespace Solution.Dapper.API
{
    public class Startup
    {

        public IConfiguration Configuration { get; }
        public string conection { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //conection = configuration.GetConnectionString("MyConnection");
            
            RegisterMappings.Register();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

          //  services.AddScoped<IRepositoryBase<TEntity>, RepositoryBase<TEntity>>();
            services.AddScoped<IClienteService,ClienteService>();
            services.AddScoped<IClienteContract, ClienteRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
