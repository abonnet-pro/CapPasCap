using CapPasCap.UsesCase.Entities;
using CapPasCap.UsesCase.Request;

namespace CapPasCap.UsesCase;

public class CreateUserUseCase
{
    public IAuthentificationProvider user { get; }

    public CreateUserUseCase(IAuthentificationProvider user)
    {
        this.user = user;
    }

    public void Execute(CreateUserRequest createUserRequest)
    {
        this.user.createUser(new User(createUserRequest.login, createUserRequest.password));
    }
}

