using CapPasCap.Infra.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CapPasCap.WebService.Tests;

public  class UserContextInMemoryEF : ProgramContextEF
{
    public UserContextInMemoryEF(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UserDto>(userDTO =>
        {
            userDTO.HasData(
                new UserDto() { login = "antho", password = "1401" },
                new UserDto() { login = "tony", password = "0114" }
                );
        });
    }


}

