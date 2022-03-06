using CapPasCap.Infra.Ports.Primary;
using CapPasCap.UsesCase.Entities;
using FluentAssertions;
using Xunit;

namespace CapPasCap.Infra.Tests;

public class UserAdapterShould
{
    private UserAdapter createUserAdapter;

    public UserAdapterShould(UserAdapter createUserAdapter)
    {
        this.createUserAdapter = createUserAdapter;
    }

    [Fact]
    public void GivenUser_WhenICreateUser_ThenShouldReturnLogin()
    {
        var assert = createUserAdapter.createUser("tony", "pwd");
        assert.Should().BeEquivalentTo("tony");
    }
}

