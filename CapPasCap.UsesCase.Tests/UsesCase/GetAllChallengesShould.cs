using CapPasCap.UsesCase.Entities;
using CapPasCap.UsesCase.Request;
using CapPasCap.UsesCase.Tests.Fact;
using CapPasCap.UsesCase.UsesCase;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CapPasCap.UsesCase.Tests.UsesCase;

public class GetAllChallengesShould
{
    public GetAllChallengesShould()
    {
    }

    [Fact]
    public void GivenClient_WhenIGetChallenges_ShouldReturnByDEfault()
    {
        var assert = new GetAllChallengesUseCase(new ChallengeProviderFact());
        var challenges = assert.Execute(new GetChallengeRequest());
        challenges.Should().BeEquivalentTo(new List<Challenge>()
        {
            new Challenge("text", "user")
        });
    }
}
