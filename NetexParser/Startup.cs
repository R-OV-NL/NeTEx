using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetexParser.Data;

namespace NetexParser
{
    class Startup
    {
        public IConfiguration Configuration { get; }
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            //Add the configuration object to the service collection
            services.AddSingleton<IConfiguration>(Configuration);
            
            //Add DbContext
            services.AddDbContext<NetexContext>();
        }
        
        public static async Task Configure(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            
            var startup = new Startup(configuration);

            var services = new ServiceCollection()
                .AddSingleton<IConfiguration>(configuration)
                .AddSingleton<Startup>(startup)
                .BuildServiceProvider();
        }
        

    }
}

