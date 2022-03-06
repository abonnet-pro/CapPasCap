using CapPasCap.Infra.Dtos;
using CapPasCap.UsesCase;
using CapPasCap.UsesCase.Entities;
using CapPasCap.UsesCase.Request;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CapPasCap.WebService.Services;

public class ChallengeProviderEF : IChallengeProvider
{
    public DbContext ChallengeContextEF { get; private set; }


    public ChallengeProviderEF(DbContext challengeContextEF)
    {
        this.ChallengeContextEF = challengeContextEF;
    }

    public void createChallenge(Challenge challenge, string login)
    {
        var userTable = ChallengeContextEF.Set<UserDto>();
        var user = userTable.Select(user => user.login == login);

        if(!user.Any())
        {
            throw new ChallengeException("L'utilisateur n'est pas reconnu, impossible de créer le défi.");
        }

        if (challenge.text.Length > 140)
        {
            throw new ChallengeException("Le texte du défi dépasse les 140 caractères.");
        }
        ChallengeContextEF.Add(new ChallengeDto() { text = challenge.text, UserLogin = login });
        ChallengeContextEF.SaveChanges();
    }

    public List<Challenge> getAll(GetChallengeRequest getChallengeRequest)
    {
        var challengeTable = ChallengeContextEF.Set<ChallengeDto>();
        return challengeTable.Select(challenge => new Challenge(challenge.text, challenge.UserLogin, challenge.id))
                             .ToList();
    }

    public void likeChallenge(LikeChallengeRequest likeChallengeRequest)
    {
        var challengeToLike = ChallengeContextEF.Set<ChallengeDto>().SingleOrDefault(challenge => challenge.id == likeChallengeRequest.id);

        if(challengeToLike != null)
        {
            challengeToLike.likesNumber++;
        }
        else throw new NotFoundEntiteException("Le challenge selectionné n'existe pas");

        ChallengeContextEF.Update(challengeToLike);
        ChallengeContextEF.SaveChanges();
    }
}

