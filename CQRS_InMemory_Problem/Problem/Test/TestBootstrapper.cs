using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;
using Write;
using Read;

namespace Test
{
    public static class TestBootstrapper
    {
        [ScenarioDependencies]
        public static IServiceCollection RegisterDependencies()
        {
            var services = new ServiceCollection();

            var dbID = Guid.NewGuid().ToString();

            services.AddDbContext<WriteDbContext>(builder =>
            {
                builder.UseInMemoryDatabase(dbID);
            });

            services.AddDbContext<ReadDbContext>(builder =>
            {
                builder.UseInMemoryDatabase(dbID);
            });

            services.AddScoped<IWriteRepository, WriteRepository>();
            services.AddScoped<IReadRepository, ReadRepository>();

            return services;
        }
    }
}
