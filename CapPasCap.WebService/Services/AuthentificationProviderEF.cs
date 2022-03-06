using CapPasCap.Infra.Dtos;
using CapPasCap.UsesCase;
using CapPasCap.UsesCase.Entities;
using Microsoft.EntityFrameworkCore;

namespace CapPasCap.WebService.Services;

public class AuthentificationProviderEF : IAuthentificationProvider
{
    public DbContext UserContextEF { get; private set; }
    public IMonconverter<UserDto, User> Converter { get; }


    public AuthentificationProviderEF(DbContext userContextEF, IMonconverter<UserDto, User> monConverter)
    {
        this.UserContextEF = userContextEF;
        this.Converter = monConverter;
    }

    public void createUser(User user)
    {
        UserContextEF.Add(new UserDto() { login = user.login, password = user.password });
        UserContextEF.SaveChanges();
    }

    public bool authUser(User user)
    {
        var userTable = UserContextEF.Set<UserDto>();
        var auth = userTable.Select(u => u.login == user.login);
        return auth.Any();
    }
}

