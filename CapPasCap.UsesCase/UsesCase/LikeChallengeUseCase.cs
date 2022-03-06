using CapPasCap.UsesCase.Entities;
using CapPasCap.UsesCase.Request;

namespace CapPasCap.UsesCase;

public class LikeChallengeUseCase
{
    private readonly IChallengeProvider challengeProvider;

    public LikeChallengeUseCase(IChallengeProvider challengeProvider)
    {
        this.challengeProvider = challengeProvider;
    }

    public void Execute(LikeChallengeRequest likeChallengeRequest)
    {
        this.challengeProvider.likeChallenge(likeChallengeRequest);
    }
}

