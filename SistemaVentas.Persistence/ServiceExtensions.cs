
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVentas.Application.Interface.Persistence;
using SistemaVentas.Persistence.Context;
using SistemaVentas.Persistence.Repository;

namespace SistemaVentas.Persistence
{
    public static class ServiceExtensions
    {
        public static void AddPersistenceInfraestructure(
            this IServiceCollection services, 
            IConfiguration configuration)
        {

            services.AddDbContext<SistemaVentasContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("SistemaVentaDbConnection")
            ));
            services.AddTransient<IMarcaRepository, MarcaRepository>();


        }

    }
}
