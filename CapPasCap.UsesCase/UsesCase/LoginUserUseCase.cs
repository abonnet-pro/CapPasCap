using CapPasCap.UsesCase.Entities;
using CapPasCap.UsesCase.Request;

namespace CapPasCap.UsesCase;

public class LoginUserUseCase
{
    public IAuthentificationProvider user { get; }

    public LoginUserUseCase(IAuthentificationProvider user)
    {
        this.user = user;
    }

    public bool Execute(AuthUserRequest authUserRequest)
    {
        return this.user.authUser(new User(authUserRequest.login, authUserRequest.password));
    }
}

