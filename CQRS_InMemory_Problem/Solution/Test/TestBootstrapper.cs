using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;
using Write;
using Read;
using System.IO;

namespace Test
{
    public static class TestBootstrapper
    {
        [ScenarioDependencies]
        public static IServiceCollection RegisterDependencies()
        {
            var services = new ServiceCollection();

            var tempFile = Path.GetTempFileName();

            services.AddDbContext<TestDbContext>(builder =>
            {
                builder.UseSqlite($"Data Source={tempFile}");
            });

            services.AddScoped<DbContext, TestDbContext>();

            services.AddScoped<IWriteRepository, WriteRepository>();
            services.AddScoped<IReadRepository, ReadRepository>();

            return services;
        }
    }
}
