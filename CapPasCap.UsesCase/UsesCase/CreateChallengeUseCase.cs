using CapPasCap.UsesCase.Entities;
using CapPasCap.UsesCase.Request;

namespace CapPasCap.UsesCase;

public class CreateChallengeUseCase
{
    public IChallengeProvider challenge { get; }

    public CreateChallengeUseCase(IChallengeProvider challenge)
    {
        this.challenge = challenge;
    }

    public void Execute(CreateChallengeRequest createChallengeRequest)
    {
        this.challenge.createChallenge(new Challenge(createChallengeRequest.text), createChallengeRequest.login);
    }
}

