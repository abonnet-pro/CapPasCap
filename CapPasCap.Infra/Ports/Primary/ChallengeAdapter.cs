using CapPasCap.UsesCase;
using CapPasCap.UsesCase.Entities;
using CapPasCap.UsesCase.Request;
using CapPasCap.UsesCase.UsesCase;

namespace CapPasCap.Infra.Ports.Primary;

public class ChallengeAdapter
{
    private readonly IChallengeProvider _challenge;

    public ChallengeAdapter(IChallengeProvider challenge)
    {
        this._challenge = challenge;
    }

    public void createChallenge(string text, string login)
    {
        var createChallengeRequest = new CreateChallengeRequest()
        {
            text = text,
            login = login
        };

        var useCase = new CreateChallengeUseCase(_challenge);
        useCase.Execute(createChallengeRequest);
    }

    public List<Challenge> getAll()
    {
        var usecase = new GetAllChallengesUseCase(_challenge);
        return usecase.Execute(new GetChallengeRequest());
    }

    public void likeChallenge(int id)
    {
        var likeChallengeRequest = new LikeChallengeRequest()
        {
            id = id
        };

        var usecase = new LikeChallengeUseCase(_challenge);
        usecase.Execute(likeChallengeRequest);
    }
}

