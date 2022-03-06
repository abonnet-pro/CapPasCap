using CapPasCap.UsesCase.Entities;

namespace CapPasCap.UsesCase;

public interface IAuthentificationProvider
{
    public void createUser(User user);

    public bool authUser(User user);
}


