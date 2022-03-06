
using Xunit;
using FluentAssertions;
using CapPasCap.UsesCase.Entities;

namespace CapPasCap.UsesCase.Tests;
public class UserShould
{
    [Fact]
    public void debileTest()
    {
        false.Should().BeFalse();
    }

    [Fact]
    public void UserShouldHaveLogin()
    {
        var user = new User("Tony", string.Empty);
        user.login.Should().Be("Tony");
    }

    [Fact]
    public void UserShouldHavePassword()
    {
        var user = new User(string.Empty, "pwd");
        user.password.Should().Be("pwd");
    }

    [Fact]
    public void UserIsValidShouldHaveLogin()
    {
        var user = new User("Tony", string.Empty);
        user.IsValid().Should().BeFalse();
    }

    [Fact]
    public void UserIsValidShouldHavePassword()
    {
        var user = new User(string.Empty, "pwd");
        user.IsValid().Should().BeFalse();
    }
}
