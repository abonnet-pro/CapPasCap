using CapPasCap.UsesCase;
using CapPasCap.UsesCase.Request;

namespace CapPasCap.Infra.Ports.Primary;

public class UserAdapter
{
    private readonly IAuthentificationProvider _authentification;

    public UserAdapter(IAuthentificationProvider authentification)
    {
        this._authentification = authentification;
    }
    
    public string createUser(string login, string password)
    {
        var createUserRequest = new CreateUserRequest()
        {
            login = login,
            password = password
        };

        var useCase = new CreateUserUseCase(_authentification);
        useCase.Execute(createUserRequest);
        return login;
    }

    public bool authUser(string login, string password)
    {
        var authUserRequest = new AuthUserRequest()
        {
            login = login,
            password = password
        };

        var useCase = new LoginUserUseCase(_authentification);
        return useCase.Execute(authUserRequest);
    }
}

