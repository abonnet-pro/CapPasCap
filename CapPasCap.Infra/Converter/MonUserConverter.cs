
using CapPasCap.Infra.Dtos;
using CapPasCap.UsesCase;
using CapPasCap.UsesCase.Entities;

namespace CapPasCap.Infra;

public class MonUserConverter : IMonconverter<UserDto, User>
{
    public User Convert(UserDto user) => new User(user.login, user.password);
}
