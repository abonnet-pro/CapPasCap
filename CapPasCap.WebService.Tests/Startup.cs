using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CapPasCap.UsesCase;
using CapPasCap.UsesCase.Entities;
using CapPasCap.Infra.Dtos;
using CapPasCap.Infra;

namespace CapPasCap.WebService.Tests;

public class Startup
{
    public void ConfigureServices(IServiceCollection services, HostBuilderContext hostBuilderContext)
    {
        services.AddDbContext<DbContext, UserContextInMemoryEF>(option => option.UseInMemoryDatabase("UserDatabase"));
        services.AddTransient<IMonconverter<UserDto, User>, MonUserConverter>();
    }
}
