
using CapPasCap.UsesCase.Entities;

namespace CapPasCap.Infra.Dtos;

public class ChallengeDto
{
    public string text { get; set; }

    public int id { get; set; }

    public UserDto user { get; set; }

    public string UserLogin { get; set; }

    public int likesNumber { get; set; }
}

