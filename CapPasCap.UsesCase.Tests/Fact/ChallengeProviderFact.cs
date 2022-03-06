using CapPasCap.UsesCase.Entities;
using CapPasCap.UsesCase.Request;
using System.Collections.Generic;

namespace CapPasCap.UsesCase.Tests.Fact;

public class ChallengeProviderFact : IChallengeProvider
{
    public void createChallenge(Challenge challenge, string login)
    {

    }

    public List<Challenge> getAll(GetChallengeRequest getChallengeRequest)
    {
        return new List<Challenge>()
        {
            new Challenge("text", "user")
        };
    }
}

