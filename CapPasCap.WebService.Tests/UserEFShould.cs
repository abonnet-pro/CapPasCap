using Xunit;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using CapPasCap.UsesCase.Entities;
using CapPasCap.UsesCase;
using CapPasCap.WebService.Services;
using System.Linq;
using CapPasCap.Infra.Dtos;

namespace CapPasCap.WebService.Tests;

public class UserEFShould
{
    public DbContext DbContext { get; }
    public IMonconverter<UserDto, User> Converter { get; }

    public UserEFShould(DbContext dbcontext, IMonconverter<UserDto, User> converter)
    {
        this.DbContext = dbcontext;
        this.Converter = converter;
    }

    [Fact]
    public void DebileTest()
    {
        false.Should().BeFalse();
    }

    [Fact]
    public void createUser()
    {
        var user = new User("loginToAdd", "passwordToAdd");
        var userCatalogue = new AuthentificationProviderEF(this.DbContext, this.Converter);
        userCatalogue.createUser(user);
        DbContext.Set<UserDto>().Single(x => x.login == "loginToAdd").Should().BeEquivalentTo(user);
    }

    [Fact]
    public void WhenIauthUser_ShouldReturnTrue()
    {
        var user = new User("user", "password");
        var userCatalogue = new AuthentificationProviderEF(this.DbContext, this.Converter);
        userCatalogue.createUser(user);
        var assert = userCatalogue.authUser(user);
        assert.Should().BeTrue();
    }
}