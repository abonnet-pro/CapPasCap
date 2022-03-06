using CapPasCap.UsesCase.Entities;
using CapPasCap.UsesCase.Request;

namespace CapPasCap.UsesCase.UsesCase;

public class GetAllChallengesUseCase
{
    private readonly IChallengeProvider challengeProvider;
    public GetAllChallengesUseCase(IChallengeProvider challengeProvider)
    {
        this.challengeProvider = challengeProvider;
    }

    public List<Challenge> Execute(GetChallengeRequest getChallengeRequest)
    {
        var challenges = this.challengeProvider.getAll(getChallengeRequest);
        return challenges;
    }
}

