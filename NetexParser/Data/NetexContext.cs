using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NetexParser.Data;

public class NetexContext : DbContext
{
    
    private readonly IConfiguration _configuration;
    
    public NetexContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("Default"));
    }
}