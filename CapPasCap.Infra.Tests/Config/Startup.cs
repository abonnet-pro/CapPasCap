using CapPasCap.Infra.Dtos;
using CapPasCap.Infra.Ports.Primary;
using CapPasCap.UsesCase;
using CapPasCap.UsesCase.Entities;
using CapPasCap.WebService;
using CapPasCap.WebService.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CapPasCap.Infra.Tests;

public class Startup
{
    public void ConfigureServices(IServiceCollection services, HostBuilderContext hostBuilderContext)
    {
        services.AddDbContext<DbContext, ProgramContextEF>(c => c.UseInMemoryDatabase("userContextTests"));
        services.AddTransient<UserAdapter>(container => new UserAdapter(container.GetService<IAuthentificationProvider>()));
        services.AddTransient<IAuthentificationProvider, AuthentificationProviderEF>();
        services.AddTransient<AuthentificationProviderEF>();
        services.AddTransient<IMonconverter<UserDto, User>, MonUserConverter>();
    }
}


        
