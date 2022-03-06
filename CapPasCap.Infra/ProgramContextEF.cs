using CapPasCap.Infra.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CapPasCap.WebService;

public class ProgramContextEF : DbContext
{
    public ProgramContextEF(DbContextOptions options) : base(options) 
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserDto>(model =>
        {
            model.ToTable("User");
            model.HasKey(x => x.login);
            model.Property(x => x.password).IsRequired();
        });

        modelBuilder.Entity<ChallengeDto>(model =>
        {
            model.ToTable("Challenge");
            model.HasKey(x => x.id);
            model.Property(x => x.text).IsRequired();
            model.Property(x => x.likesNumber).IsRequired();
            model.HasOne(x => x.user)
                 .WithMany(x => x.challenges)
                 .HasForeignKey(challenge => challenge.UserLogin); 
        });
    }
}

