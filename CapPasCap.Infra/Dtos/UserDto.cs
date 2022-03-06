
namespace CapPasCap.Infra.Dtos;

public class UserDto
{
    public ICollection<ChallengeDto> challenges { get; set; } = new HashSet<ChallengeDto>();

    public string login { get; set; }

    public string password { get; set; }
}

