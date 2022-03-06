using CapPasCap.UsesCase.Entities;
using CapPasCap.UsesCase.Request;

namespace CapPasCap.UsesCase;

public interface IChallengeProvider
{
    public void createChallenge(Challenge challenge, string login);

    public List<Challenge> getAll(GetChallengeRequest getChallengeRequest);

    public void likeChallenge(LikeChallengeRequest likeChallengeRequest);
}


